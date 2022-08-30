using MARCO.Medix.UI.Services;
using Microsoft.OpenApi.Models;

var builder = WebApplication.CreateBuilder(args);

// Additional configuration is required to successfully run gRPC on macOS.
// For instructions on how to configure Kestrel and gRPC clients on macOS, visit https://go.microsoft.com/fwlink/?linkid=2099682

// Add services to the container.
builder.Services.AddGrpc();
var services = builder.Services;
services.AddGrpc(options => options.EnableDetailedErrors = true);
services.AddGrpcHttpApi();
services.AddMvc();
services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo { Title = "Medix", Version = "v1" });
                c.EnableAnnotations(true, true);
                c.UseAllOfForInheritance();

            });

services.AddServiceModelGrpc();
services.AddServiceModelGrpcSwagger();


var app = builder.Build();


app.UseSwagger();
app.UseSwaggerUI(c =>
{
    c.SwaggerEndpoint("/swagger/v1/swagger.json", "Mledger Kelishe");
});

app.UseRouting();
app.UseServiceModelGrpcSwaggerGateway();


// Configure the HTTP request pipeline.
app.MapGrpcService<MedixHP>();
app.MapGet("/", () => "Communication with gRPC endpoints must be made through a gRPC client. To learn how to create a client, visit: https://go.microsoft.com/fwlink/?linkid=2086909");

app.UseCors(x => x
  .AllowAnyOrigin()
  .AllowAnyMethod()
  .AllowAnyHeader());
app.UseStaticFiles();

app.Run();
