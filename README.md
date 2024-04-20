
# Weather Application

This is a simple weather application built using ASP.NET Core Razor Pages. It displays weather information for cities, including the city name, temperature, and a color-coded representation based on the temperature.

## Project Structure

The project structure is as follows:

- `WeatherApp/`: Main project folder.
  - `Models/`: Contains the model classes for the application.
    - `Weather.cs`: Model class for weather information.
  - `Views/`: Contains the Razor views for the application.
    - `Shared/`: Contains shared Razor files.
      - `_Layout.cshtml`: Layout file for the application.
      - `SharedFunctions.cshtml`: Shared Razor file containing common functions.
    - `Weather/`: Contains Razor files specific to the weather feature.
      - `Index.cshtml`: Razor view for displaying weather information.

## Functionality

### SharedFunctions.cshtml

This file contains a shared Razor function called `GetClass` which determines the CSS class for styling based on the temperature. It is reused across multiple views in the application to maintain consistency in temperature display.

### Weather/Index.cshtml

This Razor view displays weather information for a specific city. It uses the `GetClass` function from `SharedFunctions.cshtml` to determine the styling based on the temperature fetched from the model.

## Usage

To use this application:

1. Clone the repository to your local machine.
2. Open the solution file (`WeatherApp.sln`) in Visual Studio or your preferred IDE.
3. Build and run the application.
4. Navigate to the Weather page to view weather information for different cities.
