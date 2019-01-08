using System;
using System.Collections.Generic;
using System.Text;
using TestApiWatson.Domain.Models.Watson;

namespace TesteApiWatson.Infra.Data.ServiceAgent.Interfaces
{
    public interface IWatsonAgent
    {
        ConversaWatson EnviarMensagem(ConversaWatson mensagem);
    }
}
