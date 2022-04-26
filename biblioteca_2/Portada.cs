using System;
using System.Configuration;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace biblioteca_2
{
    public partial class Portada : Form
    {
        public Portada()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
          


            {
                if (txt_Contraseña.Text == string.Empty)
                {
                    MessageBox.Show("Llenar campos");
                }
                else
                {
                    try
                    {
                        SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["conexion"].ConnectionString);
                        conn.Open();
                        using (SqlCommand command = conn.CreateCommand())
                        {
                            SqlCommand cmd = new SqlCommand("SELECT contraseña FROM USUARIOS WHERE contraseña = '" + txt_Contraseña.Text + "'", conn);
                            SqlDataReader dr = cmd.ExecuteReader();
                            if (dr.Read())
                            {
                                this.Hide();
                                Form1 general = new Form1();
                                general.Show();
                            }
                            else
                            {
                                MessageBox.Show("Datos incorrectos");
                            }
                            dr.Close();
                            conn.Close();
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.ToString());
                    }
                }
            }

           
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            REGISTRO registro = new REGISTRO();
            registro.Show();

           
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Portada_Load(object sender, EventArgs e)
        {
            
        }

        private void txt_correo_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
