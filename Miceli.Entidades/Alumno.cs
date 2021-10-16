using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Miceli.Entidades
{
    public class Alumno
    {
        public string ApellidoNombre { get; set; }
        public string Dni { get; set; }
        public string Email { get; set; }
        public DateTime FechaNacimiento { get; set; }
        public decimal NotaPromedio { get; set; }
        public int Edad { 
            get
            {
                DateTime fechaActual = DateTime.Today;
                int edad = fechaActual.Year - this.FechaNacimiento.Year;
                if (fechaActual.Month < this.FechaNacimiento.Month)
                {
                    --edad;
                }
                return edad;
            }
        }

        public Alumno()
        {

        }

        public Alumno(string ApellidoNombre, string Dni, string Email, DateTime FechaNacimiento, decimal NotaPromedio)
        {
            this.ApellidoNombre = ApellidoNombre;
            this.Dni = Dni;
            this.Email = Email;
            this.FechaNacimiento = FechaNacimiento;
            this.NotaPromedio = NotaPromedio;
        }
    }
}
