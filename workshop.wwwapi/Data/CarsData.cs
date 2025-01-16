using workshop.wwwapi.Models;

namespace workshop.wwwapi.Data
{
    public static class CarsData
    {
        public static List<Car> Cars { get; set; } = new List<Car>();

        public static void Initialize()
        {
            Cars.Add(new Car { Id = 1, Make = "Tesla", Model = "CyberTruck" });
            Cars.Add(new Car { Id = 2, Make = "Ford", Model = "Focus" });
            Cars.Add(new Car { Id = 3, Make = "Ford", Model = "Mondeo" });
            Cars.Add(new Car { Id = 4, Make = "Vauxhall", Model = "Corsa" });
            Cars.Add(new Car { Id = 5, Make = "Vauxhall", Model = "Astra" });
            Cars.Add(new Car { Id = 6, Make = "Vauxhall", Model = "Insignia" });
            Cars.Add(new Car { Id = 7, Make = "Volkswagen", Model = "Polo" });
            Cars.Add(new Car { Id = 8, Make = "Volkswagen", Model = "Golf" });
            Cars.Add(new Car { Id = 9, Make = "Volkswagen", Model = "Passat" });
        }
    }
}
