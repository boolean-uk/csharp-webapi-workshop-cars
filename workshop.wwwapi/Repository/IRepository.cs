using workshop.wwwapi.Models;

namespace workshop.wwwapi.Repository
{
    public interface IRepository
    {
        IEnumerable<Car> GetCars();
        Car AddCar(Car entity);
    }
}
