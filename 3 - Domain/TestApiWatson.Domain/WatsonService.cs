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

        public ConversaWatson TratarMensagemEEnviar(ConversaWatson mensagem)
        {
            throw new NotImplementedException();
        }
    }
}
