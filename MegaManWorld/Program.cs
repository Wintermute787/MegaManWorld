using System.IO;
using Microsoft.AspNetCore.Hosting;

namespace MegaManWorld
{
  public class Program
  {
    public static void Main(string[] args)
    {
      var host = new WebHostBuilder()
        .UseKestrel()
        .UseContentRoot(Directory.GetCurrentDirectory())
        .UseIISIntegration()
        .UseStartup<Startup>()
        .Build();
        ServerUpdate update = new ServerUpdate();
      host.Run();
    }
  }
}
