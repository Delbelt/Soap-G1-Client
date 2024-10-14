namespace soap_client.Services
{
    public interface ICountryService
    {
        // Para generar el archivo: dotnet-svcutil http://localhost:8080/ws/countries.wsdl
        Task<Country> GetCountry(string countryName);
    }
}
