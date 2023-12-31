var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

if (app.Environment.IsDevelopment()) //A Swagger �les k�rnyezetben nem indul
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();   //Ha http-vel nyitj�k az oldalt, �tir�ny�t https-re

app.UseDefaultFiles();       //Ha nincs semmi a domain tu�n, akkor az index.html-t t�lti
app.MapControllers();        //Az API Controllereket el�rhet�v� teszi
app.UseStaticFiles();        //A wwwroot mappa tartalm�t el�rhet�v� teszi

app.Run();