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
    public partial class FormCitas : Form
    {
        private MySqlConnection conexionBD = new MySqlConnection("server=localhost; " + "port=3306; " + "database=ludb; " + " user id=root; " + "password=lucas151;");
        public FormCitas()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int n = DaU.Rows.Add();
            string cc = docum.Text.TrimEnd();
            string comandoconsulta = "select*from clientes where cedula =" + cc;
            conexionBD.Open();
            MySqlCommand comando = new MySqlCommand(comandoconsulta, conexionBD);
            MySqlDataReader registro = comando.ExecuteReader();
            if (registro.Read())
            {
                DaU.Rows[n].Cells[0].Value = registro["tdocumento"].ToString();
                DaU.Rows[n].Cells[1].Value = registro["nombres"].ToString();
                DaU.Rows[n].Cells[2].Value = registro["apellidos"].ToString();
                DaU.Rows[n].Cells[3].Value = registro["eps"].ToString();
                DaU.Rows[n].Cells[4].Value = registro["tsangre"].ToString();
                DaU.Rows[n].Cells[5].Value = registro["direccion"].ToString();
                DaU.Rows[n].Cells[6].Value = registro["telefono"].ToString();
                DaU.Rows[n].Cells[7].Value = registro["edad"].ToString();
            }
            else
            {
                MessageBox.Show("No existe un Usuario con ese Numero de Documento ingresado");
            }
            conexionBD.Close();
            int[] numeros = new int[25];
            Random r = new Random();

            int auxiliar = 0;
            int contador = 0;

            for (int i = 0; i < 25; i++)
            {
                auxiliar = r.Next(1, 9999);
                bool continuar = false;

                while (!continuar)
                {
                    for (int j = 0; j <= contador; j++)
                    {
                        if (auxiliar == numeros[j])
                        {
                            continuar = true;
                            j = contador;
                        }
                    }

                    if (continuar)
                    {
                        auxiliar = r.Next(1, 9999);
                        continuar = false;
                    }
                    else
                    {
                        continuar = true;
                        numeros[contador] = auxiliar;
                        contador++;
                    }
                }
            }
            numcita.Text = auxiliar.ToString();
        }

        private void Guardar_Click(object sender, EventArgs e)
        {
            string vdocu = docum.Text.TrimEnd();
            string vidc = numcita.Text.TrimEnd();
            string vfs = dateTimePicker1.Value.ToString();
            string vfa = dateTimePicker2.Value.ToString();
            conexionBD.Open();
            try
            {
                MySqlCommand comando = new MySqlCommand("insert into citas(idCita, Documento, FechaSeparacion, FechaAsignacion) values ('" + vidc + "','" + vdocu + "','"  + vfs + "','" + vfa + "')", conexionBD);
                comando.ExecuteNonQuery();
                MessageBox.Show(" ¡Registro Exitoso! ");
                docum.Clear();
                numcita.Clear();
                DaU.Rows.Clear();
                    }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            conexionBD.Close();
        }

        private void Eliminar_Click(object sender, EventArgs e)
        {
            string ic = numcita.Text.TrimEnd();
            string comandoeliminar = "delete from citas where idCita =" + ic;
            conexionBD.Open();
            try
            {
                MySqlCommand comando = new MySqlCommand(comandoeliminar, conexionBD);
                comando.ExecuteNonQuery();
                MessageBox.Show("Cita Eliminada Exitosamente...");
                docum.Clear();
                numcita.Clear();
                DaU.Rows.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            conexionBD.Close();
        }

        private void Buscar_Click(object sender, EventArgs e)
        {
            int n = DaU.Rows.Add();
            string IDc = numcita.Text.TrimEnd();
            string comandoconsulta = "select*from citas where idCita =" + IDc;
            conexionBD.Open();
            MySqlCommand comando = new MySqlCommand(comandoconsulta, conexionBD);
            MySqlDataReader registro = comando.ExecuteReader();
            if (registro.Read())
            {
                docum.Text = registro["Documento"].ToString();
                dateTimePicker1.Text = registro["FechaSeparacion"].ToString();
                dateTimePicker2.Text = registro["FechaAsignacion"].ToString();
                Eliminar.Enabled = true;
            }
            else
            {
                MessageBox.Show("No existe una cita con ese Numero ingresado");
            }
            conexionBD.Close();
            conexionBD.Open();
            string vdocume = docum.Text;
            string comandoconsulta2 = "select*from clientes where cedula =" + vdocume;
            MySqlCommand comando2 = new MySqlCommand(comandoconsulta2, conexionBD);
            MySqlDataReader registro2 = comando2.ExecuteReader();
            if (registro2.Read())
            {
                DaU.Rows[n].Cells[0].Value = registro2["tdocumento"].ToString();
                DaU.Rows[n].Cells[1].Value = registro2["nombres"].ToString();
                DaU.Rows[n].Cells[2].Value = registro2["apellidos"].ToString();
                DaU.Rows[n].Cells[3].Value = registro2["eps"].ToString();
                DaU.Rows[n].Cells[4].Value = registro2["tsangre"].ToString();
                DaU.Rows[n].Cells[5].Value = registro2["direccion"].ToString();
                DaU.Rows[n].Cells[6].Value = registro2["telefono"].ToString();
                DaU.Rows[n].Cells[7].Value = registro2["edad"].ToString();
            }
            else
            {
                MessageBox.Show("No existe un Usuario con ese Numero de Documento ingresado");
            }
            conexionBD.Close();
        }

        private void Cancelar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
