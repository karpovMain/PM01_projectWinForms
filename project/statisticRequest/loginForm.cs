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

namespace statisticRequest
{
    public partial class loginForm : Form
    {
        public loginForm()
        {
            InitializeComponent();
        }

        private void authorizeButton_Click(object sender, EventArgs e)
        {
            string login = loginTextBox.Text;
            string password = passwordTextBox.Text;
            if (login.Length == 0 || password.Length == 0)
            {
                MessageBox.Show("Вы не заполнили логин/пароль",
                                "Ошибка!", MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
                return;
            }

            string query = @"
                            SELECT role, linked_id
                            FROM [user]
                            WHERE username = @username AND password = @pass";
            dateBase.OpenConnection();
            using (var cmd = new SqlCommand(query, dateBase.Connection))
            {
                cmd.Parameters.AddWithValue("@username", login);
                cmd.Parameters.AddWithValue("@pass", password);

                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        data.role = reader["role"].ToString();
                        data.linked_id = reader["linked_id"] as int? ?? 0;

                        if (rememberCheckBox.Checked)
                        {
                            Properties.Settings.Default.RememberMe = true;
                            Properties.Settings.Default.SavedLogin = login;
                            Properties.Settings.Default.SavedPassword = password;
                        }
                        else
                        {
                            Properties.Settings.Default.RememberMe = false;
                            Properties.Settings.Default.SavedLogin = "";
                            Properties.Settings.Default.SavedPassword = "";
                        }
                        Properties.Settings.Default.Save();

                        dateBase.CloseConnection();
                        this.DialogResult = DialogResult.OK;
                        return;
                    }
                }
            }
            dateBase.CloseConnection();
            MessageBox.Show("Неверный логин или пароль",
                            "Ошибка!", MessageBoxButtons.OK,
                            MessageBoxIcon.Error);
        }

        private void loginForm_Load(object sender, EventArgs e)
        {
            if (Properties.Settings.Default.RememberMe)
            {
                rememberCheckBox.Checked = true;
                loginTextBox.Text = Properties.Settings.Default.SavedLogin;
                passwordTextBox.Text = Properties.Settings.Default.SavedPassword;
            }
        }
    }
}
