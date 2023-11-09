var builder = WebApplication.CreateBuilder(args);

// Agregar servicios a la colección de servicios.
builder.Services.AddControllersWithViews(); 

var app = builder.Build();

// Configure el pipeline de solicitudes HTTP.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();
app.UseAuthorization();

app.MapControllers();
app.MapGet("/", () => "Hello World!");

app.Run();
