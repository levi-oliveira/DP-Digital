using System;
using System.Collections.Generic;
using TemplateMaterialDesignAdmin.Enums.Colaborador;

namespace TemplateMaterialDesignAdmin.Models.Colaborador
{
    public class Colaborador : Pessoa
    {
        public Colaborador() => Id = Guid.NewGuid();

        public Colaborador(Guid id) => Id = id;

        public Guid Id { get; private set; }
        public EEstadoCivil EstadoCivil { get; set; }
        public ENacionalidade Nacionalidade { get; set; }
        public bool Naturalizacao { get; set; }
        public bool ResideNoBrasil { get; set; }
        public string UFNaturalidade { get; set; }
        public string CidadeNaturalidade { get; set; }
        public string NomeDaMae { get; set; }
        public string NomeDoPai { get; set; }
        public string NomeConjuge { get; set; }
        public bool PossuiDependente { get; set; }
        public bool PossuiDeficiencia { get; set; }
        public string CPF { get; set; }
        public string Identidade { get; set; }
        public DateTime DataDeEmissao { get; set; }
        public string OrgaoEmissor { get; set; }
        public string NumeroPIS { get; set; }

        public List<Dependentes> ListaDeDependentes { get; set; }
        public List<Documentos> ListaDeDocumentos { get; set; }
    }
}