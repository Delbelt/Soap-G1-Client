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

        [HttpPost]
        public async Task<IActionResult> SaveFilter([FromBody] SaveFilterType filter)
        {
            try
            {
                var savedFilter = await _filterService.SaveFilter(filter);
                _logger.LogInformation("[FilterController][SaveFilter]: { message}", savedFilter);
                return Ok(savedFilter);
            }
            catch (Exception ex)
            {
                _logger.LogError("[FilterController][SaveFilter]: {message}", ex.Message);
                return BadRequest(ex.Message);
            }
        }


        [HttpPut]
        public async Task<IActionResult> EditFilter([FromBody] EditFilterType filter)
        {
            try
            {
                var updatedFilter = await _filterService.EditFilter(filter);
                _logger.LogInformation("[FilterController][EditFilter]: { message}", updatedFilter);
                return Ok(updatedFilter);
            }
            catch (Exception ex)
            {
                _logger.LogError("[FilterController][EditFilter]: {message}", ex.Message);
                return BadRequest(ex.Message);
            }
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteFilter(int id)
        {
            try
            {
                var success = await _filterService.DeleteFilter(id);
                _logger.LogInformation("[FilterController][DeleteFilter]: { message}", success);
                return Ok(success);
            }
            catch (Exception ex)
            {
                _logger.LogError("[FilterController][DeleteFilter]: {message}", ex.Message);
                return BadRequest(ex.Message);
            }
        }
    }
}

