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
    public partial class addSpecialist : Form
    {
        public addSpecialist()
        {
            InitializeComponent();
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
                string query = @"INSERT INTO specialist (full_name, email, phone)
                         VALUES (@name, @email, @phone)";

                using (SqlCommand cmd = new SqlCommand(query, dateBase.Connection))
                {
                    cmd.Parameters.AddWithValue("@name", name);
                    cmd.Parameters.AddWithValue("@email", email);
                    cmd.Parameters.AddWithValue("@phone", phone);

                    dateBase.OpenConnection();
                    int result = cmd.ExecuteNonQuery();
                    dateBase.CloseConnection();

                    if (result > 0)
                    {
                        MessageBox.Show("Специалист успешно добавлен.", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Не удалось добавить специалиста.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                dateBase.CloseConnection();
                MessageBox.Show("Ошибка при добавлении специалиста: " + ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
