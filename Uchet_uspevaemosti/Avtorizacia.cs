using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Uchet_uspevaemosti
{
    public partial class Avtorizacia : Form
    {
        public Avtorizacia()
        {
            InitializeComponent();
        }

        private void Avtorizacia_Load(object sender, EventArgs e)
        {

        }

        private void buttonVoiti_Click(object sender, EventArgs e)
        {
            string Role;
            using (SqlConnection sqlcon = new SqlConnection(@"Data Source=DESKTOP-SUNPPQ;Initial Catalog=Uсhet_uspevaemosti;Integrated Security=True"))
            {
                sqlcon.Open();

                SqlCommand command = new SqlCommand("SELECT Role FROM [Avtorizacia] WHERE Login = @Login and Parol = @Parol", sqlcon);
                command.Parameters.AddWithValue("@Login", textBoxLogin.Text);
                command.Parameters.AddWithValue("@Parol", textBoxParol.Text);
                Role = (string)command.ExecuteScalar();
            }

            if (Role == "Администратор")
            {
                //UserAdmin.IsAdmin = true;
                this.Hide();
                Attestachia f3 = new Attestachia();
                f3.Show();
            }
            else
            {
                //UserAdmin.IsAdmin = false;
                MessageBox.Show("Неверный логин или пароль!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
