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
    public partial class editSpecialist : Form
    {
        public editSpecialist()
        {
            InitializeComponent();
        }

        private void editSpecialist_Load(object sender, EventArgs e)
        {
            loadComponent();
        }

        public void loadComponent()
        {
            string query = $@"SELECT full_name, email, phone FROM specialist WHERE specialist_id = {data.indexSpecialist}";

            using (SqlCommand cmd = new SqlCommand(query, dateBase.Connection))
            {
                cmd.Parameters.AddWithValue("@id", data.indexSpecialist);

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

        private void buttonEdit_Click(object sender, EventArgs e)
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
                string query = @"UPDATE specialist 
                                 SET full_name = @name, 
                                     email = @email, 
                                     phone = @phone 
                                 WHERE specialist_id = @id";

                using (SqlCommand cmd = new SqlCommand(query, dateBase.Connection))
                {
                    cmd.Parameters.AddWithValue("@name", name);
                    cmd.Parameters.AddWithValue("@email", email);
                    cmd.Parameters.AddWithValue("@phone", phone);
                    cmd.Parameters.AddWithValue("@id", data.indexSpecialist);

                    dateBase.OpenConnection();
                    int result = cmd.ExecuteNonQuery();
                    dateBase.CloseConnection();

                    if (result > 0)
                    {
                        MessageBox.Show("Специалист успешно обновлен.", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
