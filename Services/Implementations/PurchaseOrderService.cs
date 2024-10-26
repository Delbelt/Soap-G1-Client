using System.Globalization;

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
            string? productCode, 
            string? startRequestDate, 
            string? endRequestDate, 
            string? status, 
            string? storeCode)
        {
           
            var request = new SearchPurchaseOrdersRequest
            {
                productCode = productCode,
                startRequestDate = startRequestDate,
                endRequestDate = endRequestDate,
                status = status,
                storeCode = storeCode
            };
            // Esto permite inspeccionar la solicitud en caso de que tengas la capacidad de hacerlo
            Console.WriteLine("Sending Request:");
            Console.WriteLine($"Product Code: {request.productCode}");
            Console.WriteLine($"Start Request Date: {request.startRequestDate}");
            Console.WriteLine($"End Request Date: {request.endRequestDate}");
            Console.WriteLine($"Status: {request.status}");
            Console.WriteLine($"Store Code: {request.storeCode}");
            var response = await _client.SearchPurchaseOrdersAsync(request);

            return response.SearchPurchaseOrdersResponse1?.ToList() ?? new List<PurchaseOrderSoap>();
  
        }

    }
}