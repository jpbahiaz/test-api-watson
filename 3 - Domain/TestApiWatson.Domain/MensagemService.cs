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
        public readonly IWatsonService _watsonService;

        public MensagemService(IWatsonService watsonService)
        {
            _watsonService = watsonService;
        }

        public List<string> EnviarMensagem(string mensagem)
        {

            //throw new NotImplementedException();
            return _watsonService.TratarMensagemEEnviar(mensagem);
            //return new ConversaWatson();
        }
    }
}
