using Microsoft.Extensions.Options;
using Newtonsoft.Json;
using System;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using TemplateMaterialDesignAdmin.Models.Candidato.Commands;
using TemplateMaterialDesignAdmin.Models.Results;
using TemplateMaterialDesignAdmin.Services.Interfaces;

namespace TemplateMaterialDesignAdmin.Services
{
    public class CandidatoService : ICandidatoService
    {
        private readonly Settings _settings;

        public CandidatoService(IOptions<Settings> options)
        {
            _settings = options.Value;
        }

        public async Task<CommandResult> Inserir(CandidatoInserirCommand command)
        {
            try
            {
                HttpClient client = new HttpClient();
                client.BaseAddress = new Uri(_settings.DPDIGITAL_API_CADIDATO);

                string json = JsonConvert.SerializeObject(command);
                HttpContent httpContent = new StringContent(json, Encoding.UTF8, "application/json");

                HttpResponseMessage httpResponse;

                using (client)
                {
                    httpResponse = await client.PostAsync(_settings.ENDPOINT_CANDIDATO_INSERIR, httpContent);
                }

                var response = httpResponse.Content.ReadAsStringAsync().Result;
                var retorno = JsonConvert.DeserializeObject<CommandResult>(response);
                return retorno;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public async Task<CommandResult> Atualizar(CandidatoAtualizarCommand command)
        {
            try
            {
                HttpClient client = new HttpClient();
                client.BaseAddress = new Uri(_settings.DPDIGITAL_API_CADIDATO);

                string json = JsonConvert.SerializeObject(command);
                HttpContent httpContent = new StringContent(json, Encoding.UTF8, "application/json");

                HttpResponseMessage httpResponse;

                using (client)
                {
                    httpResponse = await client.PutAsync(_settings.ENDPOINT_CANDIDATO_ALTERAR, httpContent);
                }

                var response = httpResponse.Content.ReadAsStringAsync().ToString();
                var retorno = JsonConvert.DeserializeObject<CommandResult>(response);
                return retorno;
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        public async Task<CommandResult> Remover(CandidatoDeleteCommand command)
        {
            try
            {
                HttpClient client = new HttpClient();

                string json = JsonConvert.SerializeObject(command);
                HttpContent httpContent = new StringContent(json, Encoding.UTF8, "application/json");

                HttpRequestMessage request = new HttpRequestMessage
                {
                    Method = HttpMethod.Delete,
                    RequestUri = new Uri(_settings.DPDIGITAL_API_CADIDATO + _settings.ENDPOINT_CANDIDATO_REMOVER),
                    Content = httpContent
                };

                HttpResponseMessage httpResponse;

                using (client)
                {
                    httpResponse = await client.SendAsync(request);
                }

                var response = httpResponse.Content.ReadAsStringAsync().ToString();
                var retorno = JsonConvert.DeserializeObject<CommandResult>(response);
                return retorno;
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        public async Task<CommandResult> ObterTodos()
        {
            try
            {
                HttpClient client = new HttpClient();
                Uri uri = new Uri(_settings.DPDIGITAL_API_CADIDATO + _settings.ENDPOINT_CANDIDATO_OBTERTODOS);

                HttpRequestMessage request = new HttpRequestMessage
                {
                    Method = HttpMethod.Get,
                    RequestUri = uri
                };

                HttpResponseMessage httpResponse;

                using (client)
                {
                    httpResponse = await client.SendAsync(request);
                }

                var response = httpResponse.Content.ReadAsStringAsync().ToString();
                var retorno = JsonConvert.DeserializeObject<CommandResult>(response);
                return retorno;
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        public async Task<CommandResult> ObterPorId(Guid id)
        {
            try
            {
                HttpClient client = new HttpClient();
                Uri uri = new Uri(_settings.DPDIGITAL_API_CADIDATO + _settings.ENDPOINT_CANDIDATO_OBTERPORID + id.ToString());

                HttpRequestMessage request = new HttpRequestMessage
                {
                    Method = HttpMethod.Get,
                    RequestUri = uri
                };

                HttpResponseMessage httpResponse;

                using (client)
                {
                    httpResponse = await client.SendAsync(request);
                }

                var response = httpResponse.Content.ReadAsStringAsync().ToString();
                var retorno = JsonConvert.DeserializeObject<CommandResult>(response);
                return retorno;
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        public async Task<CommandResult> ObterPorNome(string nome)
        {
            try
            {
                HttpClient client = new HttpClient();
                Uri uri = new Uri(_settings.DPDIGITAL_API_CADIDATO + _settings.ENDPOINT_CANDIDATO_OBTERPORNOME + nome);

                HttpRequestMessage request = new HttpRequestMessage
                {
                    Method = HttpMethod.Get,
                    RequestUri = uri
                };

                HttpResponseMessage httpResponse;

                using (client)
                {
                    httpResponse = await client.SendAsync(request);
                }

                var response = httpResponse.Content.ReadAsStringAsync().ToString();
                var retorno = JsonConvert.DeserializeObject<CommandResult>(response);
                return retorno;
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }
    }
}