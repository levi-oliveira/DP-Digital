using System.ComponentModel;

namespace DP_Digital.Domain.Colaboradores.Enum
{
    public enum ETipoDeSubItem
    {
        [Description("Documento próprio")]
        DocumentoProprio = 1,

        [Description("Documento dependente")]
        DocumentoDependente = 2,
    }
}
