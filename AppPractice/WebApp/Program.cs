// var builder = WebApplication.CreateBuilder(args);

// // Add services to the container.
// builder.Services.AddControllersWithViews();

// var app = builder.Build();

// // Configure the HTTP request pipeline.
// if (!app.Environment.IsDevelopment())
// {
//     app.UseExceptionHandler("/Home/Error");
//     // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
//     app.UseHsts();
// }

// app.UseHttpsRedirection();
// app.UseStaticFiles();

// app.UseRouting();

// app.UseAuthorization();

// app.MapControllerRoute(
//     name: "default",
//     pattern: "{controller=Home}/{action=Index}/{id?}");

// app.Run();


using System;
using System.Collections;
using System.Net.Http;
using System.Threading.Tasks;
using System.Net.Http.Headers;
using System.IO;
using System.Linq;
using System.Linq.Expressions;
using Newtonsoft.Json.Linq;

namespace WebApp
{
    class MainClass
    {
        private static readonly HttpClient client = new HttpClient();

        public static async Task Main(string[] args)
        {
            // Fetch books
            var json = await GetBooks();

            Console.WriteLine(json);

            Console.WriteLine("Press any key to exit");
            Console.ReadKey();
        }

        private static async Task<string> GetBooks()
        {
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            client.DefaultRequestHeaders.Add("User-Agent", ".NET Foundation Repository Reporter");

            var stringTask = client.GetStringAsync("http://localhost:5222/api/books");

            var msg = await stringTask;
            return msg;
        }

    }
}
