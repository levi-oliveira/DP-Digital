using System;
using TemplateMaterialDesignAdmin.Enums.Colaborador;

namespace TemplateMaterialDesignAdmin.Models.Colaborador
{
    public class Dependentes
    {
        public string NomeCompleto { get; set; }
        public ESexo Sexo { get; set; }
        public EGrauDeParentesco GrauDeParentesco { get; set; }
        public DateTime DataNascimento { get; set; }
    }
}