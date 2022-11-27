using _418ErrorAPI.Models;
using Microsoft.OpenApi.Models;
using Swashbuckle.AspNetCore.SwaggerGen;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen(options =>
{
    //options.DocumentFilter<AddSchemaFilter<Business>>();
    //options.DocumentFilter<AddSchemaFilter<Customer>>();
    //options.DocumentFilter<AddSchemaFilter<Discount>>();
    //options.DocumentFilter<AddSchemaFilter<Employee>>();
    //options.DocumentFilter<AddSchemaFilter<Loyalty>>();
    //options.DocumentFilter<AddSchemaFilter<Order>>();
    //options.DocumentFilter<AddSchemaFilter<OrderItem>>();
    //options.DocumentFilter<AddSchemaFilter<Product>>();
    //options.DocumentFilter<AddSchemaFilter<PromoCode>>();
    //options.DocumentFilter<AddSchemaFilter<Refund>>();
    //options.DocumentFilter<AddSchemaFilter<Report>>();
    //options.DocumentFilter<AddSchemaFilter<Role>>();
    //options.DocumentFilter<AddSchemaFilter<Storage>>();
    //options.DocumentFilter<AddSchemaFilter<StorageItem>>();
    //options.DocumentFilter<AddSchemaFilter<Tax>>();
    //options.DocumentFilter<AddSchemaFilter<TaxProduct>>();
    //options.DocumentFilter<AddSchemaFilter<TimeTable>>();
    //options.DocumentFilter<AddSchemaFilter<UserLoyalty>>();

});

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI(x => { x.SwaggerEndpoint("/swagger/v1/swagger.yaml", "418 API"); });
    //app.UseSwaggerUI();

}


app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();


//Generic class which allows to use reflection and add schemas to the swagger ui without using them.
public class AddSchemaFilter<T>: IDocumentFilter
    where T : class, new()
{
    public void Apply(OpenApiDocument swaggerDoc, DocumentFilterContext context)
    {
        var schema = new OpenApiSchema() { };
        var temp = new T();
        var properties = typeof(T).GetProperties();

        foreach (var p in properties)
            schema.Properties.Add(new KeyValuePair<string, OpenApiSchema>(
                p.Name,
                new OpenApiSchema()
                {
                    Type = p.PropertyType.ToString(),
                    //Description TODO: maybe add a better descrption.
                }));

        if (!context.SchemaRepository.Schemas.ContainsKey(typeof(T).Name))
        {
            context.SchemaRepository.Schemas.Add(typeof(T).Name, schema);
        }
    }

}