using DP_Digital.Domain.Colaboradores.Enum;
using System;
using System.Collections.Generic;
using System.Text;

namespace DP_Digital.Domain.Colaboradores.Models
{
    public class Pessoa
    {
        public string NomeCompleto { get; set; }
        public ESexo Sexo { get; set; }
        public string NomeSocial { get; set; }
        public EGrauDeInstrucao GrauDeInstrucao { get; set; }
        public DateTime DataNascimento { get; set; }
        public string Email { get; set; }
        public string LinkedIn { get; set; }
        public int DDD { get; set; }
        public string TelefoneCelular { get; set; }
        public int DDDTelefoneRecado { get; set; }
        public string TelefoneRecado { get; set; }
        public string NomeParaContatoRecado { get; set; }
        public EPaisResidencia PaisResidencia { get; set; }
        public string CEP { get; set; }
        public string Endereco { get; set; }
        public int Numero { get; set; }
        public string Complemento { get; set; }
        public string Bairro { get; set; }
        public string UF { get; set; }
        public string Cidade { get; set; }
        public EComoConheceuEmpresa ComoConheceuEmpresa { get; set; }
        public List<Instrucao> ListaDeInstrucao { get; set; }
        public List<CursoCertificacao> ListaDeCursoCertificacao { get; set; }
        public List<Idiomas> ListaDeIdiomas { get; set; }
        public string Apresentacao { get; set; }
        public ECargoPretendido CargoPretendido { get; set; }
        public decimal Salario { get; set; }
        public List<EmpregoAnterior> ListaDeEmpregoAnterior { get; set; }
    }
}
