using CacheWebAPI.Domain.WebServices;
using Microsoft.AspNetCore.Mvc;

namespace CacheWebAPI.Controllers;

[ApiController]
[Route("v1/[controller]")]
public class CustomerController(IAddressWebService addressApi) : ControllerBase
{
    [HttpGet("/zipcode/{id}")]
    public async Task<IActionResult> GetCustomerZipCode(string id)
    {
        if (string.IsNullOrWhiteSpace(id))
        {
            return BadRequest("ZipCode cannot be null");
        }

        var response = await addressApi.GetAddressAsync(id);
        
        return Ok(response);
    }

    [HttpPost]
    public async Task<IActionResult> CreateCustomerAsync()
    {
        var uri = HttpContext.Request.PathBase;
        
        return await Task.FromResult(Created("teste", new { Id = "123"}));
    }
}