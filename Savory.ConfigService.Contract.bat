msbuild Savory.ConfigService.Contract\Savory.ConfigService.Contract.csproj /t:rebuild /p:configuration=release;DocumentationFile=bin\Release\Savory.ConfigService.Contract.xml;DebugType=none

nuget pack Savory.ConfigService.Contract.nuspec

move /y Savory.ConfigService.Contract.*.nupkg D:\LocalWebRoot\SavoryNuget\Packages

pause