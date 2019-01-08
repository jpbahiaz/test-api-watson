using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;

namespace TestApiWatson.Shared.Util
{
    public class ComunicacaoHttp
    {
        public static string EnviarRequisicaoPostJson(string jsonRequisicao, string url, AuthenticationHeaderValue autenticacao = null)
        {
            var httpContent = MontarHttpContentJson(jsonRequisicao);

            using (HttpClient client = new HttpClient())
            {
                if (autenticacao != null)
                    client.DefaultRequestHeaders.Authorization = autenticacao;
                var resposta = client.PostAsync(url, httpContent).Result;
                return ObterResposta(resposta);
            }

        }

        private static HttpContent MontarHttpContentJson(string json)
        {
            return new StringContent(json, Encoding.UTF8, "application/json");
        }

        private static string ObterResposta(HttpResponseMessage resposta)
        {
            if (resposta != null && resposta.Content != null)
            {
                var responseContent = resposta.Content.ReadAsStringAsync().Result;
                return responseContent;
            }
            return string.Empty;
        }

    }
}
