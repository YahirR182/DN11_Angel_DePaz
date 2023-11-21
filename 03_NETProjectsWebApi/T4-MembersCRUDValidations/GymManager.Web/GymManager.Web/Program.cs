using System.Globalization;
using GymManager.ApplicationServices.Members;
using Microsoft.AspNetCore.Localization;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews().AddRazorRuntimeCompilation();
builder.Services.AddRazorPages();
//builder.Services.AddSingleton<IMembersAppService, MembersAppService>();
builder.Services.AddTransient<IMembersAppService, MembersAppService>();
//builder.Services.AddScoped<IMembersAppService, MembersAppService>();
var app = builder.Build();
var defaultDateCulture = "es-MX";
var ci = new CultureInfo(defaultDateCulture);

app.UseRequestLocalization(new RequestLocalizationOptions
{
    DefaultRequestCulture = new RequestCulture(ci),
    SupportedCultures=new List<CultureInfo>
    { 
        ci,
    }
}) ;


// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();
app.UseEndpoints(endpoints => {

    endpoints.MapControllerRoute("memberIn", "Attendance/MemberIn", new { controller = "Attendance", action = "MemberIn" });
    endpoints.MapControllerRoute("memberOut", "Attendance/MemberOut", new { controller = "Attendance", action = "MemberOut" });

    endpoints.MapControllerRoute("default", "{controller=Home}/{action=Index}/{id?}");
   
    endpoints.MapRazorPages();
});

app.MapRazorPages();

app.Run();

