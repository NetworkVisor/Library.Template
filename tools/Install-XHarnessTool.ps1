#!/usr/bin/env pwsh

<#
.SYNOPSIS
    Downloads and installs the Microsoft XHarness DotNet Tool.
    See https://github.com/dotnet/xharness/
    Used to run xunit tests on Android and IOS Simulators.
#>
[CmdletBinding()]
Param (
)

$envVars = @{}

$toolInstallDir = & "$PSScriptRoot\..\azure-pipelines\Get-TempToolsPath.ps1"

$toolPath = "$toolInstallDir/xharness"
if (!(Test-Path $toolInstallDir)) { New-Item -Path $toolInstallDir -ItemType Directory | Out-Null }

if (!(Get-Command $toolPath -ErrorAction SilentlyContinue)) {
    Write-Host "Installing xharness to $toolInstallDir"
    dotnet tool install Microsoft.DotNet.XHarness.CLI --tool-path "$toolInstallDir" --add-source https://pkgs.dev.azure.com/dnceng/public/_packaging/dotnet-eng/nuget/v3/index.json --version "1.0.0-prerelease*"
    $xharnessCmd = & "$PSScriptRoot\..\azure-pipelines\Get-XHarnessTool.ps1"
	& $xharnessCmd version
}

& "$PSScriptRoot/Set-EnvVars.ps1" -Variables $envVars | Out-Null
