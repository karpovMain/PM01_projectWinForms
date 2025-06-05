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
    public partial class addEquipment : Form
    {
        public addEquipment()
        {
            InitializeComponent();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
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
                string query = @"INSERT INTO equipment (equipment_description, equipment_type, serial_number)
                         VALUES (@name, @model, @serial)";

                using (SqlCommand cmd = new SqlCommand(query, dateBase.Connection))
                {
                    cmd.Parameters.AddWithValue("@name", name);
                    cmd.Parameters.AddWithValue("@model", model);
                    cmd.Parameters.AddWithValue("@serial", serial);

                    dateBase.OpenConnection();
                    int result = cmd.ExecuteNonQuery();
                    dateBase.CloseConnection();

                    if (result > 0)
                    {
                        MessageBox.Show("Оборудование успешно добавлено.", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Close(); // Закрыть форму после добавления
                    }
                    else
                    {
                        MessageBox.Show("Не удалось добавить оборудование.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                dateBase.CloseConnection();
                MessageBox.Show("Ошибка при добавлении оборудования: " + ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
