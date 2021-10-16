using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;


namespace Miceli.Web.Controllers
{
    public class UsuarioController : Controller
    {
        public Miceli.Negocio.Alumno AlumnoNegocio { get; set; }
        public Miceli.Datos.Alumno AlumnoDatos { get; set; }
        public UsuarioController()
        {
            AlumnoNegocio = new Miceli.Negocio.Alumno();
            AlumnoDatos = new Miceli.Datos.Alumno();
        }

        // GET: Usuario

        public ActionResult Usuario()
        {
            Miceli.Entidades.Alumno alumno = new Miceli.Entidades.Alumno();
            return View(alumno);
        }

        [HttpPost]
        public ActionResult Usuario(string dni)
        {

            Miceli.Entidades.Alumno alumno = new Miceli.Entidades.Alumno();

            if (String.IsNullOrEmpty(dni))
            {
                ViewBag.ErrorMessage = "DNI vacío";
                return View(alumno);
            }

            alumno = AlumnoDatos.RecuperarUno(dni);
            return View(alumno);
        }

        public ActionResult Lista()
        {
            List<Miceli.Entidades.Alumno> alumnos = new List<Miceli.Entidades.Alumno>();
            alumnos = Miceli.Negocio.Alumno.RecuperarTodos();
            return View(alumnos);
        }
    }
}