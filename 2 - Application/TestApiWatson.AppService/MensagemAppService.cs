using System;
using System.Collections.Generic;
using System.Text;
using TestApiWatson.AppService.Interfaces;
using TestApiWatson.Domain.Interfaces;
using TestApiWatson.Domain.Models.Watson;

namespace TestApiWatson.AppService
{
    public class MensagemAppService : IMensagemAppService
    {

        public readonly IMensagemService _mensagemService;

        public MensagemAppService(IMensagemService mensagemService)
        {
            _mensagemService = mensagemService;
        }

        public List<string> EnviarMensagem(string mensagem)
        {
            return _mensagemService.EnviarMensagem(mensagem);
        }
    }
}
