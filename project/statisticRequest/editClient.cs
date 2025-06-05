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
    public partial class editClient : Form
    {
        public editClient()
        {
            InitializeComponent();
        }

        private void editClient_Load(object sender, EventArgs e)
        {
            loadComponent();
        }

        public void loadComponent()
        {
            string query = $@"SELECT full_name, email, phone FROM client WHERE client_id = {data.indexClient}";

            using (SqlCommand cmd = new SqlCommand(query, dateBase.Connection))
            {
                cmd.Parameters.AddWithValue("@id", data.indexClient);

                dateBase.OpenConnection();

                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        //устанавливаем значения в элементы формы
                        textBoxName.Text = reader["full_name"].ToString();
                        textBoxEmail.Text = reader["email"].ToString();
                        textBoxPhone.Text = reader["phone"].ToString();
                    }
                }

                dateBase.CloseConnection();
            }
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            string name = textBoxName.Text.Trim();
            string phone = textBoxPhone.Text.Trim();
            string email = textBoxEmail.Text.Trim();

            if (string.IsNullOrWhiteSpace(name) || string.IsNullOrWhiteSpace(phone) || string.IsNullOrWhiteSpace(email))
            {
                MessageBox.Show("Пожалуйста, заполните все поля.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                string query = @"UPDATE client 
                                 SET full_name = @name, 
                                     email = @email, 
                                     phone = @phone 
                                 WHERE client_id = @id";

                using (SqlCommand cmd = new SqlCommand(query, dateBase.Connection))
                {
                    cmd.Parameters.AddWithValue("@name", name);
                    cmd.Parameters.AddWithValue("@email", email);
                    cmd.Parameters.AddWithValue("@phone", phone);
                    cmd.Parameters.AddWithValue("@id", data.indexClient);

                    dateBase.OpenConnection();
                    int result = cmd.ExecuteNonQuery();
                    dateBase.CloseConnection();

                    if (result > 0)
                    {
                        MessageBox.Show("Клиент успешно обновлен.", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Обновление не удалось.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                dateBase.CloseConnection();
                MessageBox.Show("Ошибка при обновлении: " + ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
