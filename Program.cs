// O builder é responsável por fornecer os métodos de controle
// dos serviços e demais funcionalidades na configuração da App
var builder = WebApplication.CreateBuilder(args);

// Daqui para baixo é conteúdo que vinha dentro do método  ConfigureServices() na antiga Startup.cs
// Nesta area adicionamos serviços ao pipeline

// Essa é a nova forma de adicionar o MVC ao projeto
// Não se usa mais services.AddMvc();
// Add services to the container.
builder.Services.AddControllersWithViews();

// Essa linha precisa sempre ficar por último na configuração dos serviços
var app = builder.Build();

// Daqui para baixo é conteúdo que vinha dentro do método Configure() na antiga Startup.cs
// Aqui se configura comportamentos do request dentro do pipeline
// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

// Note a ligeira mudança na declaração da rota padrão
// No caso de precisar mapear mais de uma rota duplique o código abaixo
app.MapControllerRoute(
    name: "modulos",
    pattern: "Gestão/{controller=Home}/{action=Index}/{id?}");

app.MapControllerRoute(
    name: "categoria",
    pattern: "{controller=Home}/{action=Index}/{id}/{categoria?}");

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

// Essa linha precisa sempre ficar por último na configuração do request pipeline
app.Run();
