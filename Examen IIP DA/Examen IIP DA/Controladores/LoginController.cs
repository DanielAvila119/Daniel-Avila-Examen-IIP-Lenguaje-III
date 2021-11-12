using Examen_IIP_DA.Modelos.DAO;
using Examen_IIP_DA.Modelos.Entidades;
using Examen_IIP_DA.Vistas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Examen_IIP_DA.Controladores
{
    public class LoginController
    {
        LoginView vista;

        public LoginController(LoginView view)
        {
            vista = view;
            vista.AceptarButton.Click += new EventHandler(ValidarUsuario);
        }

        private void ValidarUsuario(object sender, EventArgs e)
        {
            bool esValido = false;
            UsuarioDAO userDAO = new UsuarioDAO();

            Usuario user = new Usuario();
            user.Email = vista.EmailTextBox.Text;
            user.Clave = (vista.ClaveTextBox.Text);

            esValido = userDAO.ValidarUsuario(user);
            if (esValido)
            {
                MessageBox.Show("Usuario Correcto");
                //MenuView menu = new MenuView();
                //vista.Hide();
                //menu.Show();
            }
            else
            {
                MessageBox.Show("Usuario Incorrecto, vuelva a intentarlo");

            }
        }
    }
}
