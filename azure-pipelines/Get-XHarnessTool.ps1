<#
.SYNOPSIS
    Gets the path to the XHarness CLI tool, installing it if necessary.
#>
Param(
)

$existingTool = Get-Command "xharness" -ErrorAction SilentlyContinue
if ($existingTool) {
    return $existingTool.Path
}

$toolInstallDir = & "$PSScriptRoot/Get-TempToolsPath.ps1"

$toolPath = "$toolInstallDir/xharness"
if (!(Test-Path $toolInstallDir)) { New-Item -Path $toolInstallDir -ItemType Directory | Out-Null }

if (!(Get-Command $toolPath -ErrorAction SilentlyContinue)) {
    Write-Host "Installing xharness to $toolInstallDir"
    dotnet tool install Microsoft.DotNet.XHarness.CLI --tool-path "$toolInstallDir" --add-source https://pkgs.dev.azure.com/dnceng/public/_packaging/dotnet-eng/nuget/v3/index.json --version "1.0.0-prerelease*" | Out-Null
}

# Normalize the path on the way out.
return (Get-Command $toolPath).Path
