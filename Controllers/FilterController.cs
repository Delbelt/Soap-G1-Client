using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using soap_client.Services;
using soap_client.Services.Implementations;
using System.Diagnostics.Metrics;
using System.ServiceModel;
using System.Threading.Tasks;

[ApiController]
[Route("api/[controller]")]
public class FilterController : ControllerBase
{
    private readonly FilterPortClient _filterClient;
    private readonly ILogger<IFilterService> _logger;

    public FilterController(FilterPortClient filterClient, ILogger<IFilterService> logger)
    {
        _filterClient = filterClient;
        _logger = logger;
    }

    [HttpPost]
    public async Task<IActionResult> SaveFilter([FromBody] FilterSoap filter)
    {
        try
        {
            var request = new SaveFilterRequest { filter = filter };
            var response = await _filterClient.SaveFilterAsync(request);
            _logger.LogInformation("[FilterController][SaveFilter]: {message}", response);
            return Ok(response.SaveFilterResponse.filter);
        }
       
        catch(Exception ex)
            {
            _logger.LogError("[FilterController][SaveFilter]: {message}", ex.Message);

            return BadRequest($"Error: {ex.Message}");
        }
    }

}
