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
    public partial class Mostrar : Form
    {
        public Mostrar()
        {
            InitializeComponent();
        }
        public contacto contactoSeleccionado { get; set; }
        private void dvg_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            dgvMostrar.DataSource = funciones.mostrar();
        }

        private void btnSeleccionar2_Click(object sender, EventArgs e)
        {
            if (dgvMostrar.SelectedRows.Count == 1)
            {
                int id = Convert.ToInt32(dgvMostrar.CurrentRow.Cells[0].Value);
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
