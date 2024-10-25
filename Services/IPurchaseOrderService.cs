namespace soap_client.Services
{
    public interface IPurchaseOrderService
    {
        Task<List<PurchaseOrderSoap>> SearchPurchaseOrdersAsync(string? productCode = null, DateTime? startRequestDate = null, DateTime? endRequestDate = null, string? status = null, string? storeCode = null);
    }
}
