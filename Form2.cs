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
    public partial class FormularioAdministracionCliente : Form
    {
        private MySqlConnection conexionBD = new MySqlConnection("server=localhost; " + "port=3306; " + "database=ludb; " + " user id=root; " + "password=lucas151;");
        public FormularioAdministracionCliente()
        {
            InitializeComponent();
        }

        private void Cancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Guardar_Click(object sender, EventArgs e)
        {
            string tdocu = tipodocu.Text.TrimEnd();
            string vtsangre = tsang.Text.TrimEnd();
            string vdireccion = dir.Text.TrimEnd();
            string veps = eps.Text.TrimEnd();
            string vcedula = cedula.Text.TrimEnd();
            string vnombres = nombres.Text.TrimEnd();
            string vapellidos = apellidos.Text.TrimEnd();
            string vtelefono = telefono.Text.TrimEnd();
            string vedad = edad.Text.TrimEnd();
            conexionBD.Open();
            try
            {
                MySqlCommand comando = new MySqlCommand("insert into clientes(tdocumento, cedula, nombres, apellidos, eps, tsangre, direccion, telefono, edad) values ('" + tdocu + "','" + vcedula + "','" + vnombres + "','" + vapellidos + "','" + veps + "','" + vtsangre + "','" + vdireccion + "','" + vtelefono +  "','" + vedad + "')", conexionBD);
                comando.ExecuteNonQuery();
                MessageBox.Show(" ¡Registro Exitoso! ");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            conexionBD.Close();
        }

        private void FormularioAdministracionCliente_Load(object sender, EventArgs e)
        {
        }

        private void Nuevo_Click(object sender, EventArgs e)
        {
            cedula.Clear();
            nombres.Clear();
            apellidos.Clear();
            telefono.Clear();
            edad.Clear();
            dir.Clear();
            Eliminar.Enabled = false;
            Actualizar.Enabled = false;
        }

        private void Buscar_Click(object sender, EventArgs e)
        {
            string cc = cedula.Text.TrimEnd();
            string comandoconsulta = "select*from clientes where cedula ="+cc;
            conexionBD.Open();
            MySqlCommand comando = new MySqlCommand(comandoconsulta,conexionBD);
            MySqlDataReader registro = comando.ExecuteReader();
            if (registro.Read())
            {
                nombres.Text = registro["nombres"].ToString();
                apellidos.Text = registro["apellidos"].ToString();
                telefono.Text = registro["telefono"].ToString();
                edad.Text = registro["edad"].ToString();
                tipodocu.Text = registro["tdocumento"].ToString();
                eps.Text = registro["eps"].ToString();
                tsang.Text = registro["tsangre"].ToString();
                dir.Text = registro["direccion"].ToString();
                Eliminar.Enabled = true;
                Actualizar.Enabled = true;
            }
            else
            {
                MessageBox.Show("No existe un Usuario con ese Numero de Documento ingresado");
            }
            conexionBD.Close();
        }
        private void Actualizar_Click(object sender, EventArgs e)
        {
            string acedula = cedula.Text.TrimEnd();
            string anombres = nombres.Text.TrimEnd();
            string aapellidos = apellidos.Text.TrimEnd();
            string atelefono = telefono.Text.TrimEnd();
            string aedad = edad.Text.TrimEnd();
            string atdocu = tipodocu.Text.TrimEnd();
            string atsangre = tsang.Text.TrimEnd();
            string adireccion = dir.Text.TrimEnd();
            string aeps = eps.Text.TrimEnd();
            string comandoactualizacion = "update clientes set tdocumento='" + atdocu + "',nombres='" + anombres + "',apellidos='" + aapellidos + "', eps= '" + aeps + "', tsangre= '" + atsangre + "', direccion= '" + adireccion + "', telefono= '" + atelefono +  "', edad='" + aedad + "' where cedula = " + acedula + ";";
            conexionBD.Open();
            try
            {
                MySqlCommand comando = new MySqlCommand(comandoactualizacion, conexionBD); 
                comando.ExecuteNonQuery();
                MessageBox.Show("Se modificaron los campos: ");
                cedula.Clear();
                nombres.Clear();
                apellidos.Clear();
                telefono.Clear();
                edad.Clear();
                dir.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            conexionBD.Close();
        }

        private void Eliminar_Click(object sender, EventArgs e)
        {
            string ce = cedula.Text.TrimEnd();
            string comandoeliminar = "delete from clientes where cedula =" + ce;
            conexionBD.Open();
            try
            {
                MySqlCommand comando = new MySqlCommand(comandoeliminar, conexionBD);
                comando.ExecuteNonQuery();
                MessageBox.Show("Usuario Eliminado Exitosamente...");
                cedula.Clear();
                nombres.Clear();
                apellidos.Clear();
                telefono.Clear();
                edad.Clear();
                dir.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            conexionBD.Close();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void cedula_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 47) || (e.KeyChar >= 58 && e.KeyChar <= 255))
            {
                MessageBox.Show(" En Este Campo Solo Se Admiten Numeros ", " Advertencia ", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void regimen_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 33 && e.KeyChar <= 64) || (e.KeyChar >= 91 && e.KeyChar <= 96) || (e.KeyChar >= 123 && e.KeyChar <= 255))
            {
                MessageBox.Show(" En Este Campo Solo Se Admiten Letras ", " Advertencia ", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }
        private void nombres_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 33 && e.KeyChar <= 64) || (e.KeyChar >= 91 && e.KeyChar <= 96) || (e.KeyChar >= 123 && e.KeyChar <= 255))
            {
                MessageBox.Show(" En Este Campo Solo Se Admiten Letras ", " Advertencia ", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void apellidos_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 33 && e.KeyChar <= 64) || (e.KeyChar >= 91 && e.KeyChar <= 96) || (e.KeyChar >= 123 && e.KeyChar <= 255))
            {
                MessageBox.Show(" En Este Campo Solo Se Admiten Letras ", " Advertencia ", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }
        private void telefono_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 47) || (e.KeyChar >= 58 && e.KeyChar <= 255))
            {
                MessageBox.Show(" En Este Campo Solo Se Admiten Numeros ", " Advertencia ", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }
        private void edad_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 47) || (e.KeyChar >= 58 && e.KeyChar <= 255))
            {
                MessageBox.Show(" En Este Campo Solo Se Admiten Numeros ", " Advertencia ", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }
    }
}
