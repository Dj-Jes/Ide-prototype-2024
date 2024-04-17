using System.Net.Http.Json;
using System.Text.Json;
using Data.Entities;
using Shared.DAO;


namespace BlazorApp1.HttpClient.ItemHttpClient;

public class ItemHttpClient : IItemHttpClient
{
    private readonly System.Net.Http.HttpClient client;
    
    public ItemHttpClient(System.Net.Http.HttpClient client)
    {
       this .client = client;
    }


    public async Task<Item> CreateItem(CreateItemDAO itemDao)
    {
        HttpResponseMessage response = await client.PostAsJsonAsync("/item", itemDao);
        
        string result = await response.Content.ReadAsStringAsync();

        if (!response.IsSuccessStatusCode)
        {
            throw new Exception(result); 
        }

        Item item = JsonSerializer.Deserialize<Item>(result, new JsonSerializerOptions
        {
            PropertyNameCaseInsensitive = true
        })!;
        return item;
    }

    public async Task<Item> TakeItem(int itemID)
    {
        HttpResponseMessage response = await client.DeleteAsync($"Item/{itemID}");
        string result = await response.Content.ReadAsStringAsync();

        if (!response.IsSuccessStatusCode)
        {
            throw new Exception(result); 
        }

        Item item = JsonSerializer.Deserialize<Item>(result, new JsonSerializerOptions
        {
            PropertyNameCaseInsensitive = true
        })!;
        return item;
    }
    
}
