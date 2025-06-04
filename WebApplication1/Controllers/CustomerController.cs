using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebApplication1.DTO;
using WebApplication1.Exeptions;
using WebApplication1.Service;

namespace WebApplication1.Controllers;

[ApiController]
[Route("api/[controller]")]
public class CustomersController : ControllerBase
{
    private readonly IDbService _dbService;

    public CustomersController(IDbService dbService)
    {
        _dbService = dbService;
    }

    [HttpGet("{customerId}/purchases")]
    public async Task<IActionResult> GetOrdersByCustomerId(int customerId)
    {
        try
        {
            var order = await _dbService.GetOrdersByCustomerId(customerId);
            return Ok(order);
        }
        catch (NotFoundException e)
        {
            return NotFound();
        }
    }
    
}