var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();
builder.Services.AddRazorPages();

var app = builder.Build();

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

