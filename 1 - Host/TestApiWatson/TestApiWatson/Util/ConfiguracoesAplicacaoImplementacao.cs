using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TestApiWatson.Shared.Util.Configuracoes;

namespace TestApiWatson.Util
{
    public class ConfiguracoesAplicacaoImplementacao : ConfiguracoesAplicacao
    {
        private readonly IConfigurationSection _configApp;
        //private static Dictionary<string, string> dicionario;
        //private static KeyVaultClient keyClient;

        public ConfiguracoesAplicacaoImplementacao(IConfiguration configuracoes)
        {
            _configApp = configuracoes.GetSection("AppConfiguration");
        }

        public override bool APLICACAO_EM_TESTE_UNITARIO => _configApp.GetValue<bool>("AplicacaoEmTesteUnitario");

        public override bool APLICACAO_EM_TESTE_INTEGRACAO => _configApp.GetValue<bool>("AplicacaoEmTesteUnitario");

        public override string URL_BASE_WATSON => _configApp.GetValue<string>("UrlBaseWatson");
              
        public override string ID_WORKSPACE_WATSON => _configApp.GetValue<string>("IdWorkspaceWatson");

        public override string USERNAME_WATSON => _configApp.GetValue<string>("UsernameWatson");

        public override string PASSWORD_WATSON => _configApp.GetValue<string>("PasswordWatson");

        public override string VERSAO_WATSON => _configApp.GetValue<string>("VersaoWatson");
    }
}
