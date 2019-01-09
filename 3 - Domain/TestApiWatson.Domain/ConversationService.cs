using System;
using System.Collections.Generic;
using System.Text;
using TestApiWatson.Domain.Interfaces;
using TestApiWatson.Domain.Models.Watson;

namespace TestApiWatson.Domain
{
    public static class ConversationService
    {
        public static ConversaWatson _contextWatson = new ConversaWatson();

        public static ConversaWatson MontarMensagem(string mensagem)
        {
            _contextWatson.Input = new UserInput
            {
                Text = mensagem
            };
            return _contextWatson;
        }

        public static void DefinirContexto(ConversaWatson contexto)
        {
            _contextWatson.Context = contexto.Context;
        }
    }
}

