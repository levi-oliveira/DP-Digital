using Flunt.Notifications;
using System;
using System.Collections.Generic;
using System.Text;

namespace DP_Digital.Domain.Candidatos.Commands
{
    public class CommandResult
    {
        public CommandResult(string mensagem, object data)
        {
            Sucesso = true;
            Data = data;
            Mensagem = mensagem;
        }

        public CommandResult(string mensagem, IReadOnlyCollection<Notification> erros)
        {
            Sucesso = false;
            Erros = erros;
            Mensagem = mensagem;
        }

        public bool Sucesso { get; set; }
        public string Mensagem { get; set; }

        public object Data { get; set; }
        public IReadOnlyCollection<Notification> Erros { get; set; }
    }
}
