using System;
using System.Collections.Generic;

namespace TemplateMaterialDesignAdmin.Models.Candidato
{
    public class TrajetoriaProfissional
    {
        public string Empresa { get; set; }
        public DateTime DataInicio { get; set; }
        public DateTime? DataFim { get; set; }
        public string Descricao { get; set; }
        public List<Imagem> Imagens { get; set; }
    }
}