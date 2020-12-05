using System.ComponentModel;

namespace DP_Digital.Domain.Colaboradores.Enum
{
    public enum EEstadoCivil
    {
        [Description("Casado(a)")]
        Casado = 1,

        [Description("Divorciado(a)")]
        Divorciado = 2,

        [Description("Solteiro")]
        Solteiro = 3,

        [Description("União estável")]
        UniaoEstavel = 4,

        [Description("Viúvo(a)")]
        Viuvo = 5,
    }
}
