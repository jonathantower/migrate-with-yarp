
var builder = WebApplication.CreateBuilder(args);
builder.Services.AddWebOptimizer(pipeline =>
{
    pipeline.AddJavaScriptBundle("/bundles/jquery", "Scripts/jquery-3.3.1.js").UseContentRoot();
    pipeline.AddJavaScriptBundle("/bundles/jqueryval", "Scripts/jquery.validate.js").UseContentRoot();
    pipeline.AddJavaScriptBundle("/bundles/modernizr", "Scripts/modernizr-*").UseContentRoot();
    pipeline.AddJavaScriptBundle("/bundles/bootstrap",
        "Scripts/bootstrap.js",
        "Scripts/respond.js").UseContentRoot();

    pipeline.AddJavaScriptBundle("/bundles/css",
        "Content/bootstrap.css",
        "Content/custom.css",
        "Content/base.css",
        "Content/site.css").UseContentRoot();
});
builder.Services.AddSystemWebAdapters();
builder.Services.AddHttpForwarder();

// Add services to the container.
builder.Services.AddControllersWithViews();

var app = builder.Build();

if (!app.Environment.IsDevelopment())
{
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseWebOptimizer();
app.UseStaticFiles();

app.UseRouting();
app.UseAuthorization();
app.UseSystemWebAdapters();

app.MapDefaultControllerRoute();
app.MapForwarder("/{**catch-all}", app.Configuration["ProxyTo"]).Add(static builder => ((RouteEndpointBuilder)builder).Order = int.MaxValue);

app.MapControllerRoute("Default", "{controller=Catalog}/{action=Index}/{id?}");

app.Run();
