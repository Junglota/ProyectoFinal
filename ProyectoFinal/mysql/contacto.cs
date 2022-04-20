using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoFinal.mysql
{
    
    public class contacto
    {
        public int id { get; set; }
        public string nombre { get; set; }
        public string apellidos { get; set; }
        public string numero { get; set; }

        public contacto() { }
        public contacto(int id,string nombre,string apellidos,string numero)
        {
            this.id = id;
            this.nombre = nombre;  
            this.apellidos = apellidos;
            this.numero = numero;
        }
    }
}
