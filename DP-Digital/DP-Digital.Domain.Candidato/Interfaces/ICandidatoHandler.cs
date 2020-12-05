
using DP_Digital.Domain.Candidatos.Commands;
using DP_Digital.Domain.Candidatos.Commands.Candidatos.Request;
using Flunt.Notifications;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace DP_Digital.Domain.Candidatos.Interfaces
{
    public interface ICandidatoHandler
    {
        Task<CommandResult> InserirAsync(InserirCommand request);
        Task<CommandResult> RemoverAsync(RemoverCommand request);
        Task<CommandResult> AtualizarAsync(AlterarCommand request, Guid Id);
        Task<CommandResult> ObterTodosAsync();
        Task<CommandResult> ObterPorIdAsync(Guid id);
        Task<CommandResult> ObterPorNomeAsync(string nome);

        public IReadOnlyCollection<Notification> Notifications { get; }
    }
}
