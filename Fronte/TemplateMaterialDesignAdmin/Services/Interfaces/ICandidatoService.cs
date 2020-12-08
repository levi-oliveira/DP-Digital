using System;
using System.Threading.Tasks;
using TemplateMaterialDesignAdmin.Models.Candidato.Commands;
using TemplateMaterialDesignAdmin.Models.Results;

namespace TemplateMaterialDesignAdmin.Services.Interfaces
{
    public interface ICandidatoService
    {
        Task<CommandResult> Inserir(CandidatoInserirCommand command);
        Task<CommandResult> Atualizar(CandidatoInserirCommand command, Guid id);
        Task<CommandResult> Remover(CandidatoDeleteCommand command);
        Task<CommandResult> ObterTodos();
        Task<CommandResult> ObterPorId(Guid id);
        Task<CommandResult> ObterPorNome(string nome);
    }
}