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

    public async Task<List<Item>> GetItem(GetItemsDAO dao)
    {
        string added = ConstrunctQuery(dao.IsTaken, dao.SorteringCategory);
        HttpResponseMessage response = await client.GetAsync($"/Item"+ added);
        string result = await response.Content.ReadAsStringAsync();

        if (!response.IsSuccessStatusCode)
        {
            throw new Exception(result); 
        }

        List<Item> items = JsonSerializer.Deserialize<List<Item>>(result, new JsonSerializerOptions
        {
            PropertyNameCaseInsensitive = true
        })!;
        return items;
    }

    private static string ConstrunctQuery(bool? IsTaken, SorteringCategory? sorteringCategory)
    {
        string query = "";
        if (IsTaken != null)
        {
            query += string.IsNullOrEmpty(query) ? "?" : "&";
            query += $"isTaken={IsTaken}";
        }

        if (sorteringCategory != null)
        {
            query += string.IsNullOrEmpty(query) ? "?" : "&";
            query += $"sorteringCategory={IsTaken}";
        }

        return query;
    }
    
    public async Task GetExcelData()
    {
        //HttpResponseMessage response = await client.GetAsync($"/");
        HttpResponseMessage response = await client.GetAsync("api/data/getExcelData");
        string result = await response.Content.ReadAsStringAsync();
    }
}
