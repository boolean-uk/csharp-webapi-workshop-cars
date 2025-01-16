using Microsoft.AspNetCore.Mvc;
using workshop.wwwapi.Models;
using workshop.wwwapi.Repository;

namespace workshop.wwwapi.Endpoints
{
    public static class CarEndpoints
    {
  
        public static void ConfigureCarEndpoint(this WebApplication app)
        {
            var cars = app.MapGroup("cars");

            cars.MapGet("/", GetCars);
            cars.MapPost("/", AddCar);
            
        }
        [ProducesResponseType(StatusCodes.Status200OK)]
        public static async Task<IResult> GetCars(IRepository repository)
        
        {
            return TypedResults.Ok(repository.GetCars());
        }

        [ProducesResponseType(StatusCodes.Status200OK)]
        public static async Task<IResult> AddCar(IRepository repository, Car car)
        {
            var result = repository.AddCar(car);
            return TypedResults.Ok(result);
        }




    }
}
