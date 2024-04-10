using Data.Entities;

namespace Data.DataAccess;

public interface IDataAccess
{
    public Task<Drink> CreateDrink(Drink drink);
    public Task<DrinksMenu> CreateDrinksMenu(DrinksMenu drinksMenu);
    public Task<DrinksMenu> AddDrinkToDrinkMenu(int drinksMenuId, int drinkId);
    
    public Task<List<DrinksMenu>> GetDrinksMenusOrderedByTotalPrice();
    
    public Task <List<Drink>> GetDrinksByFilter(double? lowerAlcoholPrecentage, double? higherAlcoholPrecentage, bool needsUmbrella);
}