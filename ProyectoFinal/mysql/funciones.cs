using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace ProyectoFinal.mysql
{
    class funciones
    {
        public static int agregar(contacto add)
        {
            int retorno = 0;
            MySqlCommand comando = new MySqlCommand(String.Format("insert into agenda(nombre,apellidos,numero)values ('{0}','{1}','{2}')",add.nombre,add.apellidos,add.numero),conexion.obtenerConexion());
            retorno = comando.ExecuteNonQuery();
            return retorno;
        }
        public static List<contacto> mostrar()
        {
            List<contacto> lista = new List<contacto>();
            MySqlCommand comando = new MySqlCommand(String.Format("select * from agenda"),conexion.obtenerConexion());
            MySqlDataReader reader = comando.ExecuteReader();
            
            while (reader.Read())
            {
                contacto a = new contacto();
                a.id = reader.GetInt32(0);
                a.nombre = reader.GetString(1);
                a.apellidos = reader.GetString(2);
                a.numero = reader.GetString(3);
                lista.Add(a);
            }
            return lista;
        }
        public static List<contacto> buscar(string nombre,string apellidos)
        {
            List<contacto> listaBuscar = new List<contacto>();
            MySqlCommand comando = new MySqlCommand(String.Format("select * from agenda where nombre='{0}' or apellidos= '{1}'", nombre, apellidos),conexion.obtenerConexion());
            MySqlDataReader reader = comando.ExecuteReader();
            while (reader.Read())
            {
                contacto a = new contacto();
                a.id=reader.GetInt32(0);
                a.nombre=reader.GetString(1);
                a.apellidos=reader.GetString(2);
                a.numero=reader.GetString(3);
                listaBuscar.Add(a);
            }
            return listaBuscar;
        }
        public static contacto obtenerContacto(int id)
        {
            contacto a = new contacto();
            MySqlCommand comando = new MySqlCommand(String.Format("select * from agenda where id='{0}'",id),conexion.obtenerConexion());  
            MySqlDataReader read = comando.ExecuteReader();
            while(read.Read()){
                a.id=read.GetInt32(0);
                a.nombre = read.GetString(1);
                a.apellidos = read.GetString(2);
                a.numero = read.GetString(3);
            }
            return a;
        }
        public static int eliminar(int id)
        {
            MySqlCommand comando = new MySqlCommand(String.Format("delete from agenda where id='{0}'",id),conexion.obtenerConexion());
            int eliminado = comando.ExecuteNonQuery();
            return eliminado;
        }
    }
}
