using DP_Digital.Domain.Candidatos.Interfaces;
using DP_Digital.Domain.Candidatos.Models.Candidatos;
using DP_Digital.Infra.Candidatos.Contexts;
using MongoDB.Bson;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace DP_Digital.Infra.Candidatos.Repositorys
{
    public class CandidatoRepository : ICandidatoRepository
    {
        private readonly MongoDBContext _mongoDBContext;
        private readonly string _collection;

        public CandidatoRepository(MongoDBContext mongoDBContext)
        {
            _mongoDBContext = mongoDBContext;
            _collection = "Candidato";
        }

        public async Task AtualizarAsync(Candidato candidato)
        {
            await RemoverAsync(candidato.Id);

            await InserirAsync(candidato);
        }

        public async Task InserirAsync(Candidato candidato)
        {
            var collection = _mongoDBContext.MongoDBConexao.GetCollection<Candidato>(_collection);

            await collection.InsertOneAsync(candidato);
        }

        public async Task<Candidato> ObterPorIdAsync(Guid id)
        {
            var collection = _mongoDBContext.MongoDBConexao.GetCollection<Candidato>(_collection);

            Expression<Func<Candidato, bool>> filter = x => x.Id == id;

            var retorno = await collection.FindAsync<Candidato>(filter);

            return retorno.FirstOrDefault(); 
        }

        public async Task<Candidato> ObterPorNomeAsync(string nome)
        {
            var collection = _mongoDBContext.MongoDBConexao.GetCollection<Candidato>(_collection);

            Expression<Func<Candidato, bool>> filter = x => x.Nome.ToUpper() == nome.ToUpper();

            var retorno = await collection.FindAsync<Candidato>(filter);

            return retorno.FirstOrDefault();
        }

        public async Task<List<Candidato>> ObterTodosAsync()
        {
            var collection = _mongoDBContext.MongoDBConexao.GetCollection<Candidato>(_collection);

            var retorno = await collection.FindAsync<Candidato>(new BsonDocument());

            return retorno.ToList();
        }


        public async Task RemoverAsync(Guid id)
        {
            var collection = _mongoDBContext.MongoDBConexao.GetCollection<Candidato>(_collection);

            Expression<Func<Candidato, bool>> filter = x => x.Id == id;
            await collection.DeleteOneAsync(filter);
        }
    }
}
