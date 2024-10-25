namespace soap_client.Services.Implementations
{
    public class PurchaseOrderService : IPurchaseOrderService
    {
        private readonly PurchaseOrderPortClient _client;

        public PurchaseOrderService(PurchaseOrderPortClient client)
        {
            _client = client;
        }

        public async Task<List<PurchaseOrderSoap>> SearchPurchaseOrdersAsync(
            string? productCode = null, 
            DateTime? startRequestDate = null, 
            DateTime? endRequestDate = null, 
            string? status = null, 
            string? storeCode = null)
        {

            var request = new SearchPurchaseOrdersRequest
            {
                productCode = string.IsNullOrEmpty(productCode) ? null : productCode,
                startRequestDate = startRequestDate,
                endRequestDate = endRequestDate,
                status = string.IsNullOrEmpty(status) ? null : status,
                storeCode = string.IsNullOrEmpty(storeCode) ? null : storeCode
            };

            var response = await _client.SearchPurchaseOrdersAsync(request);

            return response.SearchPurchaseOrdersResponse1?.ToList() ?? new List<PurchaseOrderSoap>();
  
        }
    }
    }






