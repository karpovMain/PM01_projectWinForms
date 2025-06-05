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
using System.Windows.Forms.VisualStyles;

namespace statisticRequest
{
    public partial class editEquipment : Form
    {
        public editEquipment()
        {
            InitializeComponent();
        }

        private void editEquipment_Load(object sender, EventArgs e)
        {
            loadComponent();
        }

        public void loadComponent()
        {
            string query = $@"SELECT equipment_description, equipment_type, serial_number FROM equipment WHERE equipment_id = {data.indexEquipment}";

            using (SqlCommand cmd = new SqlCommand(query, dateBase.Connection))
            {
                cmd.Parameters.AddWithValue("@id", data.indexEquipment);

                dateBase.OpenConnection();

                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        //устанавливаем значения в элементы формы
                        textBoxName.Text = reader["equipment_description"].ToString();
                        textBoxModel.Text = reader["equipment_type"].ToString();
                        textBoxSerial.Text = reader["serial_number"].ToString();
                    }
                }

                dateBase.CloseConnection();
            }
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            string name = textBoxName.Text.Trim();
            string model = textBoxModel.Text.Trim();
            string serial = textBoxSerial.Text.Trim();

            if (string.IsNullOrWhiteSpace(name) || string.IsNullOrWhiteSpace(model) || string.IsNullOrWhiteSpace(serial))
            {
                MessageBox.Show("Пожалуйста, заполните все поля.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                string query = @"UPDATE equipment 
                                 SET equipment_description = @name, 
                                     equipment_type = @model, 
                                     serial_number = @serial 
                                 WHERE equipment_id = @id";

                using (SqlCommand cmd = new SqlCommand(query, dateBase.Connection))
                {
                    cmd.Parameters.AddWithValue("@name", name);
                    cmd.Parameters.AddWithValue("@model", model);
                    cmd.Parameters.AddWithValue("@serial", serial);
                    cmd.Parameters.AddWithValue("@id", data.indexEquipment);

                    dateBase.OpenConnection();
                    int result = cmd.ExecuteNonQuery();
                    dateBase.CloseConnection();

                    if (result > 0)
                    {
                        MessageBox.Show("Оборудование успешно обновлено.", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Close(); // Закрыть форму после редактирования
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
