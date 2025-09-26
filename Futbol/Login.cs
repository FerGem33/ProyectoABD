using Futbol.Database;
using Futbol.Views;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Futbol
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void login_btn_Click(object sender, EventArgs e)
        {
            string username = textBox1.Text;
            string password = textBox2.Text;

            using (var conn = Db.GetConnection())
            {
                conn.Open();
                string sql = "SELECT COUNT(*) FROM usuarios WHERE usuario=@user AND contraseña=@pass";
                using (var cmd = new MySqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@user", username);
                    cmd.Parameters.AddWithValue("@pass", password);

                    int count = Convert.ToInt32(cmd.ExecuteScalar());
                    if (count > 0)
                    {
                        Form home = new ViewPartidos();
                        home.Show();
                        home.FormClosed += (s, args) => this.Close();
                        this.Hide();
                    }
                    else
                        MessageBox.Show("Usuario o contraseña incorrecto.");
                }
            }
        }
    }
}
