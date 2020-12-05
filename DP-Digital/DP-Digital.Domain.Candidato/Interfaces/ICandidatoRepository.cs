using DP_Digital.Domain.Candidatos.Commands.Candidatos.Request;
using DP_Digital.Domain.Candidatos.Models.Candidatos;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace DP_Digital.Domain.Candidatos.Interfaces
{
     public interface ICandidatoRepository
    {
        Task InserirAsync(Candidato candidato);
        Task<List<Candidato>> ObterTodosAsync();

        Task<Candidato> ObterPorIdAsync(Guid id);

        Task RemoverAsync(Guid id);

        Task AtualizarAsync(Candidato candidato);

        Task<Candidato> ObterPorNomeAsync(string nome);
    }
}
