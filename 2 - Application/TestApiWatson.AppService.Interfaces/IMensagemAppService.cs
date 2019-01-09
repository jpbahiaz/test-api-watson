using System;
using System.Collections.Generic;
using System.Text;
using TestApiWatson.Domain.Models.Watson;

namespace TestApiWatson.AppService.Interfaces
{
    public interface IMensagemAppService
    {
        List<string> EnviarMensagem(string mensagem);
    }
}
