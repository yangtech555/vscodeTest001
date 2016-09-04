using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;

namespace TodoApi
{
    public class Starup
    {
        // public void Configure(IApplicationBuilder app){
        //   app.Run(context=>{
        //       var str1=System.DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
        //       return context.Response.WriteAsync("hehe!"+str1);
        //   });
        // } 

    public void ConfigureServices(IServiceCollection services){
     services.AddMvc();
    }

    public void Configure(IApplicationBuilder app,ILoggerFactory loggerFactory){
        loggerFactory.AddConsole();
        loggerFactory.AddDebug();
       app.UseMvc();
    }
    }
}