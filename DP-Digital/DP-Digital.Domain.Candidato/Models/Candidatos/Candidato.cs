using DP_Digital.Domain.Candidatos.Commands.Candidatos.Request;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Text;

namespace DP_Digital.Domain.Candidatos.Models.Candidatos
{
    public class Candidato
    {
        public Candidato()
        {
            Id = Guid.NewGuid();
        }
        public Candidato(Guid id)
        {
            Id = id;
        }

        [BsonId]
        public Guid Id { get; private set; }

        public string Nome { get; set; }
        public string Imagem { get; set; }
        public string Titulo { get; set; }
        public string CurriculoBase64 { get; set; }
        public List<TrajetoriaProfissional> TrajetorioProfissionais { get; set; }
        public List<Certificado> Certificados { get; set; }



    }
}
