# Custom Json Formatter
## Short Description
Add custom JSON formatter to ASP.NET Core MVC application.
## Topics
* ASP.NET Core
* MVC apps
* WebApi apps
* Controllers, Views, Models
* Dependency Injection
* Startup class
* Testing and Debugging
## Requirements
* If not specified, feel free to choose between .NET Core and .NET Framework technology, but the first one is prefered.
* Remember about code style and naming conventions.
* Hosting application with IIS is welcome but not required.
* Using of the 3rd party libraries that ease the task implementation directly is prohibited.
* Create next API endpoints:
    /api/article GET
    /api/article/{id} GET
    /api/profile/{id} GET
* The user should be able to use:
    default Json Formatter using application/json Accept header,
    custom Json Formatter using application/json+cutom Accept header.
* The formatter should be configurable via extending IMvcBuilder and added in ConfigureServices method.