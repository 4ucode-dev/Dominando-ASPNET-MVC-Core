// Tudo inicia a partir do builder
var builder = WebApplication.CreateBuilder(args);

// Adicionando o MVC ao container
builder.Services.AddControllersWithViews();

// Realizando o buid das configura��es que resultar� na App
var app = builder.Build();

// Ativando a pagina de erros caso seja ambiente de desenvolvimento
if (app.Environment.IsDevelopment())
{
    app.UseDeveloperExceptionPage();
}

// Adicionando Rota padr�o
app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

// Colocando a App para rodar
app.Run();