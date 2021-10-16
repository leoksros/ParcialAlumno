using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Miceli.Datos
{
    public class DataBaseConnection
    {
        public SqlConnection connection { get; set; }
        public string NetGenerica { get; set; }
        public DataBaseConnection()
        {
            this.NetGenerica = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\Leo\\Desktop\\Parciales\\Net.DB.Alumno.mdf;Integrated Security=True;Connect Timeout=30";
            this.connection = new SqlConnection(this.NetGenerica);
        }
    }
}
