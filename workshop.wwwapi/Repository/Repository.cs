using workshop.wwwapi.Data;
using workshop.wwwapi.Models;

namespace workshop.wwwapi.Repository
{
    public class Repository : IRepository
    {
        public Car AddCar(Car entity)
        {
            int nextId = CarsData.Cars.Max(c => c.Id) + 1;
            entity.Id = nextId;
            CarsData.Cars.Add(entity);
            return entity;


        }

        public IEnumerable<Car> GetCars()
        {
            return CarsData.Cars;
        }
    }
}
