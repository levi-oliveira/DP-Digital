using System;

namespace TemplateMaterialDesignAdmin.Models.Colaborador
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