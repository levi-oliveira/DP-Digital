using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Linq;

namespace TemplateMaterialDesignAdmin.Helpers
{
    /// <summary>Helper que auxilia na utilização SelectLists preenchidos através de Enums.</summary>
    public static class EnumToSelectListHelper<TEnum> where TEnum : Enum
    {
        /// <summary>Preenche SelectList através do conteúdo de um Enum.</summary>
        /// <returns>SelectList preenchido com o conteúdo do Enum.</returns>
        /// <exception cref="Exception">Erro ao preencher o SelectList.</exception>
        public static SelectList ParseEnumToSelectList()
        {
            try
            {
                SelectList genericSelectList = new SelectList(Enum.GetValues(typeof(TEnum)).Cast<TEnum>().Select(e => new SelectListItem
                {
                    Value = Convert.ToInt32(e).ToString(),
                    Text = EnumHelper.ObterDescricao(e)
                }).ToList(), "Value", "Text");

                return genericSelectList;
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        /// <summary>Preenche SelectList através do conteúdo de um Enum, e configura qual será o SelectedValue.</summary>
        /// <param name="selectedValue">Indice de qual item do SelectList será o SelectedValue.</param>
        /// <returns>SelectList preenchido com o conteúdo do Enum.</returns>
        /// <exception cref="Exception">Erro ao preencher o SelectList.</exception>
        public static SelectList ParseEnumToSelectList(int selectedValue)
        {
            try
            {
                SelectList genericSelectList = new SelectList(Enum.GetValues(typeof(TEnum)).Cast<TEnum>().Select(e => new SelectListItem
                {
                    Value = Convert.ToInt32(e).ToString(),
                    Text = EnumHelper.ObterDescricao(e)
                }).ToList(), "Value", "Text", selectedValue);

                return genericSelectList;
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        /// <summary>Preenche SelectList através do conteúdo de um Enum, e configura qual será o SelectedValue.</summary>
        /// <param name="selectedValue">Indice de qual item do SelectList será o SelectedValue.</param>
        /// <returns>SelectList preenchido com o conteúdo do Enum.</returns>
        /// <exception cref="Exception">Erro ao preencher o SelectList.</exception>
        public static SelectList ParseEnumToSelectList(uint selectedValue)
        {
            try
            {
                SelectList genericSelectList = new SelectList(Enum.GetValues(typeof(TEnum)).Cast<TEnum>().Select(e => new SelectListItem
                {
                    Value = Convert.ToInt32(e).ToString(),
                    Text = EnumHelper.ObterDescricao(e)
                }).ToList(), "Value", "Text", selectedValue);

                return genericSelectList;
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        /// <summary>Preenche SelectList através do conteúdo de um Enum, e configura qual será o SelectedValue.</summary>
        /// <param name="selectedValue">Indice de qual item do SelectList será o SelectedValue.</param>
        /// <returns>SelectList preenchido com o conteúdo do Enum.</returns>
        /// <exception cref="Exception">Erro ao preencher o SelectList.</exception>
        public static SelectList ParseEnumToSelectList(long selectedValue)
        {
            try
            {
                SelectList genericSelectList = new SelectList(Enum.GetValues(typeof(TEnum)).Cast<TEnum>().Select(e => new SelectListItem
                {
                    Value = Convert.ToInt32(e).ToString(),
                    Text = EnumHelper.ObterDescricao(e)
                }).ToList(), "Value", "Text", selectedValue);

                return genericSelectList;
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        /// <summary>Preenche SelectList através do conteúdo de um Enum, e configura qual será o SelectedValue.</summary>
        /// <param name="selectedValue">Indice de qual item do SelectList será o SelectedValue.</param>
        /// <returns>SelectList preenchido com o conteúdo do Enum.</returns>
        /// <exception cref="Exception">Erro ao preencher o SelectList.</exception>
        public static SelectList ParseEnumToSelectList(ulong selectedValue)
        {
            try
            {
                SelectList genericSelectList = new SelectList(Enum.GetValues(typeof(TEnum)).Cast<TEnum>().Select(e => new SelectListItem
                {
                    Value = Convert.ToInt32(e).ToString(),
                    Text = EnumHelper.ObterDescricao(e)
                }).ToList(), "Value", "Text", selectedValue);

                return genericSelectList;
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        /// <summary>Preenche SelectList através do conteúdo de um Enum, e configura qual será o SelectedValue.</summary>
        /// <param name="selectedValue">Indice de qual item do SelectList será o SelectedValue.</param>
        /// <returns>SelectList preenchido com o conteúdo do Enum.</returns>
        /// <exception cref="Exception">Erro ao preencher o SelectList.</exception>
        public static SelectList ParseEnumToSelectList(float selectedValue)
        {
            try
            {
                SelectList genericSelectList = new SelectList(Enum.GetValues(typeof(TEnum)).Cast<TEnum>().Select(e => new SelectListItem
                {
                    Value = Convert.ToInt32(e).ToString(),
                    Text = EnumHelper.ObterDescricao(e)
                }).ToList(), "Value", "Text", selectedValue);

                return genericSelectList;
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        /// <summary>Preenche SelectList através do conteúdo de um Enum, e configura qual será o SelectedValue.</summary>
        /// <param name="selectedValue">Indice de qual item do SelectList será o SelectedValue.</param>
        /// <returns>SelectList preenchido com o conteúdo do Enum.</returns>
        /// <exception cref="Exception">Erro ao preencher o SelectList.</exception>
        public static SelectList ParseEnumToSelectList(double selectedValue)
        {
            try
            {
                SelectList genericSelectList = new SelectList(Enum.GetValues(typeof(TEnum)).Cast<TEnum>().Select(e => new SelectListItem
                {
                    Value = Convert.ToInt32(e).ToString(),
                    Text = EnumHelper.ObterDescricao(e)
                }).ToList(), "Value", "Text", selectedValue);

                return genericSelectList;
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        /// <summary>Preenche SelectList através do conteúdo de um Enum, e configura qual será o SelectedValue.</summary>
        /// <param name="selectedValue">Indice de qual item do SelectList será o SelectedValue.</param>
        /// <returns>SelectList preenchido com o conteúdo do Enum.</returns>
        /// <exception cref="Exception">Erro ao preencher o SelectList.</exception>
        public static SelectList ParseEnumToSelectList(decimal selectedValue)
        {
            try
            {
                SelectList genericSelectList = new SelectList(Enum.GetValues(typeof(TEnum)).Cast<TEnum>().Select(e => new SelectListItem
                {
                    Value = Convert.ToInt32(e).ToString(),
                    Text = EnumHelper.ObterDescricao(e)
                }).ToList(), "Value", "Text", selectedValue);

                return genericSelectList;
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        /// <summary>Preenche SelectList através do conteúdo de um Enum, e configura qual será o SelectedValue.</summary>
        /// <param name="selectedValue">Indice de qual item do SelectList será o SelectedValue.</param>
        /// <returns>SelectList preenchido com o conteúdo do Enum.</returns>
        /// <exception cref="Exception">Erro ao preencher o SelectList.</exception>
        public static SelectList ParseEnumToSelectList(Guid selectedValue)
        {
            try
            {
                SelectList genericSelectList = new SelectList(Enum.GetValues(typeof(TEnum)).Cast<TEnum>().Select(e => new SelectListItem
                {
                    Value = Convert.ToInt32(e).ToString(),
                    Text = EnumHelper.ObterDescricao(e)
                }).ToList(), "Value", "Text", selectedValue);

                return genericSelectList;
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        /// <summary>Preenche SelectList através do conteúdo de um Enum, e configura qual será o SelectedValue.</summary>
        /// <param name="selectedValue">Indice de qual item do SelectList será o SelectedValue.</param>
        /// <returns>SelectList preenchido com o conteúdo do Enum.</returns>
        /// <exception cref="Exception">Erro ao preencher o SelectList.</exception>
        public static SelectList ParseEnumToSelectList(char selectedValue)
        {
            try
            {
                SelectList genericSelectList = new SelectList(Enum.GetValues(typeof(TEnum)).Cast<TEnum>().Select(e => new SelectListItem
                {
                    Value = Convert.ToInt32(e).ToString(),
                    Text = EnumHelper.ObterDescricao(e)
                }).ToList(), "Value", "Text", selectedValue);

                return genericSelectList;
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        /// <summary>Preenche SelectList através do conteúdo de um Enum, e configura qual será o SelectedValue.</summary>
        /// <param name="selectedValue">Indice de qual item do SelectList será o SelectedValue.</param>
        /// <returns>SelectList preenchido com o conteúdo do Enum.</returns>
        /// <exception cref="Exception">Erro ao preencher o SelectList.</exception>
        public static SelectList ParseEnumToSelectList(string selectedValue)
        {
            try
            {
                SelectList genericSelectList = new SelectList(Enum.GetValues(typeof(TEnum)).Cast<TEnum>().Select(e => new SelectListItem
                {
                    Value = Convert.ToInt32(e).ToString(),
                    Text = EnumHelper.ObterDescricao(e)
                }).ToList(), "Value", "Text", selectedValue);

                return genericSelectList;
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        /// <summary>Preenche SelectList através do conteúdo de um Enum, e configura qual será o SelectedValue.</summary>
        /// <param name="selectedValue">Indice de qual item do SelectList será o SelectedValue.</param>
        /// <returns>SelectList preenchido com o conteúdo do Enum.</returns>
        /// <exception cref="Exception">Erro ao preencher o SelectList.</exception>
        public static SelectList ParseEnumToSelectList(bool selectedValue)
        {
            try
            {
                SelectList genericSelectList = new SelectList(Enum.GetValues(typeof(TEnum)).Cast<TEnum>().Select(e => new SelectListItem
                {
                    Value = Convert.ToInt32(e).ToString(),
                    Text = EnumHelper.ObterDescricao(e)
                }).ToList(), "Value", "Text", selectedValue);

                return genericSelectList;
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }
    }
}