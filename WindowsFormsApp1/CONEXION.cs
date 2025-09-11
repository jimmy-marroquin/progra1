using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;// esta libreria me permite usar comando para trabajar con base de datos
using System.Data.SqlClient;// esta libreria me permite trabajar  con  SQL server
namespace WindowsFormsApp1
{
    internal class CONEXION
    {
     //definir los miembros de la clase ,atributos y metodos,
     SqlConnection objConexion = new SqlConnection(); //conectarme a la base de datos 
        SqlCommand objComando = new SqlCommand();// ejecutar sql en bd lectura,actualizacion ,eliminacion,insercion
        SqlDataAdapter objAdaptador = new SqlDataAdapter(); //un puente entre la bd y la aplicacioon  
}
}
