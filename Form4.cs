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
using System.Drawing.Printing;
using iTextSharp.text;
using iTextSharp.text.pdf;
using iTextSharp;
using System.IO;
using Rectangle = System.Drawing.Rectangle;

namespace ProyectoBDII
{
    public partial class Factura : Form
    {
        private MySqlConnection conexionBD = new MySqlConnection("server=localhost; " + "port=3306; " + "database=ludb; " + " user id=root; " + "password=lucas151;");
        public Factura()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void propertyGrid1_Click(object sender, EventArgs e)
        {

        }

        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            string numerocita = numcita.Text.TrimEnd();
            string comandoconsultacita = "select*from citas where idCita =" + numerocita;
            conexionBD.Open();
            MySqlCommand comando2 = new MySqlCommand(comandoconsultacita, conexionBD);
            MySqlDataReader registro2 = comando2.ExecuteReader();
            if (registro2.Read())
            {
                docum.Text = registro2["Documento"].ToString();
            }
            else
            {
                MessageBox.Show("No existe una cita asignada con ese Numero ingresado");
            }
            conexionBD.Close();
            string documentocliente = docum.Text.TrimEnd();
            string comandoconsultaclient = "select*from clientes where cedula =" + documentocliente;
            conexionBD.Open();
            MySqlCommand comando = new MySqlCommand(comandoconsultaclient, conexionBD);
            MySqlDataReader registro = comando.ExecuteReader();
            if (registro.Read())
            {
                nomu.Text = registro["nombres"].ToString();
                apu.Text = registro["apellidos"].ToString();
                telu.Text = registro["telefono"].ToString();
                edu.Text = registro["edad"].ToString();
                tdou.Text = registro["tdocumento"].ToString();
                epsu.Text = registro["eps"].ToString();
                tsau.Text = registro["tsangre"].ToString();
                diru.Text = registro["direccion"].ToString();
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
            numfactu.Text = auxiliar.ToString();
            DateTime fecha = DateTime.Now;
            fechafactu.Text = fecha.ToString();
        }

        private void numfactu_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int n = fact.Rows.Add();
            string ide = idemedfact.Text.TrimEnd();
            double a=0, b=0;
            double c;
            string comandoconsulta = "select*from implementos where idimplementos = " + ide;
            conexionBD.Open();
            MySqlCommand comando = new MySqlCommand(comandoconsulta, conexionBD);
            MySqlDataReader registro = comando.ExecuteReader();
            if (registro.Read())
            {
                fact.Rows[n].Cells[0].Value = registro["idimplementos"].ToString();

                fact.Rows[n].Cells[1].Value = registro["tipoimplemento"].ToString();
                fact.Rows[n].Cells[2].Value = registro["nombreimplemento"].ToString();
                fact.Rows[n].Cells[3].Value = registro["precio"].ToString();
                a = Convert.ToDouble(fact.Rows[n].Cells[3].Value);
                string auxiliar = registro["Cantidad"].ToString();
                fact.Rows[n].Cells[4].Value = cantidadfactme.Text;
                fact.Rows[n].Cells[5].Value = registro["fechavencimiento"].ToString();
                b = Convert.ToDouble(fact.Rows[n].Cells[4].Value);
            }
            else
            {
                MessageBox.Show(" Hubo un Error En la Consulta, Verifique sus datos ... ");
            }
            conexionBD.Close();
            idemedfact.Clear();
            cantidadfactme.Clear();
            c = Convert.ToDouble(a * b);
            fact.Rows[n].Cells[6].Value = c;
            double total =0;
            foreach (DataGridViewRow row in fact.Rows)
            {
                total += Convert.ToDouble(row.Cells["Total"].Value);
            }
            totalfact.Text = Convert.ToString(total);
        }
        private void button1_Click(object sender, EventArgs e)
        {
            string varidfact = numfactu.Text.TrimEnd();
            string varfechfact = fechafactu.Text.TrimEnd();
            string varcita = numcita.Text.TrimEnd();
            string varcedula = docum.Text.TrimEnd();
            int varimplemento = 0, varmedicamentocantidad = 0, varmedicamentototal = 0;
            string ruta ="";
            TextWriter exportar;
            SaveFileDialog guardar = new SaveFileDialog();
            guardar.Filter = "Archivos De Texto|*.txt";
            guardar.Title = "Guardar";
            if (guardar.ShowDialog() == DialogResult.OK)
            {
                ruta = guardar.FileName;
                exportar = new StreamWriter(ruta);
                exportar.WriteLine("-----------------------------FACTURA DE VENTA -----------------------------");
                exportar.WriteLine("");
                exportar.WriteLine("");
                exportar.WriteLine("----------------INFO DEL CLIENTE----------------------");
                exportar.WriteLine("");
                exportar.WriteLine("-Tipo de Documento: " + tdou.Text);
                exportar.WriteLine("-Numero de Documento: " + docum.Text);
                exportar.WriteLine("-Nombres: " + nomu.Text);
                exportar.WriteLine("-Apellidos: " + apu.Text);
                exportar.WriteLine("-Telefono: " + telu.Text);
                exportar.WriteLine("-Direccion: " + diru.Text);
                exportar.WriteLine("-Edad: " + edu.Text);
                exportar.WriteLine("-EPS: " + epsu.Text);
                exportar.WriteLine("-Tipo de Sangre: " + tsau.Text);
                exportar.WriteLine("");
                exportar.WriteLine("---------------INFO DE LA FACTURA--------------------");
                exportar.WriteLine("");
                exportar.WriteLine("-Numero de Factura: " + numfactu.Text);
                exportar.WriteLine("-Fecha Y Hora De Facturacion: " + fechafactu.Text);
                exportar.WriteLine("-Implementos Facturados: ");
                exportar.WriteLine("");
                for (int i = 0; i < fact.RowCount - 1; i++)
                {
                    for (int j = 0; j < fact.ColumnCount; j++)
                    {
                        exportar.Write(" - "+fact[j, i].Value);
                    }
                    exportar.WriteLine("\n");
                }
                exportar.WriteLine("----------------------------------------------");
                exportar.WriteLine("TOTAL DE SU FACTURA: " + totalfact.Text);
                exportar.Close();
            }
            guardar.Dispose();
            MessageBox.Show(" Su Factura se Generó Exitosamente y se Guardó en la ruta: "+ruta);
            conexionBD.Open();
            try
            {
                foreach (DataGridViewRow row in fact.Rows)
                {
                    varimplemento = Convert.ToInt32(row.Cells["ID"].Value);
                    varmedicamentocantidad = Convert.ToInt32(row.Cells["Cantidad"].Value);
                    varmedicamentototal = Convert.ToInt32(row.Cells["Total"].Value);
                    MySqlCommand comandofact = new MySqlCommand("insert into factura(idfactura, fechafacturacion, idcita, idusuario, idimplemento, cantidad, totalfactura) values ('" + varidfact + "','" + varfechfact + "','" + varcita + "','" + varcedula + "','" + varimplemento + "','"  + varmedicamentocantidad + "','" + varmedicamentototal +"')", conexionBD);
                    comandofact.ExecuteNonQuery();
                }
                //SET SQL_SAFE_UPDATES = 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            conexionBD.Close();
        }

        private void fact_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Factura_Load(object sender, EventArgs e)
        {

        }

        private void docum_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 47) || (e.KeyChar >= 58 && e.KeyChar <= 255))
            {
                MessageBox.Show(" En Este Campo Solo Se Admiten Numeros ", " Advertencia ", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void idemedfact_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 47) || (e.KeyChar >= 58 && e.KeyChar <= 255))
            {
                MessageBox.Show(" En Este Campo Solo Se Admiten Numeros ", " Advertencia ", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void cantidadfactme_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 47) || (e.KeyChar >= 58 && e.KeyChar <= 255))
            {
                MessageBox.Show(" En Este Campo Solo Se Admiten Numeros ", " Advertencia ", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void label17_Click(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void docum_TextChanged(object sender, EventArgs e)
        {

        }
    }
}