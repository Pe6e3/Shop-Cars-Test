using Shop.Data.Interfaces;
using Shop.Data.Models;

namespace Shop.Data.Mocks;

public class MockCategory : ICarsCategory
{
    public IEnumerable<Category> AllCategories
    {
        get
        {
            return new List<Category>{
                new Category{categoryName = "Электрмобили", desc = "Совеременный вид транспорта" },
                new Category{categoryName = "Классические автомобили", desc = "Машины с ДВС" },
            }; 
        }
    }
}
