using System;
using System.Collections.Generic;
using System.Text;

namespace DP_Digital.Domain.Candidatos.Models.Candidatos
{
    public class TrajetoriaProfissional
    {
        public string Empresa { get; set; }
        public DateTime DataInicio { get; set; }
        public DateTime? DataFim { get; set; }
        public string Descricao { get; set; }
        public List<Image> Imagens { get; set; }
    }
}
