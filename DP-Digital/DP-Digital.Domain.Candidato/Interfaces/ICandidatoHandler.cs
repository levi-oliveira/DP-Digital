
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
        Task<CandidatoCommandResult> InserirAsync(InserirCommand request);
        Task<CandidatoCommandResult> RemoverAsync(RemoverCommand request);
        Task<CandidatoCommandResult> AtualizarAsync(AlterarCommand request, Guid Id);
        Task<CandidatoCommandResult> ObterTodosAsync();
        Task<CandidatoCommandResult> ObterPorIdAsync(Guid id);
        Task<CandidatoCommandResult> ObterPorNomeAsync(string nome);

        public IReadOnlyCollection<Notification> Notifications { get; }
    }
}
