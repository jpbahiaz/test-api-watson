using System;
using System.Collections.Generic;
using System.Text;

namespace TesteApiWatson.Infra.Data.ServiceAgent.Interfaces
{
    public interface IWatsonAgent
    {
        string EnviarMensagem(string mensagem);//Passar por parâmetro e esperar de retorno um ConversaWatson (criar model em Domain)
    }
}
