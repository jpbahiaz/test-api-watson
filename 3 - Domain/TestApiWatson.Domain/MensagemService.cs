using System;
using System.Collections.Generic;
using System.Text;
using TestApiWatson.Domain.Interfaces;
using TestApiWatson.Domain.Models.Watson;
using TesteApiWatson.Infra.Data.ServiceAgent.Interfaces;

namespace TestApiWatson.Domain
{
    public class MensagemService : IMensagemService
    {
        public readonly IWatsonAgent _watsonAgent;

        public MensagemService(IWatsonAgent watsonAgent)
        {
            watsonAgent = _watsonAgent;
        }

        public ConversaWatson EnviarMensagem(string mensagem)
        {

            //throw new NotImplementedException();
            //return _watsonAgent.EnviarMensagem("teste");
            return new ConversaWatson();
        }
    }
}
