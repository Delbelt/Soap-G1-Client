namespace soap_client.Services
{
    public interface ICatalogService
    {
        Task<CreateCatalogResponse> CreateCatalog(string catalogName);
        Task<DeleteCatalogResponse> DeleteCatalog(long catalogId);
        Task<AddProductToCatalogResponse> AddProductToCatalog(long catalogId, string productCode);
        Task<ExportCatalogToPdfResponse> ExportCatalogToPdf(long catalogId);
        Task<GetCatalogByIdResponse> GetCatalogById(long catalogId);


    }
}
