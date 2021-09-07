using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Hosting;

namespace kubetest
{
  public class Program
  {
    public static void Main(string[] args)
    {
      CreateHostBuilder(args).Build().Run();
    }

    public static IHostBuilder CreateHostBuilder(string[] args)
    {

      return Host.CreateDefaultBuilder(args)
        .ConfigureWebHostDefaults(webBuilder =>
        {
          webBuilder.UseUrls("http://0.0.0.0:80;http://0.0.0.0:10000");
          webBuilder.UseStartup<Startup>();
        });
    }

  }
}
