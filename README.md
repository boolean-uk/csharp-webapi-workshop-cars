# C# WebApi Template

This is a template for a C# WebApi project. It includes a basic structure for a WebApi project, with a simple endpoint 

## Version 9 WebApi Template

- Everything is mapped in the Program.cs file.  
- Swagger no longer included - do have the open api spec: [https://localhost:7199/openapi/v1.json](https://localhost:7199/openapi/v1.json)

## Install Swagger

- Can install Swagger with Swashbuckle.AspNetCore the Program.cs should look like this (the only modification in the app.Environment.IsDevelopment() if statement):
- Visit [https://localhost:7199/swagger](https://localhost:7199/swagger)

```cs
var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
// Learn more about configuring OpenAPI at https://aka.ms/aspnet/openapi
builder.Services.AddOpenApi();


var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.MapOpenApi();
    app.UseSwaggerUI(options =>
    {
        options.SwaggerEndpoint("/openapi/v1.json", "Demo API");
    });
}

app.UseHttpsRedirection();

var summaries = new[]
{
    "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
};

app.MapGet("/weatherforecast", () =>
{
    var forecast =  Enumerable.Range(1, 5).Select(index =>
        new WeatherForecast
        (
            DateOnly.FromDateTime(DateTime.Now.AddDays(index)),
            Random.Shared.Next(-20, 55),
            summaries[Random.Shared.Next(summaries.Length)]
        ))
        .ToArray();
    return forecast;
})
.WithName("GetWeatherForecast");

app.Run();

record WeatherForecast(DateOnly Date, int TemperatureC, string? Summary)
{
    public int TemperatureF => 32 + (int)(TemperatureC / 0.5556);
}

```

## Install Scalar

- install-package Scalar.AspNetCore
- Change the Program.cs and add app.MapScalarApiReference(); in the if statement:
  
```cs
if (app.Environment.IsDevelopment())
{
    app.MapOpenApi();
    app.UseSwaggerUI(options =>
    {
        options.SwaggerEndpoint("/openapi/v1.json", "Demo API");
    });
    app.MapScalarApiReference();
}
```
- visit: [https://localhost:7199/scalar/v1](https://localhost:7199/scalar/v1)


## Useful Resources

- Microsoft provide some further reading on the subject [here](https://learn.microsoft.com/en-us/aspnet/core/fundamentals/apis?view=aspnetcore-8.0)
- Verb definitions [here](https://developer.mozilla.org/en-US/docs/Web/HTTP/Status)