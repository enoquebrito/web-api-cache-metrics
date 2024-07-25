using CacheWebAPI.Domain.WebServices;
using Microsoft.AspNetCore.Mvc;

namespace CacheWebAPI.Controllers;

[ApiController]
[Route("v1/[controller]")]
public class AddressController(IAddressWebService addressApi, ILogger<AddressController> logger) : ControllerBase
{
    [HttpGet]
    public async Task<IActionResult> GetCustomerZipCode([FromQuery] string zipCode)
    {
        logger.LogInformation("Iniciando captura de dados para o CEP {Cep}", zipCode);
        
        if (string.IsNullOrWhiteSpace(zipCode))
        {
            return BadRequest("ZipCode cannot be null");
        }

        var response = await addressApi.GetAddressAsync(zipCode);
        
        return Ok(response);
    }
}