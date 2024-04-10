using Data.Entities;
using Shared.DAO;

namespace Logic.Interface;

public interface IItemLogic
{
    public Task<Item> CreateAsyncItem(CreateItemDAO createItemDao);
}