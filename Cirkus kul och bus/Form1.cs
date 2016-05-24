using Npgsql;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cirkus_kul_och_bus
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            NpgsqlConnection conn = new NpgsqlConnection("Server=localhost;Port=5432;User Id=webuser;Password=test123;Database=cirkus;");

            try
            {

                string sqlfraga = "SELECT * FROM person";
                conn.Open();
                NpgsqlCommand cmd = new NpgsqlCommand(sqlfraga, conn);
                NpgsqlDataReader dr = cmd.ExecuteReader();

                while (dr.Read())
                {

                    listboxPersoner.Items.Add(dr["förnamn"].ToString());

                }
            }
            catch (NpgsqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }
    }
}
