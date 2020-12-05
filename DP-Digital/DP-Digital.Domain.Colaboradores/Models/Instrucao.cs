using System;

namespace DP_Digital.Domain.Colaboradores.Models
{
    public class Instrucao
    {
        public string FormacaoAcademica { get; set; }
        public string Titulacao { get; set; }
        public string Entidade { get; set; }
        public DateTime DataDeConclusao { get; set; }
        public bool Concluido { get; set; }
    }

}
