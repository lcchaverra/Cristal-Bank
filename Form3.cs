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
    public partial class FormularioAdministracionMedicamentos : Form
    {
        private MySqlConnection conexionBD = new MySqlConnection("server=localhost; " + "port=3306; " + "database=ludb; " + " user id=root; " + "password=lucas151;");
        public FormularioAdministracionMedicamentos()
        {
            InitializeComponent();
        }

        private void Guardar1_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Está Seguro de querer guardar esta informacion ?", "Agregar a Inventario", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
            string vid = idi.Text.TrimEnd();
            string vtipoimp = tim.Text.TrimEnd();
            string vnombremedi = nim.Text.TrimEnd();
            string vprecio = pre.Text.TrimEnd();
            string vcantidad = canti.Text.TrimEnd();
            string vfechavenci = dateTimePicker2.Value.ToString();
            string vfechaingre = dateTimePicker1.Value.ToString();
                conexionBD.Open();
                try
                {
                    MySqlCommand comando = new MySqlCommand("insert into implementos(idimplementos, tipoimplemento, nombreimplemento, fechaingreso, fechavencimiento, cantidad, precio) values ('" + vid + "','"+ vtipoimp + "','" + vnombremedi + "','"+ vfechaingre + "','" + vfechavenci + "','" + vcantidad + "','"  + vprecio + "')", conexionBD);
                    comando.ExecuteNonQuery();
                    MessageBox.Show(" ¡Registro Exitoso! ");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            }
            else
            {
                MessageBox.Show(" Operación Abortada... ");
            }
            conexionBD.Close();
        }

        private void Nuevo1_Click(object sender, EventArgs e)
        {
            idi.Clear();
            nim.Clear();
            pre.Clear();
            canti.Clear();
        }

        private void Cancelar1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Buscar1_Click(object sender, EventArgs e)
        {
            string identificador1 = idi.Text.TrimEnd();
            string comandoconsulta = "select*from implementos where idimplementos = " + identificador1;
            conexionBD.Open();
            MySqlCommand comando = new MySqlCommand(comandoconsulta, conexionBD);
            MySqlDataReader registro = comando.ExecuteReader();
            if (registro.Read())
            {

                idi.Text = registro["idimplementos"].ToString();
                nim.Text = registro["nombreimplemento"].ToString();
                pre.Text = registro["precio"].ToString();
                tim.Text = registro["tipoimplemento"].ToString();
                canti.Text = registro["cantidad"].ToString();
                dateTimePicker2.Text = registro["fechavencimiento"].ToString();
                dateTimePicker1.Text = registro["fechaingreso"].ToString();
            }
            else
            {
                MessageBox.Show(" Hubo un Error En la Consulta, Verifique sus datos ... ");
            }
            conexionBD.Close();
        }

        private void Eliminar1_Click(object sender, EventArgs e)
        {
            
        }

        private void id1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 47) || (e.KeyChar >= 58 && e.KeyChar <= 255))
            {
                MessageBox.Show(" En Este Campo Solo Se Admiten Numeros ", " Advertencia ", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void pre_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 47) || (e.KeyChar >= 58 && e.KeyChar <= 255))
            {
                MessageBox.Show(" En Este Campo Solo Se Admiten Numeros ", " Advertencia ", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void canti_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 47) || (e.KeyChar >= 58 && e.KeyChar <= 255))
            {
                MessageBox.Show(" En Este Campo Solo Se Admiten Numeros ", " Advertencia ", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void nomed_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 33 && e.KeyChar <= 64) || (e.KeyChar >= 91 && e.KeyChar <= 96 || (e.KeyChar >= 123 && e.KeyChar <= 255)))
            {
                MessageBox.Show(" En Este Campo Solo Se Admiten Letras ", " Advertencia ", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }
    }
}
