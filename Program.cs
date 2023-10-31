using SignalR.Hubs;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorPages();
// Add SignalR to the container.
builder.Services.AddSignalR();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
}
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

// Add SignalR to the pipeline. we create a new endpoint for the SignalR hub.a server-side hub method is invoked by a client-side method of the same name.
app.MapHub<ChatHub>("/chatHub");

app.MapHub<DrawDotHub>("/drawDotHub");

app.MapRazorPages();

app.Run();
