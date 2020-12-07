using System.Collections.Generic;

namespace TemplateMaterialDesignAdmin.Helpers.Models
{
    /// <summary>Model que auxilia a reunir informações para Headers que serão enviados para API's.</summary>
    public class ApiHeadersModel
    {
        /// <value>Chave do Header.</value>
        public string Chave { get; set; }

        /// <value>Valor do Header.</value>
        public string Valor { get; set; }

        /// <value>Valores do Header.</value>
        public IEnumerable<string> Valores { get; set; }
    }
}