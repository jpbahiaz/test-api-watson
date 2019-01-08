using System;
using System.Net.Http.Headers;
using System.Text;
using TestApiWatson.Domain.Models.Watson;
using TestApiWatson.Shared.Util;
using TestApiWatson.Shared.Util.Configuracoes;
using TesteApiWatson.Infra.Data.ServiceAgent.Interfaces;

namespace TesteApiWatson.Infra.Data.ServiceAgent
{
    public class WatsonAgent : IWatsonAgent
    {
        private readonly ConfiguracoesAplicacao _config;
        
        public WatsonAgent(ConfiguracoesAplicacao config)
        {
            _config = config;
        }

        public ConversaWatson EnviarMensagem(ConversaWatson mensagem)
        {
            var jsonWatson = ConversorJSON.SerializarObjeto(mensagem);

            var jsonRequisicao = ComunicacaoHttp.EnviarRequisicaoPostJson(jsonWatson, ObterUrlWatson(), ObterHeaderWatson());

            var respostaWatson = ConversorJSON.DesserializarObjeto<ConversaWatson>(jsonRequisicao);

            return respostaWatson;
        }

        private string ObterUrlWatson()
        {
            var urlBase = _config.URL_BASE_WATSON;
            var idWorkspace = _config.ID_WORKSPACE_WATSON;
            var versaoWatson = _config.VERSAO_WATSON;

            return string.Format(urlBase, idWorkspace, versaoWatson);
        }

        private AuthenticationHeaderValue ObterHeaderWatson()
        {
            string auth = string.Format("{0}:{1}", _config.USERNAME_WATSON, _config.PASSWORD_WATSON);
            string auth64 = Convert.ToBase64String(Encoding.ASCII.GetBytes(auth));
            return new AuthenticationHeaderValue("Basic", auth64);
        }
    }
}
