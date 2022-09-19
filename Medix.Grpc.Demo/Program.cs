using Medix.Common.Demo;
using Medix.Common.Demo.Data;
using Medix.Dtos.Medix_H.Response;
using Medix.Grpc.Demo.Services;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using Microsoft.OpenApi.Any;
using Microsoft.OpenApi.Models;
using Swashbuckle.AspNetCore.SwaggerGen;
using System;

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
                c.SchemaFilter<EnumSchemaFilter>();

            });

services.AddServiceModelGrpc();
services.AddServiceModelGrpcSwagger();
services.AddScoped<IIssueCodeResponse, IssueCodeResponse>();
services.AddSwaggerGenNewtonsoftSupport();
services.AddDbContext<MedixDbContext>(op => op.UseInMemoryDatabase("MedixDatabase"));
services.AddAutoMapper(typeof(MedixDbContext));

var app = builder.Build();
using (var scope = app.Services.CreateScope())
{
    var dbContext = scope.ServiceProvider.GetRequiredService<MedixDbContext>();
    SeedData.AddPhysicians(dbContext);
  
}

app.UseSwagger();
app.UseSwaggerUI(c =>
{
    c.SwaggerEndpoint("/swagger/v1/swagger.json", "Medix");
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


