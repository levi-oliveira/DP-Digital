using System;
using System.Linq;
using System.Reflection;

namespace TemplateMaterialDesignAdmin.Helpers
{
    /// <summary>Helper que auxilia na utilização de Enums.</summary>
    public static class EnumHelper
    {
        /// <summary>Obtem descrição do valor de um Enum.</summary>
        /// <param name="enumValor">Valor do Enum que se deseja obter a descrição.</param>
        /// <returns>Descrição do valor do Enum.</returns>
        /// <exception cref="Exception">Erro ao obter a descrição do valor do Enum.</exception>
        public static string ObterDescricao(this Enum enumValor)
        {
            try
            {
                Type genericEnumType = enumValor.GetType();
                MemberInfo[] memberInfo = genericEnumType.GetMember(enumValor.ToString());
                if ((memberInfo != null && memberInfo.Length > 0))
                {
                    var _Attribs = memberInfo[0].GetCustomAttributes(typeof(System.ComponentModel.DescriptionAttribute), false);
                    if ((_Attribs != null && _Attribs.Count() > 0))
                    {
                        return ((System.ComponentModel.DescriptionAttribute)_Attribs.ElementAt(0)).Description;
                    }
                }
                return enumValor.ToString();
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        /// <summary>Obtem nome do valor de um Enum.</summary>
        /// <param name="enumValor">Valor do Enum que se deseja obter o nome.</param>
        /// <returns>Nome do valor do Enum.</returns>
        /// <exception cref="Exception">Erro ao obter o nome do valor do Enum.</exception>
        public static string ObterNome<TEnum>(object enumValor)
        {
            try
            {
                return Enum.GetName(typeof(TEnum), enumValor);
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        /// <summary>Valida o valor de um Enum existe.</summary>
        /// <param name="enumValor">Valor do Enum que se deseja validar.</param>
        /// <returns>True se for válido e False se for inválido.</returns>
        /// <exception cref="Exception">Erro ao validar o valor do Enum.</exception>
        public static bool ValorEhValido<TEnum>(int enumValor)
        {
            try
            {
                return Enum.IsDefined(typeof(TEnum), enumValor);
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }
    }
}