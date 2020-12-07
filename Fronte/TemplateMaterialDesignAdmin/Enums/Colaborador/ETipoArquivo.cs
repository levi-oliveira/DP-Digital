using System.ComponentModel;

namespace TemplateMaterialDesignAdmin.Enums.Colaborador
{
    public enum ETipoArquivo
    {
        [Description("CPF")]
        CPF = 1,

        [Description("CTPS")]
        CTPS = 2,

        [Description("Cursos/Certificados")]
        CursosCertificados = 3,

        [Description("Documento de identidade")]
        Identidade = 4,

        [Description("Foto")]
        Foto = 5,

        [Description("Instrução/Formação escolar")]
        InstruçãoFormacaoEscolar = 6,

        [Description("PIS")]
        PIS = 7
    }
}