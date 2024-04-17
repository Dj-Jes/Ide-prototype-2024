using Data.Entities;
using Shared.DAO;

namespace BlazorApp1.HttpClient.ItemHttpClient;

public interface IItemHttpClient
{
    public Task<Item> CreateItem (CreateItemDAO item);
    public Task<Item> TakeItem(int ItemID);
}