using System;
using TemplateMaterialDesignAdmin.Models.Candidato.Commands;
using TemplateMaterialDesignAdmin.Models.Results;

namespace TemplateMaterialDesignAdmin.Services.Interfaces
{
    public interface ICandidatoService
    {
        CommandResult Inserir(CandidatoInserirCommand command);
        CommandResult Atualizar(CandidatoAtualizarCommand command);
        CommandResult Remover(CandidatoDeleteCommand command);
        CommandResult ObterTodos();
        CommandResult ObterPorId(Guid id);
        CommandResult ObterPorNome(string nome);
    }
}