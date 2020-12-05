using DP_Digital.Domain.Candidatos;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Options;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Text;

namespace DP_Digital.Infra.Candidatos.Contexts
{
    public class MongoDBContext : IDisposable
    {
        public IMongoDatabase MongoDBConexao { get; set; }
        private IMongoClient _client { get; set; }

        private readonly Settings _settings;
        public MongoDBContext(IOptions<Settings> options) 
        {
            _settings = options.Value;
            _client = new MongoClient(_settings.ConnectionStrings);
            MongoDBConexao = _client.GetDatabase(_settings.DataBase);
        }

        public void Dispose()
        {
            MongoDBConexao = null;
            _client = null;
        }
    }
}
