# How to implement multiple themes in BlazorWasm app
By [Kelvin Binh](https://github.com/kelvin-binh)

The simple project demonstrates how to implement multiple themes in BlazorWasm app

> Usage with careful: The project is in experimental research for BlazorWasm with .NET Core 3.0 SDK

## Screenshots

<details>
  <summary>Default Theme</summary>
  
  ![dashboard](snapshoots/Dashboard-Default.png?raw=true)
  
  ![news-feed](snapshoots/NewsFeed-Default.png?raw=true)
  
</details>

<details>
  <summary>RainyDay Theme</summary>
  
  ![dashboard](snapshoots/Dashboard-RainyDay.png?raw=true)
  
  ![weather-summary](snapshoots/WeatherSummary-RainyDay.png?raw=true)

</details>

<details>
  <summary>Redwood Theme</summary>
  
  ![dashboard](snapshoots/Dashboard-Redwood.png?raw=true)
  
  ![temperature](snapshoots/Temperature-Redwood.png?raw=true)

</details>

# Table of contents

- [Build Up And Running](https://github.com/kelvin-binh/blazor-dynamic-themes-sample#build-up-and-running)
- [Test Switch Theme](https://github.com/kelvin-binh/blazor-dynamic-themes-sample#test-switch-theme)

## Build Up And Running

1. Install the latest [.NET Core 3.0 SDK](https://dotnet.microsoft.com/download/dotnet-core/3.0) release.

2. Build project and all of its dependencies.

   ```dotnetcli
   dotnet build
   ```
3. Or run run source code without any explicit compile or launch commands
   ```dotnetcli
   dotnet run
   ```
4. From browser, open [https://localhost:5001](https://localhost:5001)

## Test Switch Theme

To switch an existed themes (`Default`, `RainyDay`, `Redwood`), simply changing value of `activeTheme` from `./wwwroot/sample-data/settings.json` file

```json
{
    "activeTheme": "Default"
}
```

