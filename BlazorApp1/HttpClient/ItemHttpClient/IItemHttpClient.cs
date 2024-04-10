using Data.Entities;
using Shared.DAO;

namespace BlazorApp1.HttpClient.ItemHttpClient;

public interface IItemHttpClient
{
    Task<Item> CreateItem(CreateItemDAO item);
}