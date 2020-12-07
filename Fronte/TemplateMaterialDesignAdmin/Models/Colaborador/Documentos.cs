using TemplateMaterialDesignAdmin.Enums.Colaborador;

namespace TemplateMaterialDesignAdmin.Models.Colaborador
{
    public class Documentos
    {
        public ETipoDeSubItem TipoDeSubItem { get; set; }
        public ETipoArquivo TipoArquivo { get; set; }
        public string ArquivoBase64 { get; set; }
    }
}