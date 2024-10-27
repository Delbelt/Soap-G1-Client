namespace soap_client.Services
{
    public interface IUserService
    {
        public Task<CargarUsuariosResponse1> CargarUsuariosAsync(byte[] fileContent);
    }
}
