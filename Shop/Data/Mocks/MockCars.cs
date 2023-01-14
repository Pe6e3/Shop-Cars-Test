using Shop.Data.Interfaces;
using Shop.Data.Models;

namespace Shop.Data.Mocks;

public class MockCars : IAllCars
{
    private readonly ICarsCategory _categoryCars = new MockCategory();
    public IEnumerable<Car> Cars
    {
        get
        {
            return new List<Car>
            {
                new Car
                {
                    name = "Tesla Model S",
                    shortDesc = "Быстрый авто",
                    longDesc = "Красивый, быстрый, тихий, экологичный",
                    img = "img1",
                    price = 45000,
                    isFavourite = true,
                    avaliable = true,
                    Category = _categoryCars.AllCategories.First()
                },
                new Car
                {
                    name = "Ford Fiesta",
                    shortDesc = "Тихий и спокойный",
                    longDesc = "Удобный для городской жизни",
                    img = "img2",
                    price = 11000,
                    isFavourite = false,
                    avaliable = true,
                    Category = _categoryCars.AllCategories.Last()
                },
                new Car
                {
                    name = "BMW M3",
                    shortDesc = "Дерзкий и стильный",
                    longDesc = "Удобный для городской жизни",
                    img = "img3",
                    price = 59000,
                    isFavourite = true,
                    avaliable = true,
                    Category = _categoryCars.AllCategories.Last()
                },

                new Car
                {
                    name = "Mercedes S class",
                    shortDesc = "Премиум класс",
                    longDesc = "Удобный для городской жизни",
                    img = "img4",
                    price = 63000,
                    isFavourite = true,
                    avaliable = true,
                    Category = _categoryCars.AllCategories.Last()
                },

                new Car
                {
                    name = "Nissan Leaf",
                    shortDesc = "Бесшимный и экономичный",
                    longDesc = "Удобный для городской жизни",
                    img = "img5",
                    price = 14000,
                    isFavourite = true,
                    avaliable = true,
                    Category = _categoryCars.AllCategories.First()
                }

            };
        }
    }

    public IEnumerable<Car> getFavCars { get; set; } 

    public Car getObjectCar(int carId)
    {
        throw new NotImplementedException();
    }
}

