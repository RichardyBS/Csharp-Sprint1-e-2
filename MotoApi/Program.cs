using MotoApi.Data;
using MotoApi.Models;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddDbContext<AppDbContext>(options =>
    options.UseSqlite("Data Source=motoapi.db"));

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.MapGet("/clientes", async (AppDbContext db) =>
    await db.Clientes.ToListAsync()
);

app.MapPost("/clientes", async (Cliente cliente, AppDbContext db) =>
{
    db.Clientes.Add(cliente);
    await db.SaveChangesAsync();
    return Results.Created($"/clientes/{cliente.Id}", cliente);
});

app.Run();
