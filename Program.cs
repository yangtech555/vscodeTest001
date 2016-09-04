using System.IO;
using Microsoft.AspNetCore.Hosting;

namespace TodoApi
{
    public class Program
    {
        public static void Main(string[] args)
        {
           var host=new WebHostBuilder()
           .UseKestrel()
           .UseStartup<Starup>()
            .UseContentRoot(Directory.GetCurrentDirectory())
            .UseUrls("http://localhost:1111/", "http://localhost:2222/")
           .Build();

           host.Run();
        }
    }
}
