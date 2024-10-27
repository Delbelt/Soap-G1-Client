namespace soap_client.Services.Implementations
{
    public class CatalogService : ICatalogService
    {
        private readonly CatalogsPortClient _client;
        public CatalogService(CatalogsPortClient client) {
            _client = client;
            
        }

        public async Task<CreateCatalogResponse> CreateCatalog(string catalogName)
        {
            var request = new CreateCatalogRequest { name = catalogName };
            var response = await _client.CreateCatalogAsync(request);
            return response.CreateCatalogResponse;
        }

        public async Task<DeleteCatalogResponse> DeleteCatalog(long catalogId)
        {
            var request = new DeleteCatalogRequest { catalogId = catalogId };
            var response = await _client.DeleteCatalogAsync(request);
            return response.DeleteCatalogResponse;
        }

        public async Task<AddProductToCatalogResponse> AddProductToCatalog(long catalogId, string productCode)
        {
            var request = new AddProductToCatalogRequest { catalogId = catalogId, productCode = productCode };
            var response = await _client.AddProductToCatalogAsync(request);
            return response.AddProductToCatalogResponse;
        }

        public async Task<ExportCatalogToPdfResponse> ExportCatalogToPdf(long catalogId)
        {
            var request = new ExportCatalogToPdfRequest { catalogId = catalogId };
            var response = await _client.ExportCatalogToPdfAsync(request);
            return response.ExportCatalogToPdfResponse;
        }

        

        public async Task<GetCatalogByIdResponse> GetCatalogById(long catalogId)
        {
            var request = new GetCatalogByIdRequest { catalogId = catalogId };
            var response = await _client.GetCatalogByIdAsync(request);
            return response.GetCatalogByIdResponse; 
        }
    }
}
