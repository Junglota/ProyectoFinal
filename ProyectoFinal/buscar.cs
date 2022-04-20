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
    public partial class buscar : Form
    {
        public buscar()
        {
            InitializeComponent();
        }
        public contacto contactoSeleccionado { get; set; }
        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(textNombre.Text)|| String.IsNullOrWhiteSpace(textApellidos.Text))
            {
                MessageBox.Show("Hay campos vacios");
            }
            else
            {
                dgvBuscar.DataSource = funciones.buscar(textNombre.Text, textApellidos.Text);
            }
        }

        private void buscar_Load(object sender, EventArgs e)
        {

        }

        private void btnSeleccionar_Click(object sender, EventArgs e)
        {
            if(dgvBuscar.SelectedRows.Count == 1)
            {
                int id = Convert.ToInt32(dgvBuscar.CurrentRow.Cells[0].Value);
                contactoSeleccionado = funciones.obtenerContacto(id);
                this.Close();
            }
            else
            {
                MessageBox.Show("No has seleccionado nada");
            }
        }
    }
}
