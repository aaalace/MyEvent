using MyEvent.Application;
using MyEvent.Infrastructure;

var builder = WebApplication.CreateBuilder(args);
{
    builder.Services.AddSwaggerGen();
    
    builder.Services.AddControllers();
    builder.Services.AddApplication();
    builder.Services.AddInfrastructure();
}

var app = builder.Build();
{
    if (app.Environment.IsDevelopment())
    {
        app.UseSwagger();
        app.UseSwaggerUI();
    }
    
    app.UseHttpsRedirection();
    app.MapControllers();
    
    app.Run();
}