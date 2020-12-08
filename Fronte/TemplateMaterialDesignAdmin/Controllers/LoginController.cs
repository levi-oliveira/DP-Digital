using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using TemplateMaterialDesignAdmin.Models.Candidato;
using TemplateMaterialDesignAdmin.Models.Candidato.Commands;
using TemplateMaterialDesignAdmin.Services.Interfaces;

namespace TemplateMaterialDesignAdmin.Controllers
{
    public class LoginController : Controller
    {
        private readonly ICandidatoService _candidatoService;

        public LoginController(ICandidatoService candidatoService)
        {
            _candidatoService = candidatoService;
        }


        // GET: LoginController
        public ActionResult Index()
        {
            List<Certificado> certificados = new List<Certificado>();
            certificados.Add(new Certificado() { Nome = "Entity Framework Core", DadosBase64 = "Certificado DadosBase64 - Entity Framework Core" });
            certificados.Add(new Certificado() { Nome = "Dapper", DadosBase64 = "Certificado DadosBase64 - Dapper" });

            List<Imagem> imagensT1 = new List<Imagem>();
            imagensT1.Add(new Imagem() { Nome = "Entity Framework Core", DadosBase64 = "Imgem DadosBase64 - Entity Framework Core" });
            imagensT1.Add(new Imagem() { Nome = "Dapper", DadosBase64 = "Imagem DadosBase64 - Dapper" });

            List<Imagem> imagensT2 = new List<Imagem>();
            imagensT2.Add(new Imagem() { Nome = "Angular", DadosBase64 = "Imgem DadosBase64 - Angular" });
            imagensT2.Add(new Imagem() { Nome = "Vue.js", DadosBase64 = "Imagem DadosBase64 - Vue.js" });

            List<TrajetoriaProfissional> trajetoriasProfissional = new List<TrajetoriaProfissional>();
            trajetoriasProfissional.Add(
                new TrajetoriaProfissional()
                {
                    Empresa = "Google",
                    DataInicio = DateTime.Now.AddYears(-5),
                    DataFim = DateTime.Now.AddYears(-3),
                    Descricao = "Desenvolvedor Backend",
                    Imagens = imagensT1
                }
            );
            trajetoriasProfissional.Add(
                new TrajetoriaProfissional()
                {
                    Empresa = "Facebook",
                    DataInicio = DateTime.Now.AddYears(-2),
                    DataFim = DateTime.Now.AddDays(-15),
                    Descricao = "Desenvolvedor Frontend",
                    Imagens = imagensT2
                }
            );

            CandidatoInserirCommand candidatoInserirCommand = new CandidatoInserirCommand() 
            { 
                Nome = "Lucas",
                Imagem = "Imagem de perfil DadosBase64",
                Titulo = "Desenvolvedor .Net Pleno",
                CurriculoBase64 = "Curriculo sem padão DadosBase64",
                TrajetorioProfissionais = trajetoriasProfissional,
                Certificados = certificados
            };

            var retorno = _candidatoService.Inserir(candidatoInserirCommand);

            return View();
        }

        // POST: LoginController/Login
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Login(IFormCollection collection)
        {
            try
            {
                return RedirectToAction("Index", "Home");
            }
            catch
            {
                return View();
            }
        }

        // GET: LoginController/Logout
        public ActionResult Logout()
        {
            return RedirectToAction("Index", "Login");
        }

        // GET: LoginController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: LoginController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: LoginController/EsqueciSenha
        public ActionResult EsqueciSenha()
        {
            return View();
        }

        // POST: LoginController/EsqueciSenha
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult EsqueciSenha(IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}