using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace TestApiWatson.Domain.Models.Watson
{
    [DataContract]
    public class Context
    {
        [DataMember(Name = "conversation_id")]
        public string ConversationId { get; set; }

        [DataMember(Name = "system")]
        public dynamic System { get; set; }

        [DataMember(Name = "metadata")]
        public Metadata Metadata { get; set; }

        [DataMember(Name = "Carteira")]
        public string IdCarteira { get; set; }

        [DataMember(Name = "NumeroObra")]
        public string NumeroObra { get; set; }

        [DataMember(Name = "Cnpj")]
        public string CnpjFornecedor { get; set; }

        [DataMember(Name = "NumeroPedido")]
        public string NumeroPedido { get; set; }

        [DataMember(Name = "NumeroContrato")]
        public string NumeroContrato { get; set; }

        [DataMember(Name = "RazaoSocial")]
        public string RazaoSocial { get; set; }

        [DataMember(Name = "Counter")]
        public int Counter { get; set; }

        [DataMember(Name = "PodeTrocarObra")]
        public Boolean PodeTrocarObra { get; set; }

        [DataMember(Name = "AguardarSelecionarObra")]
        public Boolean AguardarSelecionarObra { get; set; }

        [DataMember(Name = "NumeroRequisicao")]
        public string NumeroRequisicao { get; set; }

        [DataMember(Name = "TipoDeContrato")]
        public string TipoDeContrato { get; set; }

        [DataMember(Name = "TipoDeFiltro")]
        public string TipoDeFiltro { get; set; }

        [DataMember(Name = "GrupoDeMercadoria")]
        public string GrupoDeMercadoria { get; set; }
    }
}
