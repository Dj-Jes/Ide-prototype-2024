﻿using Data.Entities;
using Shared.DAO;

namespace Data.DataAccess;

public interface IDataAccess
{
    public Task<Item> CreateItem(Item item);

    public Task<Item> RemovedItem(int id, DateTime today);

    public Task<List<Item>> GetAllItems(GetItemsDAO dao);
    /*
    public Task<DrinksMenu> CreateDrinksMenu(DrinksMenu drinksMenu);
    public Task<DrinksMenu> AddDrinkToDrinkMenu(int drinksMenuId, int drinkId);
    
    public Task<List<DrinksMenu>> GetDrinksMenusOrderedByTotalPrice();
    
    public Task <List<Item>> GetDrinksByFilter(double? lowerAlcoholPrecentage, double? higherAlcoholPrecentage, bool needsUmbrella);
    */
}