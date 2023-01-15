using Shop.Data.Interfaces;
using Shop.Data.Models;

namespace Shop.Data.Repository;

public class CarRepository : IAllCars
{

    private readonly AppDBContent appDBContent;

    public IEnumerable<Car> Cars => throw new NotImplementedException();

    public IEnumerable<Car> getFavCars { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

    public Car getObjectCar(int carId)
    {
        throw new NotImplementedException();
    }
}
