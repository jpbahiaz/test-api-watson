using System;
using System.Collections.Generic;
using System.Text;
using TestApiWatson.Domain.Models.Watson;

namespace TestApiWatson.Domain.Interfaces
{
    public interface IMensagemService
    {
        List<string> EnviarMensagem(string mensagem);
    }
}
