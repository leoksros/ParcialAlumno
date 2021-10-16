using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Miceli.Escritorio
{
    public partial class Alta : Form
    {
        public Alta()
        {
            InitializeComponent();
        }

        private void buttonCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonGuardar_Click(object sender, EventArgs e)
        {
            this.Guardar();
        }
        public void Guardar()
        {
            string validaciones = null;

            if(!Miceli.Negocio.Validaciones.EsTextBoxValido(this.textNombreApellido.Text.ToString()))
            {
                validaciones = "Nombre y/o apellido \n"; 
            }
            if(!Miceli.Negocio.Validaciones.EsTextBoxValido(this.textDni.Text.ToString()))
            {
                validaciones = validaciones + "DNI \n";
            }
            if (Miceli.Negocio.Validaciones.EsMailValido(this.textEmail.Text.ToString()))
            {
                validaciones = validaciones + "Email \n";
            }
            if(!Miceli.Negocio.Validaciones.EsFechaValida(this.dateTimeFechaNacimiento.Value.Date))
            {
                validaciones = validaciones + "Fecha \n";
            }
            if (!Miceli.Negocio.Validaciones.EsNotaValida(Convert.ToDecimal(this.textNotaPromedio.Text)))
            {
                validaciones = validaciones + "Nota \n";
            }

            if (!String.IsNullOrEmpty(validaciones))
            {
                MessageBox.Show(validaciones,"Revisar");
            } else
            {
                try
                {
                    Miceli.Entidades.Alumno alumno = new Miceli.Entidades.Alumno(
                    this.textNombreApellido.Text.ToString(),
                    this.textDni.Text.ToString(),
                    this.textEmail.Text.ToString(),
                    this.dateTimeFechaNacimiento.Value.Date,
                    Convert.ToDecimal(this.textNotaPromedio.Text)
                    );

                    Miceli.Datos.Alumno db = new Miceli.Datos.Alumno();
                    db.Agregar(alumno);

                    MessageBox.Show("Alumno creado satisfactoriamente");
                }
                catch (Exception e)
                {
                    throw new Exception("Error al crear el alumno");
                }
            }
        }
    }
}
