using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace biblioteca_2
{
    public partial class REGISTRO : Form
    {
        public REGISTRO()
        {
            InitializeComponent();
        }

        SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["conexion"].ConnectionString);

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btn_registro(object sender, EventArgs e)

        {
            if (txt_nombre.Text == string.Empty || txt_passw.Text == string.Empty ||
                txt_apellidos.Text == string.Empty || txt_phone.Text == string.Empty ||
                txt_cedula.Text == string.Empty || txt_mail.Text == string.Empty)
            {
                MessageBox.Show("Debes llenar los campos");
            }
            else
            {
                bool existe = ExisteCorreo();
                if (existe == true)
                {
                    MessageBox.Show("Ya existe un correo con ese nombre");
                    conn.Close();
                }
                else
                {
                    try
                    {
                        string query = "INSERT INTO USUARIOS(Celular,contrasena,Nombres,Apellidos,Num_Identificacion,Correo_electronico ) " +
                            "VALUES('" + txt_phone.Text + "','" + txt_passw.Text + "','" + txt_nombre.Text + "','" +
                                            txt_apellidos.Text + "','" + txt_cedula.Text + "','" + txt_mail.Text + "')";
                        //conn.Open();
                        SqlCommand cmd = new SqlCommand(query, conn);
                        SqlDataAdapter da = new SqlDataAdapter(cmd);
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Correo creado correctamente");
                        conn.Close();
                        LimpiarCampos();
                    }
                    catch (Exception ex)
                    {

                        MessageBox.Show(ex.ToString());
                    }
                }

            }
        }
        public void LimpiarCampos()
        {
            txt_nombre.Text = "";
            txt_apellidos.Text = "";
            txt_mail.Text = "";
            txt_phone.Text = "";
            txt_cedula.Text = "";
            txt_passw.Text = "";
        }
        public bool ExisteCorreo()
        {
            bool existe = false;
            conn.Open();
            string query = "select COUNT(*) from USUARIOS where Correo_electronico = @Correo_electronico";
            SqlCommand consulta = new SqlCommand(query, conn);
            consulta.Parameters.AddWithValue("@Correo_electronico ", txt_email.Text);

            int count = Convert.ToInt32(consulta.ExecuteScalar());
            if (count > 0)
            {
                existe = true;
            }
            else
            {
                existe = false;
            }

            return existe;
        }

    }
}
