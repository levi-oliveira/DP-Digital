using DP_Digital.Domain.Colaboradores.Enum;
using System;

namespace DP_Digital.Domain.Colaboradores.Models
{
    public class Dependentes
    {
        public string NomeCompleto { get; set; }
        public ESexo Sexo { get; set; }
        public EGrauDeParentesco GrauDeParentesco { get; set; }
        public DateTime DataNascimento { get; set; }
    }
}
