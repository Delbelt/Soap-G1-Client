using soap_client.Services;
using soap_client.Services.Implementations;
using System.ServiceModel;

var builder = WebApplication.CreateBuilder(args);

var URL_FRONT = "http://localhost:3000";

builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddScoped<CountryPortClient>(provider =>
{
    var endpointAddress = new System.ServiceModel.EndpointAddress("http://localhost:8080/ws/countries");
    var binding = new System.ServiceModel.BasicHttpBinding();

    return new CountryPortClient(binding, endpointAddress);
});

builder.Services.AddScoped<ICountryService, CountryService>();


builder.Services.AddScoped<CatalogsPortClient>(provider =>
{
    var endpointAddress = new System.ServiceModel.EndpointAddress("http://localhost:8080/ws/catalogs");
    var binding = new System.ServiceModel.BasicHttpBinding();

    return new CatalogsPortClient(binding, endpointAddress);
});

builder.Services.AddScoped<ICatalogService, CatalogService>();

// Configuración del cliente para el servicio de órdenes de compra
builder.Services.AddScoped<PurchaseOrderPortClient>(provider =>
{
    var endpointAddress = new System.ServiceModel.EndpointAddress("http://localhost:8080/ws/purchase_orders");
    var binding = new System.ServiceModel.BasicHttpBinding();

    return new PurchaseOrderPortClient(binding, endpointAddress);
});

builder.Services.AddScoped<IPurchaseOrderService, PurchaseOrderService>();

// Configuracion del cliente para el servicio de filtros
builder.Services.AddScoped<FilterPortClient>(provider =>
{
    var endpointAddress = new System.ServiceModel.EndpointAddress("http://localhost:8080/ws/filters");
    var binding = new System.ServiceModel.BasicHttpBinding();

    return new FilterPortClient(binding, endpointAddress);
});

builder.Services.AddScoped<IFilterService, FilterService>();

builder.Services.AddScoped<UsersPortClient>(provider =>
{

    var endpoint = new System.ServiceModel.EndpointAddress("http://localhost:8080/ws/users"); 
    var binding = new BasicHttpBinding();
    return new UsersPortClient(binding, endpoint);
});

builder.Services.AddScoped<IUserService, UserService>();


// configura los CORS para que funcione en el front
builder.Services.AddCors(options =>
{
    options.AddPolicy("CQRS",
        builder => builder
            .WithOrigins(URL_FRONT)
            .AllowAnyHeader()
            .AllowAnyMethod());
});

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
