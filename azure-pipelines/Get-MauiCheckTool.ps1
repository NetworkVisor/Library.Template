<#
.SYNOPSIS
    Gets the path to the Maui-Check tool, installing it if necessary.
#>
Param(
)

$existingTool = Get-Command "maui-check" -ErrorAction SilentlyContinue
if ($existingTool) {
    return $existingTool.Path
}

$toolInstallDir = & "$PSScriptRoot/Get-TempToolsPath.ps1"

$toolPath = "$toolInstallDir/maui-check"
if (!(Test-Path $toolInstallDir)) { New-Item -Path $toolInstallDir -ItemType Directory | Out-Null }

if (!(Get-Command $toolPath -ErrorAction SilentlyContinue)) {
    Write-Host "Installing maui-check to $toolInstallDir"
    dotnet tool install redth.net.maui.check --tool-path "$toolInstallDir"
}

# Normalize the path on the way out.
return (Get-Command $toolPath).Path
