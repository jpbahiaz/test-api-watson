using Autofac;
using Microsoft.Extensions.Configuration;
using System;
using TestApiWatson.AppService;
using TestApiWatson.AppService.Interfaces;
using TestApiWatson.Domain;
using TestApiWatson.Domain.Interfaces;
using TesteApiWatson.Infra.Data.ServiceAgent;
using TesteApiWatson.Infra.Data.ServiceAgent.Interfaces;

namespace TestApiWatson.Infra.CrossCutting.IoC
{
    public class IoCConfig
    {
        public static ContainerBuilder ConstrutorContainer { get; set; }
        public static IContainer Container { get; set; }
        private static bool aplicacaoEmTesteUnitario;

        public static void Inicializar()
        {
            ConstrutorContainer = new ContainerBuilder();

            //DefinirAplicacaoEmTesteOuNao();

            ConfigurarInjecoesAppServices();
            ConfigurarInjecoesServiceAgents();
            ConfigurarInjecoesServices();
        }

        public static void Build()
        {
            Container = ConstrutorContainer.Build();
        }

        //private static void DefinirAplicacaoEmTesteOuNao()
        //{
        //    var configuracoes = new ConfigurationBuilder()
        //                            .AddJsonFile("appsettings.json", optional: false)
        //                            .Build();
        //    IConfigurationSection configurationSection = configuracoes.GetSection("AppConfiguration");
        //    aplicacaoEmTesteUnitario = bool.Parse(configurationSection.GetSection("AplicacaoEmTesteUnitario").Value);
        //}

        private static void ConfigurarInjecoesAppServices()
        {
            ConstrutorContainer.RegisterType<MensagemAppService>().As<IMensagemAppService>();
        }

        private static void ConfigurarInjecoesServices()
        {
            ConstrutorContainer.RegisterType<MensagemService>().As<IMensagemService>();
            ConstrutorContainer.RegisterType<WatsonService>().As<IWatsonService>();
        }

        private static void ConfigurarInjecoesServiceAgents()
        {
            ConstrutorContainer.RegisterType<WatsonAgent>().As<IWatsonAgent>();
        }       
    }
}
