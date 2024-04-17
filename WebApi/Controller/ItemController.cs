using Data.Entities;
using Logic.Interface;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Query;
using Shared.DAO;

namespace WebApi.Controller;

[ApiController]
[Route("[Controller]")]
public class ItemController : ControllerBase
{
    private IItemLogic _itemLogic;
    
    public ItemController(IItemLogic itemLogic) {
        this._itemLogic = itemLogic;
    }
    [HttpPost]
    public async Task<ActionResult<Item>> CreateAsync([FromBody]CreateItemDAO dto) {
        try
        {
            Item item = await _itemLogic.CreateAsyncItem(dto);
            return Created($"/item", item);
        }
        catch (Exception e) {
            Console.WriteLine(e);
            return StatusCode(500, e.Message);
        }
    }

    [HttpDelete("{id:int}")]
    public async Task<ActionResult<Item>> RemoveItemAsync([FromRoute] int id)
    {
        try
        {
            Item item = await _itemLogic.RemovedAsyncItem(id);
            return Created($"/item", item);
        }
        catch (Exception e) {
            Console.WriteLine(e);
            return StatusCode(500, e.Message);
        }
    }

    [HttpGet]
    public async Task<ActionResult<List<Item>>> GetItems([FromQuery]bool? isTaken, [FromQuery] SorteringCategory? sorteringCategory)
    {
        try
        {
            GetItemsDAO dao = new GetItemsDAO();
            dao.IsTaken = isTaken;
            dao.SorteringCategory = sorteringCategory;
            List<Item> item = await _itemLogic.GetAllItem(dao);
            return Created($"/item", item);
        }
        catch (Exception e) {
            Console.WriteLine(e);
            return StatusCode(500, e.Message);
        }
    }
}