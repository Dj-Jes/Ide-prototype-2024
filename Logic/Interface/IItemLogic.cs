using Data.Entities;
using Shared.DAO;

namespace Logic.Interface;

public interface IItemLogic
{
    public Task<Item> CreateAsyncItem(CreateItemDAO createItemDao);
    public Task<Item> RemovedAsyncItem(int removedItemID);

    public Task<List<Item>> GetAllItem(GetItemsDAO dao);
}