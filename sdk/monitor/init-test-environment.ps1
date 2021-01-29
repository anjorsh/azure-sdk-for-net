param(
    [Parameter(Mandatory=$True,HelpMessage="Please enter the Subscription Id (GUID) to setup your test environment.")]
    [System.String]
    $Subscription
)

# This script requires the AZ Powershell module from the PowerShellGallery
# https://docs.microsoft.com/en-us/powershell/azure/install-az-ps
# https://www.powershellgallery.com/packages/Az

Connect-AzAccount -Subscription $Subscription

$RootDirectory = (get-item $PSScriptRoot).parent.parent
$TestResourcesDirectory = Join-Path -Path $RootDirectory -ChildPath eng\common\TestResources

& $TestResourcesDirectory\New-TestResources.ps1 monitor