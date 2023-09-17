using FluentValidation.AspNetCore;
using KitapsterAPI.Application.Validators.Books;
using KitapsterAPI.Infrastructure.Filters;
using KitapsterAPI.Persistence;
var builder = WebApplication.CreateBuilder(args);

builder.Services.AddPersistenceServices();

builder.Services.AddCors(optios => optios.AddDefaultPolicy(policy =>
policy.WithOrigins("http://localhost:50236", "https://localhost:50236").AllowAnyHeader().AllowAnyMethod()
));

builder.Services.AddControllers(options =>
{
    options.Filters.Add<ValidationFilter>();
    
})
    .AddFluentValidation(configuration => configuration.RegisterValidatorsFromAssemblyContaining<CreateProductValidator>())
    .ConfigureApiBehaviorOptions(options => options.SuppressModelStateInvalidFilter = true);




// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}
app.UseCors();

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
