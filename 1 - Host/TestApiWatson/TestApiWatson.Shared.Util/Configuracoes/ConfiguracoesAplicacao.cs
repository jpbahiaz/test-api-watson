using System;
using System.Collections.Generic;
using System.Text;

namespace TestApiWatson.Shared.Util.Configuracoes
{
    public abstract class ConfiguracoesAplicacao
    {
        public abstract bool APLICACAO_EM_TESTE_UNITARIO { get; }
        public abstract bool APLICACAO_EM_TESTE_INTEGRACAO { get; }
        public abstract string URL_BASE_WATSON { get; }
        public abstract string ID_WORKSPACE_WATSON { get; }
        public abstract string USERNAME_WATSON { get; }
        public abstract string PASSWORD_WATSON { get; }
        public abstract string VERSAO_WATSON { get; }
    }
}
