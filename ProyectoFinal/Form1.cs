using ProyectoFinal.mysql;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace ProyectoFinal
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public contacto contactoActual { get; set; }
        private void Conectar_Click(object sender, EventArgs e)
        {
            conexion.obtenerConexion();
            MessageBox.Show("Conectado");
        }

        private void agregar_Enter(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            

        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            Mostrar m = new Mostrar();
            this.Hide();
            m.ShowDialog();
            if (m.contactoSeleccionado != null)
            {
                contactoActual = m.contactoSeleccionado;
                textNombre.Text = contactoActual.nombre;
                textApellido.Text = contactoActual.apellidos;
                textNumero.Text = contactoActual.numero;
                btnEliminar.Enabled = true;
            }
            this.Show();
        }

        private void bntBuscar_Click(object sender, EventArgs e)
        {
            this.Hide();
            buscar b = new buscar();
            b.ShowDialog();
            if (b.contactoSeleccionado!=null)
            {
                contactoActual = b.contactoSeleccionado;
                textNombre.Text = contactoActual.nombre;
                textApellido.Text = contactoActual.apellidos;
                textNumero.Text = contactoActual.numero;
                btnEliminar.Enabled = true;
            }
            this.Show();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            contacto agregar = new contacto();

            agregar.nombre = textNombre.Text;
            agregar.apellidos = textApellido.Text;
            agregar.numero = textNumero.Text;
            int retorno = funciones.agregar(agregar);
            if (retorno > 0)
            {
                MessageBox.Show("Agregado Con Exito");
            }
            else
            {
                MessageBox.Show("Ha ocurrido un error al agregar");
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            int eliminado = funciones.eliminar(contactoActual.id);
            if (eliminado > 0)
            {
                MessageBox.Show("Se ha eliminado correctamente");
                limpiar();
                btnEliminar.Enabled = false;
            }
            else
            {
                MessageBox.Show("Ocurrio un error al eliminar");
            }
        }
        public void limpiar()
        {
            textNombre.Clear();
            textApellido.Clear();
            textNumero.Clear();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            btnEliminar.Enabled = false;
            
        }

       
    }
}
