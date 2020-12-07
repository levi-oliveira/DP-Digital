using System;
using TemplateMaterialDesignAdmin.Models.Colaborador.Commands;
using TemplateMaterialDesignAdmin.Models.Results;
using TemplateMaterialDesignAdmin.Services.Interfaces;

namespace TemplateMaterialDesignAdmin.Services
{
    public class ColaboradorService : IColaboradorService
    {
        public CommandResult Inserir(ColaboradorInserirCommand command)
        {
            throw new NotImplementedException();
        }

        public CommandResult Atualizar(ColaboradorAtualizarCommand command)
        {
            throw new NotImplementedException();
        }

        public CommandResult Remover(Guid id)
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

        public CommandResult ObterPorCPF(string cpf)
        {
            throw new NotImplementedException();
        }
    }
}