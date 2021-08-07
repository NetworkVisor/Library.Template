#!/usr/bin/env pwsh

<#
.SYNOPSIS
    Downloads and installs the Microsoft Maui workloads.
    See https://docs.microsoft.com/en-us/dotnet/maui/get-started/installation
    Used to build Maui apps.
#>
[CmdletBinding()]
Param (
)

$envVars = @{}

Write-Host "Installing maui workload"
dotnet workload install maui

$toolInstallDir = & "$PSScriptRoot\..\azure-pipelines\Get-TempToolsPath.ps1"

$toolPath = "$toolInstallDir\maui-check"
if (!(Test-Path $toolInstallDir)) { New-Item -Path $toolInstallDir -ItemType Directory | Out-Null }

if (!(Get-Command $toolInstallDir -ErrorAction SilentlyContinue)) {
    Write-Host "Installing maui-check to $toolInstallDir"
    dotnet tool install redth.net.maui.check --tool-path "$toolInstallDir"
	$mauiCheckCmd = & "$PSScriptRoot\..\azure-pipelines\Get-MauiCheckTool.ps1"
	& $mauiCheckCmd --ci --non-interactive --fix
}

& "$PSScriptRoot/Set-EnvVars.ps1" -Variables $envVars | Out-Null 
