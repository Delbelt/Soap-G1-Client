using Microsoft.AspNetCore.Mvc;
using soap_client.Services.Implementations;
using soap_client.Services;

namespace soap_client.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CatalogController : ControllerBase
    {
        private readonly ICatalogService _catalogService;
        private readonly ILogger<CatalogService> _logger;

        public CatalogController(ICatalogService catalogService, ILogger<CatalogService> logger)
        {
            _catalogService = catalogService;
            _logger = logger;
        }

        [HttpPost("create")]
        public async Task<IActionResult> CreateCatalog([FromBody] string catalogName)
        {
            try
            {
                var response = await _catalogService.CreateCatalog(catalogName);
                return Ok(response);
            }
            catch (Exception ex)
            {
                _logger.LogError("[CatalogController][CreateCatalog]: {message}", ex.Message);
                return BadRequest($"Error al crear el catálogo: {ex.Message}");
            }
        }

        [HttpDelete("delete/{catalogId}")]
        public async Task<IActionResult> DeleteCatalog(long catalogId)
        {
            try
            {
                var response = await _catalogService.DeleteCatalog(catalogId);
                return Ok(response);
            }
            catch (Exception ex)
            {
                _logger.LogError("[CatalogController][DeleteCatalog]: {message}", ex.Message);
                return BadRequest($"Error al eliminar el catálogo: {ex.Message}");
            }
        }

        [HttpPost("addProduct")]
        public async Task<IActionResult> AddProductToCatalog([FromBody] long catalogId, string productCode)
        {
            try
            {
                var response = await _catalogService.AddProductToCatalog(catalogId, productCode);
                return Ok(response);
            }
            catch (Exception ex)
            {
                _logger.LogError("[CatalogController][AddProductToCatalog]: {message}", ex.Message);
                return BadRequest($"Error al agregar el producto al catálogo: {ex.Message}");
            }
        }

        [HttpGet("export/{catalogId}")]
        public async Task<IActionResult> ExportCatalogToPdf(long catalogId)
        {
            try
            {
                var response = await _catalogService.ExportCatalogToPdf(catalogId);
                return Ok(response);
            }
            catch (Exception ex)
            {
                _logger.LogError("[CatalogController][ExportCatalogToPdf]: {message}", ex.Message);
                return BadRequest($"Error al exportar el catálogo a PDF: {ex.Message}");
            }
        }

        

        
        [HttpGet("{catalogId}")]
        public async Task<IActionResult> GetCatalogById(long catalogId)
        {
            try
            {
                var response = await _catalogService.GetCatalogById(catalogId);
                return Ok(response);
            }
            catch (Exception ex)
            {
                _logger.LogError("[CatalogController][GetCatalogById]: {message}", ex.Message);
                return BadRequest($"Error al obtener el catálogo: {ex.Message}");
            }
        }
    }
}
