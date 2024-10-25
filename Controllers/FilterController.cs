using Microsoft.AspNetCore.Mvc;
using soap_client.Services.Implementations;
using soap_client.Services;
using System.ServiceModel.Channels;

namespace soap_client.Controllers
{
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

        [HttpGet("{userId}")]
        public async Task<IActionResult> GetFilters(int userId)
        {
            try
            {
                var filters = await _filterService.GetFiltersByUserId(userId);

                _logger.LogInformation("[FilterController][GetFilters]: { message}", filters);

                return Ok(filters);
            }
            catch (Exception ex)
            {
                _logger.LogError("[FilterController][GetFilters]: {message}", ex.Message);

                return BadRequest(ex.Message);
            }

        }
    }
}

