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

namespace Custom_Copys
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        //Conexion
        string conexionstring = "datasource=Localhost;port=3306;username=root;password=cbn2016;database=pruebasql;";
           



        private void Form1_Load(object sender, EventArgs e)
        {
            string query = "SELECT * FROM Usuario";
            MySqlConnection conexion = new MySqlConnection(conexionstring);
            conexion.Open();
            MySqlCommand commando = new MySqlCommand(query, conexion);
            MySqlDataAdapter da = new MySqlDataAdapter(commando);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dataGridView1.DataSource=ds.Tables[0];
            conexion.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {
          

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
          
            
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void ButtonNuevo_Click(object sender, EventArgs e)
        {
            Id.Focus();
            //Limpiar de manera rapida
            foreach(Control c in this.Controls)
            {
                if(c is TextBox)
                {
                    c.Text = "";
                    c.Enabled = true;
                    Id.Focus();
                }
            }
            Id.Enabled = true;
            Nombre.Enabled = true;
            Apellido.Enabled = true;
            Direccion.Enabled = true;
            Telefono.Enabled = true;
        }

        private void LabelApellido_Click(object sender, EventArgs e)
        {

        }

        private void ButtonInsertar_Click(object sender, EventArgs e)
        {
            MySqlConnection conexion = new MySqlConnection(conexionstring);
            conexion.Open();
            {
                String query = @"INSERT INTO pruebasql.usuario(idUsuario,nombre,apellido,direccion,telefono)VALUES(?idUsuario,?nombre,?apellido,?direccion,?telefono,)";
                MySqlCommand cmd = new MySqlCommand(query, conexion);

                cmd.Parameters.AddWithValue"?Usuario",Convert.ToInt64(Id.Text));
                cmd.Parameters.AddWithValue""
            }
        }
    }
}
