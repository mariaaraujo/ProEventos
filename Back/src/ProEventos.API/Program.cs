using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
//Primeiro arquivo que é executado
namespace ProEventos.API
{
    public class Program
    {
        //Primeiro a ser lido, chama o método CreateHostBuilder
        //
        public static void Main(string[] args)
        {
            CreateHostBuilder(args).Build().Run();
        }
        //CreateDefaultBuilder = fala sobre todas as configurações do projeto
        //Se estiver rodando a aplicação em ambiente de desenvolvimento ele pega: appsettings.Development.json, se for em ambiente de produção: appsettings.json
        //Método diz que ele vai pegar na classe que ele for carregar o IConfiguration, levando isso em consideração
        //ILoggerFactory: também será injetado na classe Startup
        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder.UseStartup<Startup>();
                });
    }
}
