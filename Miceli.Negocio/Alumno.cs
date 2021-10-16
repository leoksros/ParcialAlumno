using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Miceli.Negocio
{
    public class Alumno 
    {
        public static List<Miceli.Entidades.Alumno> RecuperarTodos()
        {
            Miceli.Datos.Alumno alumnos = new Miceli.Datos.Alumno();
            return alumnos.RecuperarTodos();
        }
    }
}
