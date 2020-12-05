using DP_Digital.Domain.Candidatos.Models.Candidatos;
using Flunt.Notifications;
using System;
using System.Collections.Generic;
using System.Text;

namespace DP_Digital.Domain.Candidatos.Commands.Candidatos.Request
{
    public class InserirCommand : Notifiable
    {
        public string Nome { get; set; }
        public string Imagem { get; set; }
        public string Titulo { get; set; }
        public string CurriculoBase64 { get; set; }
        public List<TrajetoriaProfissional> TrajetorioProfissionais { get; set; }
        public List<Certificado> Certificados { get; set; }

        public bool ValidarCampos()
        {

            if (string.IsNullOrEmpty(Nome))
                AddNotification("Candidato", "O campo Nome é obrigatório");

            if (string.IsNullOrEmpty(Imagem))
                AddNotification("Candidato", "O campo Nome é obrigatório");

            if (string.IsNullOrEmpty(Titulo))
                AddNotification("Candidato", "O campo Nome é obrigatório");

            foreach (var item in TrajetorioProfissionais)
            {
                if (string.IsNullOrEmpty(item.Descricao))
                    AddNotification("Candidato", "O campo Descricao é obrigatório");

                if (string.IsNullOrEmpty(item.Empresa))
                    AddNotification("Candidato", "O campo Descricao é obrigatório");

                if (item.Imagens.Count == 0)
                    AddNotification("Candidato", "Lista de imagens não pode ser vazia");
            }

            return Valid;
        }
    }
}
