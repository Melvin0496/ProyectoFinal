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
    public partial class RegistrosUsuarios : Form
    {
        Usuarios usuario = new Usuarios();
        public RegistrosUsuarios()
        {
            InitializeComponent();
            FechamaskedTextBox.Text = String.Format("{0:dd/MM/yyyy}", DateTime.Now);
        }

        private void NuevoButton_Click(object sender, EventArgs e)
        {
            UsuarioIdTextBox.Clear();
            NombreTextBox.Clear();
            UsuarioIdTextBox.Clear();
            ContrasenaTextBox.Clear();
            AreaTextBox.Clear();
        }

        private void Datos()
        {
            usuario.Nombre = NombreTextBox.Text;
            usuario.NombreUsuario = UsuarioTextBox.Text;
            usuario.Contrasena = ContrasenaTextBox.Text;
            usuario.Area = AreaTextBox.Text;
            usuario.Fecha = FechamaskedTextBox.Text;
            

        }
        private void GuardarButton_Click(object sender, EventArgs e)
        {
            if (UsuarioIdTextBox.TextLength > 0)
            {
                usuario.UsuarioId = int.Parse(UsuarioIdTextBox.Text);
                Datos();
                if (usuario.Editar())
                {
                    MessageBox.Show("Se edito el usuario correctamente");
                    NuevoButton.PerformClick();
                }
                else
                {
                    MessageBox.Show("Error al  editar el usuario ");
                }
            }
            else if (UsuarioIdTextBox.TextLength == 0)
            {
                Datos();
                if (usuario.Insertar())
                {
                    MessageBox.Show("Se guardado el usuario correctamente");
                    NuevoButton.PerformClick();
                }
                else
                {
                    MessageBox.Show("Error  al guardar el  usuario");
                }

            }
        }

        private void EliminarButton_Click(object sender, EventArgs e)
        {
            if (UsuarioIdTextBox.TextLength > 0)
            {
                usuario.UsuarioId = int.Parse(UsuarioIdTextBox.Text);

                if (usuario.Eliminar())
                {
                    MessageBox.Show("Se eliminno el usuario correctamente");
                    NuevoButton.PerformClick();
                }
                else
                {
                    MessageBox.Show("Error al  eliminar el usuario ");
                }
            }
            else
            {
                MessageBox.Show("Ingrese el Id ");
            }
        }
    }
}
