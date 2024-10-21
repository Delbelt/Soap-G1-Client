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
    private readonly IFilterService _filterService;
    private readonly ILogger<FilterController> _logger;

    public FilterController(IFilterService filterService, ILogger<FilterController> logger)
    {
        _filterService = filterService;
        _logger = logger;
    }

    [HttpPost]
    public async Task<IActionResult> SaveFilter([FromBody] FilterSoap filter)
    {
        try
        {
            var savedFilter = await _filterService.SaveFilter(filter);

            _logger.LogInformation("[FilterController][SaveFilter]: {message}", savedFilter);

            return Ok(savedFilter);
        }
        catch (Exception ex)
        {
            _logger.LogError("[FilterController][SaveFilter]: {message}", ex.Message);

            return BadRequest($"Error saving the filter: {ex.Message}");
        }
    }

    [HttpGet("{userId}")]
    public async Task<IActionResult> GetFiltersByUser(int userId)
    {
        try
        {
            var filters = await _filterService.GetFiltersByUser(userId);

            _logger.LogInformation("[FilterController][GetFiltersByUser]: {message}", filters);

            return Ok(filters);
        }
        catch (Exception ex)
        {
            _logger.LogError("[FilterController][GetFiltersByUser]: {message}", ex.Message);

            return BadRequest($"Error fetching filters for user {userId}: {ex.Message}");
        }
    }

}
