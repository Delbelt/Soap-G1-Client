using Microsoft.AspNetCore.Mvc;
using soap_client.Services;
using soap_client.Services.Implementations;

namespace soap_client.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CountryController : ControllerBase
    {
        private readonly ICountryService _countryService;
        private readonly ILogger<ICountryService> _logger;
        public CountryController(ICountryService countryService, ILogger<CountryService> logger)
        {
            _countryService = countryService;
            _logger = logger;
        }

        [HttpGet("{countryName}")]
        public async Task<IActionResult> GetCountry(string countryName)
        {
            try
            {
                var country = await _countryService.GetCountry(countryName);

                _logger.LogInformation("[CountryController][GetCountry]: {message}", country);

                return Ok(country);
            }

            catch (Exception ex)
            {
                _logger.LogError("[CountryController][GetCountry]: {message}", ex.Message);

                return BadRequest($"Error al obtener el país: {ex.Message}");
            }
        }
    }
}
