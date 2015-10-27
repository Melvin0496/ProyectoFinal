using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL;
namespace ProyectoFinal
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }
        public void Limpiar()
        {
            UsuarioTextBox.Clear();
            ContrasenaTextBox.Clear();
        }
        private void IniciarButton_Click(object sender, EventArgs e)
        {
            Usuarios usuario = new Usuarios();
            usuario.NombreUsuario = UsuarioTextBox.Text;
            usuario.Contrasena = ContrasenaTextBox.Text;
           

            if (usuario.VerificarUsuario() == UsuarioTextBox.Text && usuario.VerificarContrasena() == ContrasenaTextBox.Text)
            {
                VentanaPrincipal ventana = new VentanaPrincipal();
                ventana.ShowDialog();

            }
            else 
            {
                MessageBox.Show("Contraseña incorreta");
                
            }
        }

        private void CancelarButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
