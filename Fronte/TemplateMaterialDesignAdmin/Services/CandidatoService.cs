using System;
using TemplateMaterialDesignAdmin.Models.Candidato.Commands;
using TemplateMaterialDesignAdmin.Models.Results;
using TemplateMaterialDesignAdmin.Services.Interfaces;

namespace TemplateMaterialDesignAdmin.Services
{
    public class CandidatoService : ICandidatoService
    {
        public CommandResult Inserir(CandidatoInserirCommand command)
        {
            throw new NotImplementedException();
        }

        public CommandResult Atualizar(CandidatoAtualizarCommand command)
        {
            throw new NotImplementedException();
        }

        public CommandResult Remover(CandidatoDeleteCommand command)
        {
            throw new NotImplementedException();
        }

        public CommandResult ObterTodos()
        {
            throw new NotImplementedException();
        }

        public CommandResult ObterPorId(Guid id)
        {
            throw new NotImplementedException();
        }

        public CommandResult ObterPorNome(string nome)
        {
            throw new NotImplementedException();
        }
    }
}