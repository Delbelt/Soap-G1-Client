namespace soap_client.Services.Implementations
{
    public class FilterService : IFilterService
    {
        private readonly FilterPortClient _filterClient;

        public FilterService(FilterPortClient filterClient)
        {
            _filterClient = filterClient;
        }

        public async Task<FilterSoap> SaveFilter(FilterSoap filter)
        {
            var request = new SaveFilterRequest { filter = filter };
            var response = await _filterClient.SaveFilterAsync(request);
            return response.SaveFilterResponse.filter;
        }

        public async Task<List<FilterSoap>> GetFiltersByUser(int userId)
        {
            var request = new GetFiltersByUserRequest { user = userId };
            var response = await _filterClient.GetFiltersByUserAsync(request);
            return response.GetFiltersByUserResponse1.ToList();
        }
    }
}
