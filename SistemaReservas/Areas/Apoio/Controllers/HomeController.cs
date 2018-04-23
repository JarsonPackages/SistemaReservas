using SistemaReservas.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SistemaReservas.Areas.Apoio.Controllers
{

    public class HomeController : Controller
    {
        List<Recurso> GetRecursoAll = new List<Recurso>()
        {
            new Recurso()
            {
                ID = 1,
                Disponivel = "Sim",
                Nome ="DataShow",
                Descricao="720p - VGA",
                ID_Tipo = 32,
                Marca = "Samsung",
                Modelo ="Epson",
                Quantidade = 3
            },
             new Recurso()
            {
                ID = 1,
                Disponivel = "Nao",
                Nome ="Caixa de Som",
                Descricao="Graves++",
                ID_Tipo =34,
                Marca = "JBL",
                Modelo ="Plus",
                Quantidade = 4
            },
              new Recurso()
            {
                ID = 1,
                Disponivel = "Sim",
                Nome ="DataShow",
                Descricao="720p - VGA",
                ID_Tipo = 32,
                Marca = "Samsung",
                Modelo ="Epson",
                Quantidade = 1
            },
               new Recurso()
            {
                ID = 1,
                Disponivel = "Sim",
                Nome ="DataShow",
                Descricao="720p - VGA",
                ID_Tipo = 32,
                Marca = "Samsung",
                Modelo ="Epson",
                Quantidade = 1
            },
                new Recurso()
            {
                ID = 1,
                Disponivel = "Sim",
                Nome ="DataShow",
                Descricao="720p - VGA",
                ID_Tipo = 32,
                Marca = "Samsung",
                Modelo ="Epson",
                Quantidade = 3
            },
             new Recurso()
            {
                ID = 1,
                Disponivel = "Nao",
                Nome ="Caixa de Som",
                Descricao="Graves++",
                ID_Tipo =34,
                Marca = "JBL",
                Modelo ="Plus",
                Quantidade = 4
            },
              new Recurso()
            {
                ID = 1,
                Disponivel = "Sim",
                Nome ="DataShow",
                Descricao="720p - VGA",
                ID_Tipo = 32,
                Marca = "Samsung",
                Modelo ="Epson",
                Quantidade = 1
            },
               new Recurso()
            {
                ID = 1,
                Disponivel = "Sim",
                Nome ="DataShow",
                Descricao="720p - VGA",
                ID_Tipo = 32,
                Marca = "Samsung",
                Modelo ="Epson",
                Quantidade = 1
            }
        };
        // GET: Apoio/Home
        public ActionResult Equipamentos()
        {
            return View(GetRecursoAll);
        }
        List<Reserva> GetReservaAll = new List<Reserva>()
        {
         new Reserva{ID=1,DataInicial=DateTime.Now, DataFinal= DateTime.MaxValue , HoraFinal= DateTime.Today,HoraInicial= DateTime.Now ,ID_Usuario = 2},
           new Reserva{ID=2,DataInicial=DateTime.Now, DataFinal= DateTime.MaxValue , HoraFinal= DateTime.Today,HoraInicial= DateTime.Now ,ID_Usuario = 2},
             new Reserva{ID=3,DataInicial=DateTime.Now, DataFinal= DateTime.MaxValue , HoraFinal= DateTime.Today,HoraInicial= DateTime.Now ,ID_Usuario = 2},
               new Reserva{ID=4,DataInicial=DateTime.Now, DataFinal= DateTime.MaxValue , HoraFinal= DateTime.Today,HoraInicial= DateTime.Now ,ID_Usuario = 2},
                 new Reserva{ID=5,DataInicial=DateTime.Now, DataFinal= DateTime.MaxValue , HoraFinal= DateTime.Today,HoraInicial= DateTime.Now ,ID_Usuario = 2},
                   new Reserva{ID=6,DataInicial=DateTime.Now, DataFinal= DateTime.MaxValue , HoraFinal= DateTime.Today,HoraInicial= DateTime.Now ,ID_Usuario = 2},
                     new Reserva{ID=7,DataInicial=DateTime.Now, DataFinal= DateTime.MaxValue , HoraFinal= DateTime.Today,HoraInicial= DateTime.Now ,ID_Usuario = 2},
                       new Reserva{ID=8,DataInicial=DateTime.Now, DataFinal= DateTime.MaxValue , HoraFinal= DateTime.Today,HoraInicial= DateTime.Now ,ID_Usuario = 2},
                         new Reserva{ID=9,DataInicial=DateTime.Now, DataFinal= DateTime.MaxValue , HoraFinal= DateTime.Today,HoraInicial= DateTime.Now ,ID_Usuario = 2}
        };
        public ActionResult Reservas()
        {
            return View(GetReservaAll);
        }

        public ActionResult DetalhesReservas(int id)
        {
            Reserva get = new Reserva();
            foreach (Reserva r in GetReservaAll)
            {
                if (r.ID == id)
                {
                    get = r;
                }
            }
            return View(get);
        }
        public ActionResult NovoRecurso()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult NovoRecurso(Recurso _recurso )
        {
            return RedirectToAction("Reservas");
        }
    }

}
