using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Miceli.Datos
{
    public class Alumno : DataBaseConnection
    {
        public List<Miceli.Entidades.Alumno> RecuperarTodos()
        {
            List<Miceli.Entidades.Alumno> alumnos = new List<Miceli.Entidades.Alumno>();
            
            string query = "select Dni,ApellidoNombre,Email,FechaNacimiento,NotaPromedio from Alumnos";


            using (this.connection)
            {

                SqlCommand command = new SqlCommand(query,connection);
                try
                {
                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();
                    while(reader.Read())
                    {
                        Miceli.Entidades.Alumno alumno = new Miceli.Entidades.Alumno(
                            reader.GetString(0),
                            reader.GetString(1),
                            reader.GetString(2),
                            reader.GetDateTime(3),
                            reader.GetDecimal(4)
                            );

                        alumnos.Add(alumno);
                    }
                    reader.Close();
                    connection.Close();
                }
                catch (Exception e)
                {
                    throw new Exception("Error en la consulta a la DB");
                }
            }

                return alumnos;
        }

        public void Agregar(Miceli.Entidades.Alumno alumno)
        {
            string query = "insert into Alumnos (Dni,ApellidoNombre,Email,FechaNacimiento,NotaPromedio) " +
                "values(@Dni, @ApellidoNombre, @Email, @FechaNacimiento, @NotaPromedio)";

            using(this.connection)
            {
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@Dni", alumno.Dni);
                command.Parameters.AddWithValue("@ApellidoNombre", alumno.ApellidoNombre);
                command.Parameters.AddWithValue("@Email", alumno.Email);
                command.Parameters.AddWithValue("@FechaNacimiento", alumno.FechaNacimiento);
                command.Parameters.AddWithValue("@NotaPromedio", alumno.NotaPromedio);

                try
                {
                    connection.Open();
                    command.ExecuteNonQuery();
                    connection.Close();
                } catch (Exception e)
                {
                    throw new Exception("Error al crear nuevo alumno.");
                }
   
            }
        }

        public Entidades.Alumno RecuperarUno(string Dni)
        {
            if(Dni == null || Dni == string.Empty)
            {
                throw new Exception("Ingrese nº de DNI");
            }

         
             List<Miceli.Entidades.Alumno> alumnos = this.RecuperarTodos();
             Miceli.Entidades.Alumno alumno = alumnos.Where(alu => alu.Dni == Dni).FirstOrDefault();
            
            if(alumno == null)
            {
                alumno = new Miceli.Entidades.Alumno();
            }
             
            return alumno;
        }
    }
}
