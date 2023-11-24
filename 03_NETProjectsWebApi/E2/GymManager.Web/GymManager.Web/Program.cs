using System.Globalization;
using GymManager.ApplicationServices.Members;
using GymManager.ApplicationServices.MembershipTypes;
using GymManager.ApplicationServices.Navigation;
using GymManager.DataAccess;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Localization;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews().AddRazorRuntimeCompilation();
builder.Services.AddRazorPages();
//builder.Services.AddSingleton<IMembersAppService, MembersAppService>();
builder.Services.AddTransient<IMembersAppService, MembersAppService>();
builder.Services.AddTransient<IMembershipTypesAppService, MembershipTypesAppService>();
builder.Services.AddTransient<IMenuAppService, MenuAppService>();
//builder.Services.AddScoped<IMembersAppService, MembersAppService>();

//string connectionString = builder.Configuration.GetConnectionString("Default");

//builder.Services.AddDbContext<GymManagerContext>(options => options.UseMySql(connectionString,ServerVersion.AutoDetect(connectionString)));
//builder.Services.AddDefaultIdentity<IdentityUser>(options=>options.SignIn.RequireConfirmedAccount=true).AddEntityFrameworkStores<GymManagerContext>();
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

app.UseAuthentication();
app.UseAuthorization();
app.UseEndpoints(endpoints => {

    endpoints.MapControllerRoute("memberIn", "Attendance/MemberIn", new { controller = "Attendance", action = "MemberIn" });
    endpoints.MapControllerRoute("memberOut", "Attendance/MemberOut", new { controller = "Attendance", action = "MemberOut" });

    endpoints.MapControllerRoute("default", "{controller=Home}/{action=Index}/{id?}");
    
    endpoints.MapRazorPages();
});


app.MapRazorPages();

app.Run();

