var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

if (app.Environment.IsDevelopment()) //A Swagger éles környezetben nem indul
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();   //Ha http-vel nyitják az oldalt, átirányít https-re

app.UseDefaultFiles();       //Ha nincs semmi a domain tuán, akkor az index.html-t tölti
app.MapControllers();        //Az API Controllereket elérhetõvé teszi
app.UseStaticFiles();        //A wwwroot mappa tartalmát elérhetõvé teszi

app.Run();