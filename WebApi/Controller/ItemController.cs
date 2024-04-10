using Data.Entities;
using Logic.Interface;
using Microsoft.AspNetCore.Mvc;
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
        try {
            Console.WriteLine(dto);
            Item item = await _itemLogic.CreateAsyncItem(dto);
            return Created($"/item/{item.ItemId}", item);
        }
        catch (Exception e) {
            Console.WriteLine(e);
            return StatusCode(500, e.Message);
            
        }
    }
}