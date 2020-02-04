using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.DependencyInjection;

namespace API1
{
    public class Program
    {
        public static void Main(string[] args)
        {

            WebHost
            .CreateDefaultBuilder()
            .ConfigureServices(services => {
                services
    .AddMvc();
                services.AddScoped(typeof(Idata),(n)=> new data("AddScoped"));
            }).Configure((IApplicationBuilder app) =>
            {
                app.UseDeveloperExceptionPage();
                app.UseMvc();
                //(routes =>
                //{
                //    //routes.MapRoute(
                //    //    name: "api",
                //    //    template: "api/{controller=values}/{action=Get}"); //< --Note the change here

                //    //routes.MapRoute("DefaultApi", "api/{controller=values}/{action=Get}");
                //    //routes.MapRoute("Default", "{controller=home}/{action=Index}");
                //});

                //app.UseMvc(routes =>{

                ////routes.MapRoute("DefaultApi", "api/{controller=values}");
                ////    routes.MapRoute("Default", "api/{controller=values}");

                //});
            })
            .Build()
            .Run();
        }

        //public static IWebHostBuilder CreateWebHostBuilder(string[] args) =>
        //    WebHost.CreateDefaultBuilder(args)
        //        .UseStartup<Startup>();
    }
}
