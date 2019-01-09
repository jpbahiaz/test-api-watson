using System;
using System.Collections.Generic;
using System.Text;
using TestApiWatson.Domain.Interfaces;
using TestApiWatson.Domain.Models.Watson;
using TesteApiWatson.Infra.Data.ServiceAgent.Interfaces;

namespace TestApiWatson.Domain
{
    public class WatsonService : IWatsonService
    {
        private readonly IWatsonAgent _watsonAgent;

        public WatsonService(IWatsonAgent watsonAgent)
        {
            _watsonAgent = watsonAgent;
        }

        public List<string> TratarMensagemEEnviar(string mensagem)
        {

            ConversaWatson msg = ConversationService.MontarMensagem(mensagem);
            ConversaWatson retornoWatson = _watsonAgent.EnviarMensagem(msg);

            ConversationService.DefinirContexto(retornoWatson);

            return retornoWatson.Output.Text;
        }
    }
}
