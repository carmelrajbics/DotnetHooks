## POC on Dotnet hooks 

> ### Setting enviroment variable for Startup hooks at global level
>  $env:DOTNET_STARTUP_HOOKS="D:\DOP\Carmel\pub\\SampleHook.dll;D:\DOP\Carmel\pub\\SampleHook.dll;"


### Set the Dotnet startup hook at application profiler level in lauchSettings.json
```json
 "WeatherApi": {
      "commandName": "Project",
      "dotnetRunMessages": true,
      "launchBrowser": true,
      "launchUrl": "swagger",
      "applicationUrl": "https://localhost:7088;http://localhost:5088",
      "environmentVariables": {
        "ASPNETCORE_ENVIRONMENT": "Development",
        "DOTNET_STARTUP_HOOKS": "D:\\DOP\\Carmel\\POC\\DotnetHooks\\SampleHook\\bin\\Debug\\net6.0\\publish\\SampleHook.dll"
      }
    },
```
