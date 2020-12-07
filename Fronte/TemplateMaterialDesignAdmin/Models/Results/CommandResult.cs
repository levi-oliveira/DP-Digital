using Flunt.Notifications;
using System.Collections.Generic;

namespace TemplateMaterialDesignAdmin.Models.Results
{
    public class CommandResult
    {
        public bool Sucesso { get; set; }
        public string Mensagem { get; set; }
        public object Data { get; set; }
        public IReadOnlyCollection<Notification> Erros { get; set; }
    }
}