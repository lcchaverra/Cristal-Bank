using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace ProyectoBDII
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Salir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Ingresar_Click(object sender, EventArgs e)
        {
        }

        private void Ingresar_Click_1(object sender, EventArgs e)
        {
            string usuario = "luis";
            string contraseña = "123456";
            string vusuario = textUsuario.Text.TrimEnd();
            string vcontraseña = textContraseña.Text.TrimEnd();
              if (vusuario==usuario)
            {
                if (vcontraseña==contraseña)
                {
                    MessageBox.Show("¡Conexión Establecida Exitosamente!");
                    FormularioPrincipal menu = new FormularioPrincipal();
                    menu.Show();
                    this.Hide();
                }
            }
               

        }

        private void Login_Load(object sender, EventArgs e)
        {

        }
    }
}

