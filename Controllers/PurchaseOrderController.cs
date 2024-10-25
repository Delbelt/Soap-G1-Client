using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using soap_client.Services.Implementations;
using soap_client.Services;

namespace soap_client.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class PurchaseOrderController : ControllerBase
    {
        private readonly IPurchaseOrderService _purchaseOrderService;
        private readonly ILogger<PurchaseOrderController> _logger;

        public PurchaseOrderController(IPurchaseOrderService purchaseOrderService, ILogger<PurchaseOrderController> logger)
        {
            _purchaseOrderService = purchaseOrderService;
            _logger = logger;
        }

        [HttpGet("search")]
        public async Task<IActionResult> SearchPurchaseOrders(
            string? productCode = null,
            DateTime? startRequestDate = null,
            DateTime? endRequestDate = null,
            string? status = null,
            string? storeCode = null)
        {
            try
            {
                var orders = await _purchaseOrderService.SearchPurchaseOrdersAsync(productCode, startRequestDate, endRequestDate, status, storeCode);

                if (orders.Count == 0)
                {
                    _logger.LogInformation("No purchase orders found");
                    return NotFound("No purchase orders found");
                }

                return Ok(orders);
            }
            
            catch (Exception ex)
            {
                _logger.LogError("[PurchaseOrderController][SearchPurchaseOrders]: {message}", ex.Message);
                return BadRequest(ex.Message);
            }
        }
    }
}

