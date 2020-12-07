using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using TemplateMaterialDesignAdmin.Helpers.Models;

namespace TemplateMaterialDesignAdmin.Helpers
{
    /// <summary>Helper que auxilia na utilização de requisições HTTP.</summary>
    public static class RestFullHelper
    {
        /// <summary>Metódo GET para requisições HTTP.</summary>
        /// <param name="baseUrlServico">URL base do serviço acessado.</param>
        /// <param name="urlServico">URL do serviço acessado.</param>
        /// <param name="headers">Headers que serão utilizados na requisição.</param>
        /// <param name="schemaAuth">Tipo de autenticação que será utilizada na requisição.</param>
        /// <param name="tokem">Tokem que será utilizado na requisição.</param>
        /// <returns>HttpResponseMessage gerado pela requisição HTTP.</returns>
        /// <exception cref="Exception">Erro durante a requisição HTTP.</exception>
        public static async Task<HttpResponseMessage> Get(string baseUrlServico, string urlServico, List<ApiHeadersModel> headers = null, string schemaAuth = null, string tokem = null)
        {
            try
            {
                HttpClient client = new HttpClient();
                client.DefaultRequestHeaders.Clear();
                client = SetHeaders(client, headers);
                client = SetAuthorization(client, schemaAuth, tokem);

                HttpRequestMessage request = new HttpRequestMessage
                {
                    Method = HttpMethod.Get,
                    RequestUri = new Uri(baseUrlServico + urlServico)
                };

                using (client)
                {
                    return await client.SendAsync(request);
                }
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        /// <summary>Metódo GET com Content para requisições HTTP.</summary>
        /// <param name="baseUrlServico">URL base do serviço acessado.</param>
        /// <param name="urlServico">URL do serviço acessado.</param>
        /// <typeparam name="TEntity">Model que será utilizada como Content.</typeparam>
        /// <param name="requestBody">Content que será utilizado na requisição.</param>
        /// <param name="headers">Headers que serão utilizados na requisição.</param>
        /// <param name="schemaAuth">Tipo de autenticação que será utilizada na requisição.</param>
        /// <param name="tokem">Tokem que será utilizado na requisição.</param>
        /// <returns>HttpResponseMessage gerado pela requisição HTTP.</returns>
        /// <exception cref="Exception">Erro durante a requisição HTTP.</exception>
        public static async Task<HttpResponseMessage> Get<TEntity>(string baseUrlServico, string urlServico, TEntity requestBody, List<ApiHeadersModel> headers = null, string schemaAuth = null, string tokem = null)
        {
            try
            {
                HttpClient client = new HttpClient();
                client.DefaultRequestHeaders.Clear();
                client = SetHeaders(client, headers);
                client = SetAuthorization(client, schemaAuth, tokem);

                string json = JsonConvert.SerializeObject(requestBody);
                HttpContent httpContent = new StringContent(json, Encoding.UTF8, "application/json");

                HttpRequestMessage request = new HttpRequestMessage
                {
                    Method = HttpMethod.Get,
                    RequestUri = new Uri(baseUrlServico + urlServico),
                    Content = httpContent
                };

                using (client)
                {
                    return await client.SendAsync(request);
                }
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        /// <summary>Metódo POST para requisições HTTP.</summary>
        /// <param name="baseUrlServico">URL base do serviço acessado.</param>
        /// <param name="urlServico">URL do serviço acessado.</param>
        /// <typeparam name="TEntity">Model que será utilizada como Content.</typeparam>
        /// <param name="requestBody">Content que será utilizado na requisição.</param>
        /// <param name="headers">Headers que serão utilizados na requisição.</param>
        /// <param name="schemaAuth">Tipo de autenticação que será utilizada na requisição.</param>
        /// <param name="tokem">Tokem que será utilizado na requisição.</param>
        /// <returns>HttpResponseMessage gerado pela requisição HTTP.</returns>
        /// <exception cref="Exception">Erro durante a requisição HTTP.</exception>
        public static async Task<HttpResponseMessage> Post<TEntity>(string baseUrlServico, string urlServico, TEntity requestBody, List<ApiHeadersModel> headers = null, string schemaAuth = null, string tokem = null)
        {
            try
            {
                HttpClient client = new HttpClient();
                client.BaseAddress = new Uri(baseUrlServico);
                client.DefaultRequestHeaders.Clear();
                client = SetHeaders(client, headers);
                client = SetAuthorization(client, schemaAuth, tokem);

                string json = JsonConvert.SerializeObject(requestBody);
                HttpContent httpContent = new StringContent(json, Encoding.UTF8, "application/json");

                using (client)
                {
                    return await client.PostAsync(urlServico, httpContent);
                }
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        /// <summary>Metódo PUT para requisições HTTP.</summary>
        /// <param name="baseUrlServico">URL base do serviço acessado.</param>
        /// <param name="urlServico">URL do serviço acessado.</param>
        /// <typeparam name="TEntity">Model que será utilizada como Content.</typeparam>
        /// <param name="requestBody">Content que será utilizado na requisição.</param>
        /// <param name="headers">Headers que serão utilizados na requisição.</param>
        /// <param name="schemaAuth">Tipo de autenticação que será utilizada na requisição.</param>
        /// <param name="tokem">Tokem que será utilizado na requisição.</param>
        /// <returns>HttpResponseMessage gerado pela requisição HTTP.</returns>
        /// <exception cref="Exception">Erro durante a requisição HTTP.</exception>
        public static async Task<HttpResponseMessage> Put<TEntity>(string baseUrlServico, string urlServico, TEntity requestBody, List<ApiHeadersModel> headers = null, string schemaAuth = null, string tokem = null)
        {
            try
            {
                HttpClient client = new HttpClient();
                client.BaseAddress = new Uri(baseUrlServico);
                client.DefaultRequestHeaders.Clear();
                client = SetHeaders(client, headers);
                client = SetAuthorization(client, schemaAuth, tokem);

                string json = JsonConvert.SerializeObject(requestBody);
                HttpContent httpContent = new StringContent(json, Encoding.UTF8, "application/json");

                using (client)
                {
                    return await client.PutAsync(urlServico, httpContent);
                }
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        /// <summary>Metódo DELETE para requisições HTTP.</summary>
        /// <param name="baseUrlServico">URL base do serviço acessado.</param>
        /// <param name="urlServico">URL do serviço acessado.</param>
        /// <typeparam name="TEntity">Model que será utilizada como Content.</typeparam>
        /// <param name="requestBody">Content que será utilizado na requisição.</param>
        /// <param name="headers">Headers que serão utilizados na requisição.</param>
        /// <param name="schemaAuth">Tipo de autenticação que será utilizada na requisição.</param>
        /// <param name="tokem">Tokem que será utilizado na requisição.</param>
        /// <returns>HttpResponseMessage gerado pela requisição HTTP.</returns>
        /// <exception cref="Exception">Erro durante a requisição HTTP.</exception>
        public static async Task<HttpResponseMessage> Delete<TEntity>(string baseUrlServico, string urlServico, TEntity requestBody, List<ApiHeadersModel> headers = null, string schemaAuth = null, string tokem = null)
        {
            try
            {
                HttpClient client = new HttpClient();
                client.DefaultRequestHeaders.Clear();
                client = SetHeaders(client, headers);
                client = SetAuthorization(client, schemaAuth, tokem);

                string json = JsonConvert.SerializeObject(requestBody);
                HttpContent httpContent = new StringContent(json, Encoding.UTF8, "application/json");

                HttpRequestMessage request = new HttpRequestMessage
                {
                    Method = HttpMethod.Delete,
                    RequestUri = new Uri(baseUrlServico + urlServico),
                    Content = httpContent
                };

                using (client)
                {
                    return await client.SendAsync(request);
                }
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        /// <summary>Seta valores dos Headers em um HttpClient.</summary>
        /// <param name="client">HttpClient que será utilizado na requisição.</param>
        /// <param name="headers">Headers que serão utilizados na requisição.</param>
        /// <returns>HttpClient com Headers configurados.</returns>
        /// <exception cref="Exception">Erro durante a configuração dos Headers no HttpClient.</exception>
        private static HttpClient SetHeaders(HttpClient client, List<ApiHeadersModel> headers)
        {
            if (headers != null)
            {
                if (headers.Count() > 0)
                {
                    foreach (var header in headers)
                    {
                        if (!string.IsNullOrEmpty(header.Chave) && !string.IsNullOrEmpty(header.Valor))
                        {
                            client.DefaultRequestHeaders.Add(header.Chave, header.Valor);
                        }
                        else if (!string.IsNullOrEmpty(header.Chave) && header.Valores.Count() > 0)
                        {
                            client.DefaultRequestHeaders.Add(header.Chave, header.Valores);
                        }
                    }
                }
            }

            return client;
        }

        /// <summary>Seta valores do Authorization em um HttpClient.</summary>
        /// <param name="client">HttpClient que será utilizado na requisição.</param>
        /// <param name="schemaAuth">Tipo de autenticação que será utilizada na requisição.</param>
        /// <param name="tokem">Tokem que será utilizado na requisição.</param>
        /// <returns>HttpClient com Authorization configurado.</returns>
        /// <exception cref="Exception">Erro durante a configuração do Authorization no HttpClient.</exception>
        private static HttpClient SetAuthorization(HttpClient client, string schemaAuth, string tokem)
        {
            if (schemaAuth != null)
                if (schemaAuth != "")
                    client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue(schemaAuth, tokem);

            return client;
        }
    }
}