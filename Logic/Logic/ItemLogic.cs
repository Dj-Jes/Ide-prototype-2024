using Data.DataAccess;
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
        Item item = new Item();
        item.Type = createItemDao.Type;
        item.Weight = createItemDao.Weight;
        item.SoteringCategory = createItemDao.SoteringCategory;
        item.IsTaken = false;

        return await _dataAccess.CreateItem(item);
    }

    public async Task<Item> RemovedAsyncItem(int removedItemID)
    {
        Item item = await _dataAccess.RemovedItem(removedItemID);
        return item;
    }
}