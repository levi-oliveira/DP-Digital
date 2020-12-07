using System;

namespace TemplateMaterialDesignAdmin.Models.Colaborador
{
    public class EmpregoAnterior
    {
        public string Empresa { get; set; }
        public string Cidade { get; set; }
        public string Cargo { get; set; }
        public decimal Salario { get; set; }
        public DateTime DataAdmissao { get; set; }
        public DateTime DataDesligamento { get; set; }
        public string DescricaoAtividades { get; set; }
    }
}