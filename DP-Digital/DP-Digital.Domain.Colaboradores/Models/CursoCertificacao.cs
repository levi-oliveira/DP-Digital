using System;

namespace DP_Digital.Domain.Colaboradores.Models
{
    public class CursoCertificacao
    {
        public string NomeDoCurso { get; set; }
        public string Entidade { get; set; }
        public DateTime DataInicio { get; set; }
        public DateTime DataFim { get; set; }
        public bool Concluido { get; set; }
    }

}
