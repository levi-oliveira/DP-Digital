using System.ComponentModel;

namespace TemplateMaterialDesignAdmin.Enums.Colaborador
{
    public enum EGrauDeInstrucao
    {
        [Description("Analfabeto")]
        Analfabeto = 1,

        [Description("1º ao 5º Ano incompleto")]
        _1ao5AnoIncompleto = 2,

        [Description("1º ao 5º Ano completo")]
        _1ao5AnoCompleto = 3,

        [Description("6º ao 9º Ano incompleto")]
        _6ao9AnoIncompleto = 4,

        [Description("6º ao 9º Ano completo")]
        _6ao9AnoCompleto = 5,

        [Description("2º grau incompleto")]
        _2GrauIncompleto = 6,

        [Description("2º grau completo")]
        _2GrauCompleto = 7,

        [Description("Pós-Graduação incompleto")]
        PosGraduaçãoIncompleto = 8,

        [Description("Pós-Graduação completo")]
        PosGraduaçãoCompleto = 9,

        [Description("Mestrado")]
        Mestrado = 10,

        [Description("Doutorado")]
        Doutorado = 11
    }
}