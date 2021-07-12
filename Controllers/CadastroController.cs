using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Threading.Tasks;
using System.Web.Mvc;
using Edesoft.Repositorio;
using Edesoft.Models;


namespace Edesoft.Controllers
{
    public class CadastroController : Controller
    {



        /// <summary>
        /// 
        /// </summary>
        /// <returns>Cadastro de Cliente</returns>
        public ActionResult CadastrarCliente()
        {
            return View();

        }


        [HttpPost]
        public ActionResult CadastrarCliente(Cliente CadastroCliente)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    var Cadastro = new Crud();

                

                    if (Cadastro.CadastrarCliente(CadastroCliente))
                    {

                        ViewBag.Message = "Cadastrado com sucesso";
                    }
                }


                return RedirectToAction("CadastrarDivida");
            }
            catch
            {
                return View();
            }

        }


        public ActionResult Busca(string Filtro)
        {
            try
            {

                var SelecionaCliente = new Crud();

                return View(SelecionaCliente.SelecionarPorId(Filtro));


            }
            catch
            {
                return View();
            }
        }




    }
}