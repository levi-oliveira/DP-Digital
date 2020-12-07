using System.Collections.Generic;

namespace TemplateMaterialDesignAdmin.Models.Candidato.Commands
{
    public class CandidatoInserirCommand
    {
        public string Nome { get; set; }
        public string Imagem { get; set; }
        public string Titulo { get; set; }
        public string CurriculoBase64 { get; set; }
        public List<TrajetoriaProfissional> TrajetorioProfissionais { get; set; }
        public List<Certificado> Certificados { get; set; }
    }
}