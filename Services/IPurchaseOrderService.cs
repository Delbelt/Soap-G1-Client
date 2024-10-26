namespace soap_client.Services
{
    public interface IPurchaseOrderService
    {
        Task<List<PurchaseOrderSoap>> SearchPurchaseOrdersAsync(string? productCode, string? startRequestDate, string? endRequestDate, string? status, string? storeCode);
    }
}
