
using DP_Digital.Domain.Candidatos.Interfaces;
using DP_Digital.Domain.Candidatos.Commands;
using Flunt.Notifications;
using System;
using System.Threading.Tasks;
using DP_Digital.Domain.Candidatos.Commands.Candidatos.Request;
using DP_Digital.Domain.Candidatos.Models.Candidatos;

namespace DP_Digital.Domain.Candidatos.Handlers
{
    public class CandidatoHandler : Notifiable,  ICandidatoHandler
    {

        private readonly ICandidatoRepository _candidatoRepository;

        public CandidatoHandler(ICandidatoRepository candidatoRepository)
        {
            _candidatoRepository = candidatoRepository;
        }

        public async Task<CommandResult> InserirAsync(InserirCommand request)
        {
            try
            {
                Candidato candidato = GerarCandidato(request);
                await _candidatoRepository.InserirAsync(candidato);

                return new CommandResult("Candidato Inserido com Suacesso", candidato);

            }
            catch (Exception ex)
            {

                throw ex;
            }

        }



        public async Task<CommandResult> RemoverAsync(RemoverCommand request)
        {
            try
            {
                var candidato = await _candidatoRepository.ObterPorIdAsync(request.Id);

                if (candidato == null)
                {
                    AddNotification("Candidato", "Não existe candidato com esse ID");
                    return null;
                }

                 await _candidatoRepository.RemoverAsync(request.Id);

                return new CommandResult("Removido com sucesso", null);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }


        public async Task<CommandResult> AtualizarAsync(AlterarCommand request, Guid Id)
        {
            try
            {
                var candidatoId = await _candidatoRepository.ObterPorIdAsync(Id);

                if (candidatoId == null)
                {
                    AddNotification("Candidato", "Não existe candidato com esse ID");
                    return null;
                }

                request.Id = Id;

                var candidato = GerarCandidatoAtualizar(request);

                await _candidatoRepository.AtualizarAsync(candidato);

                return new CommandResult("Removido com sucesso", null);

            }
            catch (Exception)
            {

                throw;
            }
        }

        public async Task<CommandResult> ObterTodosAsync()
        {
            try
            {
               var retorno = await _candidatoRepository.ObterTodosAsync();
                return new CommandResult("Consulta Realizada com sucesso.", retorno);
            }
            catch (Exception ex)
            {

                throw ex;
            }

           
        }

        public async Task<CommandResult> ObterPorIdAsync(Guid id)
        {
            try
            {
                var retorno = await _candidatoRepository.ObterPorIdAsync(id);

                if (retorno == null)
                {
                    AddNotification("Candidato", "Não existe candidato com esse ID");
                    return null;
                }

                return new CommandResult("Consulta Realizada com sucesso.", retorno);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public async Task<CommandResult> ObterPorNomeAsync(string nome)
        {
            try
            {
                var retorno = await _candidatoRepository.ObterPorNomeAsync(nome);

                if (retorno == null)
                {
                    AddNotification("Candidato", "Não existe candidato com esse Nome");
                    return null;
                }

                return new CommandResult("Consulta Realizada com sucesso.", retorno);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        private Candidato GerarCandidato(InserirCommand request)
        {
            Candidato candidato = new Candidato();
            candidato.TrajetorioProfissionais = request.TrajetorioProfissionais;
            candidato.Certificados = request.Certificados;
            candidato.CurriculoBase64 = request.CurriculoBase64;
            candidato.Imagem = request.Imagem;
            candidato.Nome = request.Nome;
            candidato.Titulo = request.Titulo;

            return candidato;
        }


        private Candidato GerarCandidatoAtualizar(AlterarCommand request)
        {
            Candidato candidato = new Candidato(request.Id);
            candidato.TrajetorioProfissionais = request.TrajetorioProfissionais;
            candidato.Certificados = request.Certificados;
            candidato.CurriculoBase64 = request.CurriculoBase64;
            candidato.Imagem = request.Imagem;
            candidato.Nome = request.Nome;
            candidato.Titulo = request.Titulo;

            return candidato;
        }
    }
}
