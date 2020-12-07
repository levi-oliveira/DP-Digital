using System;
using TemplateMaterialDesignAdmin.Models.Colaborador.Commands;
using TemplateMaterialDesignAdmin.Models.Results;

namespace TemplateMaterialDesignAdmin.Services.Interfaces
{
    public interface IColaboradorService
    {
        CommandResult Inserir(ColaboradorInserirCommand command);
        CommandResult Atualizar(ColaboradorAtualizarCommand command);
        CommandResult Remover(Guid id);
        CommandResult ObterPorId(Guid id);
        CommandResult ObterPorNome(string nome);
        CommandResult ObterPorCPF(string cpf);
    }
}