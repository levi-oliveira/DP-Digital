using DP_Digital.Domain.Candidatos.Commands;
using DP_Digital.Domain.Candidatos.Commands.Candidatos.Request;
using DP_Digital.Domain.Candidatos.Interfaces;
using Flunt.Notifications;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DP_Digital.API.Controllers
{
    public class CandidatoController : Controller
    {

        private readonly ICandidatoHandler _candidatoHandler;

        public CandidatoController(ICandidatoHandler candidatoHandler)
        {
            _candidatoHandler = candidatoHandler;
        }

        [HttpGet]
        [Route("v1/Candidato/ObterTodos")]
        public async Task<IActionResult> ObterTodosAsync()
        {
            try
            {
                var result = await _candidatoHandler.ObterTodosAsync();


                if (result is null)
                {
                    CandidatoCommandResult retorno = new CandidatoCommandResult("Apresentou um erro", _candidatoHandler.Notifications);
                    return BadRequest(retorno);
                }

                return Ok(result);
            }
            catch (Exception ex)
            {

                CandidatoCommandResult retorno = new CandidatoCommandResult("Erro interno no servidor", new List<Notification>() { new Notification($"{ex.Message}", "InternalServerError") });
                return StatusCode(StatusCodes.Status500InternalServerError, retorno);
            }

    
        }

        [HttpGet]
        [Route("v1/Candidato/ObterPorID/{id:Guid}")]
        public async Task<IActionResult> ObterPorIdAsync(Guid id)
        {
            try
            {
                var result = await _candidatoHandler.ObterPorIdAsync(id);


                if (result is null)
                {
                    CandidatoCommandResult retorno = new CandidatoCommandResult("Apresentou um erro", _candidatoHandler.Notifications);
                    return BadRequest(retorno);
                }

                return Ok(result);
            }
            catch (Exception ex)
            {

                CandidatoCommandResult retorno = new CandidatoCommandResult("Erro interno no servidor", new List<Notification>() { new Notification($"{ex.Message}", "InternalServerError") });
                return StatusCode(StatusCodes.Status500InternalServerError, retorno);
            }
        }

        [HttpGet]
        [Route("v1/Candidato/ObterPorNome/{nome}")]
        public async Task<IActionResult> ObterPorIdAsync(string nome)
        {
            try
            {
                var result = await _candidatoHandler.ObterPorNomeAsync(nome);


                if (result is null)
                {
                    CandidatoCommandResult retorno = new CandidatoCommandResult("Apresentou um erro", _candidatoHandler.Notifications);
                    return BadRequest(retorno);
                }

                return Ok(result);
            }
            catch (Exception ex)
            {

                CandidatoCommandResult retorno = new CandidatoCommandResult("Erro interno no servidor", new List<Notification>() { new Notification($"{ex.Message}", "InternalServerError") });
                return StatusCode(StatusCodes.Status500InternalServerError, retorno);
            }
        }

        [HttpPost]
        [Route("v1/Candidato/Inserir")]
        public async Task<IActionResult> InserirAsync([FromBody] InserirCommand parametros)
        {
            try
            {

                if (parametros == null)
                {
                    CandidatoCommandResult retorno = new CandidatoCommandResult("Apresentou um erro", new List<Notification>() { new Notification("Dados de entrada inválidos.", "Command") });
                    return BadRequest(retorno);
                }

                if (!parametros.ValidarCampos())
                {
                    CandidatoCommandResult retorno = new CandidatoCommandResult("Apresentou um erro",new List<Notification>() { new Notification("Id inválido", "BuscaOrigem") });
                    return BadRequest(retorno);
                }

                var result = await _candidatoHandler.InserirAsync(parametros);

                if (result is null)
                {
                    CandidatoCommandResult retorno = new CandidatoCommandResult("Apresentou um erro",_candidatoHandler.Notifications);
                    return BadRequest(retorno);
                }

                return Ok(result);
            }
            catch (Exception ex)
            {

                CandidatoCommandResult retorno = new CandidatoCommandResult("Erro interno no servidor", new List<Notification>() { new Notification($"{ex.Message}", "InternalServerError") });
                return StatusCode(StatusCodes.Status500InternalServerError, retorno);
            }
        }

        [HttpPut]
        [Route("v1/Candidato/Alterar/{id:Guid}")]
        public async Task<IActionResult> AlterarAsync(Guid id, [FromBody]AlterarCommand parametros)
        {
            try
            {

                if (parametros == null)
                {
                    CandidatoCommandResult retorno = new CandidatoCommandResult("Apresentou um erro", new List<Notification>() { new Notification("Dados de entrada inválidos.", "Command") });
                    return BadRequest(retorno);
                }

                if (!parametros.ValidarCampos())
                {
                    CandidatoCommandResult retorno = new CandidatoCommandResult("Apresentou um erro", new List<Notification>() { new Notification("Id inválido", "BuscaOrigem") });
                    return BadRequest(retorno);
                }

                var result = await _candidatoHandler.AtualizarAsync(parametros, id);

                if (result is null)
                {
                    CandidatoCommandResult retorno = new CandidatoCommandResult("Apresentou um erro", _candidatoHandler.Notifications);
                    return BadRequest(retorno);
                }

                return Ok(result);
            }
            catch (Exception ex)
            {

                CandidatoCommandResult retorno = new CandidatoCommandResult("Erro interno no servidor", new List<Notification>() { new Notification($"{ex.Message}", "InternalServerError") });
                return StatusCode(StatusCodes.Status500InternalServerError, retorno);
            }
        }

        [HttpDelete]
        [Route("v1/Candidato/Remover")]
        public async Task<IActionResult> RemoverAsync([FromBody]RemoverCommand parametros)
        {
            try
            {
                if (parametros == null)
                {
                    CandidatoCommandResult retorno = new CandidatoCommandResult("Apresentou um erro", new List<Notification>() { new Notification("Dados de entrada inválidos.", "Command") });
                    return BadRequest(retorno);
                }

                var result = await _candidatoHandler.RemoverAsync(parametros);

                if (result is null)
                {
                    CandidatoCommandResult retorno = new CandidatoCommandResult("Apresentou um erro", _candidatoHandler.Notifications);
                    return BadRequest(retorno);
                }

                return Ok(result);
            }
            catch (Exception ex)
            {

                CandidatoCommandResult retorno = new CandidatoCommandResult("Erro interno no servidor", new List<Notification>() { new Notification($"{ex.Message}", "InternalServerError") });
                return StatusCode(StatusCodes.Status500InternalServerError, retorno);
            }
        }
    }
}
