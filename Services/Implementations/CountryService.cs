namespace soap_client.Services.Implementations
{
    public class CountryService : ICountryService
    {
        private readonly CountryPortClient _client;

        public CountryService(CountryPortClient client)
        {
            _client = client;
        }
        public async Task<Country> GetCountry(string countryName)
        {
            var request = new GetCountryRequest { name = countryName };

            var response = await _client.GetCountryAsync(request);

            return response.GetCountryResponse.country;
        }
    }
}
