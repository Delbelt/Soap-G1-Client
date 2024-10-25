namespace soap_client.Services.Implementations
{
    public class FilterService : IFilterService
    {
        private readonly FilterPortClient _client; // Cambia a tu clase generada

        public FilterService(FilterPortClient client)
        {
            _client = client;
        }

        public async Task<List<FilterSoap>> GetFiltersByUserId(int userId)
        {
            var request = new getFiltersRequest { userId = userId }; // Asegúrate de que este objeto sea correcto
            var response = await _client.getFiltersAsync(request);
            return response.getFiltersResponse1.ToList();
        }
    }
}
