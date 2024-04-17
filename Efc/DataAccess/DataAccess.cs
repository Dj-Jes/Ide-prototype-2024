using Data.Entities;
using Efc;
using Microsoft.EntityFrameworkCore;

namespace Data.DataAccess;

public class DataAccess : IDataAccess
{
    private readonly DataContext _dataContext;
    
    public DataAccess(DataContext dataContext)
    {
        _dataContext = dataContext;
    }
    /*
    public async Task<DrinksMenu> CreateDrinksMenu(DrinksMenu drinksMenu)
    {
        _dataContext.DrinkMenus.Add(drinksMenu);
        await _dataContext.SaveChangesAsync();
        return drinksMenu;
    }
    */
    public async Task<Item> CreateItem(Item item)
    {
        _dataContext.Items.Add(item);
        await _dataContext.SaveChangesAsync();
        return item;
    }

    public async Task<Item> RemovedItem(int id)
    {
        Item choosenItem = await _dataContext.Items.Where(item => item.ItemId == id).FirstAsync();

        choosenItem.IsTaken = true;
        await _dataContext.SaveChangesAsync();
        return choosenItem;
    }
/*
    public async Task<DrinksMenu> AddDrinkToDrinkMenu(int drinksMenuId, int drinkId)
    {
        var drinkMenue = await _dataContext.DrinkMenus
            .Include(d => d.Drinks)
            .FirstOrDefaultAsync( d => d.DrinkMenuId == drinksMenuId);
        if (drinkMenue == null )
        {
            throw new ArgumentException("DrinkMenu not found");
        }
        
        drinkMenue.Drinks.Add(await _dataContext.Drinks.FindAsync(drinkId));
        await _dataContext.SaveChangesAsync();
        return drinkMenue;
    }

    public Task<List<DrinksMenu>> GetDrinksMenusOrderedByTotalPrice()
    {
        return _dataContext.DrinkMenus
            .Include(d => d.Drinks)
            .OrderByDescending(d => d.Drinks.Sum(d => d.Price))
            .ToListAsync();
    }

    public Task<List<Drink>> GetDrinksByFilter(double? lowerAlcoholPrecentage, double? higherAlcoholPrecentage, bool needsUmbrella)
    {
       return _dataContext.Drinks
            .Where(d => d.AlcoholPrecentage >= lowerAlcoholPrecentage && d.AlcoholPrecentage <= higherAlcoholPrecentage && d.IncludeUmbrella == needsUmbrella)
            .ToListAsync();
    }
    */
}