﻿using Data.DataAccess;
using Data.Entities;
using Logic.Interface;
using Shared.DAO;

namespace Logic;

public class ItemLogic :IItemLogic
{
    private readonly IDataAccess _dataAccess;

    public ItemLogic(IDataAccess dataAccess)
    {
        _dataAccess = dataAccess;
    }
    
    public async Task<Item> CreateAsyncItem(CreateItemDAO createItemDao)
    {
        Item item = new Item(createItemDao);

        return await _dataAccess.CreateItem(item);
    }
}