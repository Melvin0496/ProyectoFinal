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
    public partial class VentanaPrincipal : Form
    {
        public VentanaPrincipal()
        {
            InitializeComponent();
        }

        private void registroToolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void registroUsuarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RegistrosUsuarios registro = new RegistrosUsuarios();
            registro.MdiParent = this;
            registro.Show();
        }
    }
}
