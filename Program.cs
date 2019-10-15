using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;

namespace GasMilageTracker
{
    public class Program
    {
        //public static void Main(string[] args)
        //{
        //    BuildWebHost(args).Run();
        //}
        //public static IWebHost BuildWebHost(string[] args) =>
        //WebHost.CreateDefaultBuilder(args)
        //.UseStartup<Startup>()
        //.UseDefaultServiceProvider(options =>
        //options.ValidateScopes = false)
        //.Build();

        public static void Main(string[] args)
        {
            CreateWebHostBuilder(args).Build().Run();
        }

        public static IWebHostBuilder CreateWebHostBuilder(string[] args) =>
            WebHost.CreateDefaultBuilder(args)
                .UseStartup<Startup>();
    }
}
