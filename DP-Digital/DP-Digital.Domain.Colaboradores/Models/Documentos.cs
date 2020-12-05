using DP_Digital.Domain.Colaboradores.Enum;

namespace DP_Digital.Domain.Colaboradores.Models
{
    public class Documentos
    {
        public ETipoDeSubItem TipoDeSubItem { get; set; }
        public ETipoArquivo TipoArquivo { get; set; }

        public string ArquivoBase64 { get; set; }
    }
}
