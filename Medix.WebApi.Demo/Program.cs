using Medix.Common.Demo;
using Medix.Common.Demo.Data;
using Medix.WebApi.Demo.Controllers;
using Microsoft.EntityFrameworkCore;
using Microsoft.OpenApi.Models;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen(c =>
{
    c.SwaggerDoc("v1", new OpenApiInfo { Title = "Medix", Version = "v1" });
    c.UseAllOfForInheritance();
    c.SchemaFilter<EnumSchemaFilter>();

});
var services = builder.Services;
services.AddDbContext<MedixDbContext>(op => op.UseInMemoryDatabase("MedixDatabase"));
services.AddAutoMapper(typeof(MedixHPController));

var app = builder.Build();
using (var scope = app.Services.CreateScope())
{
    var dbContext = scope.ServiceProvider.GetRequiredService<MedixDbContext>();
    SeedData.AddPhysicians(dbContext);

}
 

// Configure the HTTP request pipeline.

app.UseSwagger();
app.UseSwaggerUI();

app.UseHttpsRedirection();

//app.UseAuthorization();

app.MapControllers();

app.Run();
