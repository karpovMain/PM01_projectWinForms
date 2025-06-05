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
    public partial class addRequest : Form
    {
        public addRequest()
        {
            InitializeComponent();

        }

        private void addRequest_Load(object sender, EventArgs e)
        {
            loadComboBox();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            if (!DateTime.TryParse(maskedTextBoxDate.Text, out DateTime requestDate))
            {
                MessageBox.Show("Введите корректную дату.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (comboBoxClient.SelectedItem == null || comboBoxEquipment.SelectedItem == null ||
                comboBoxType.SelectedItem == null || comboBoxStatus.SelectedItem == null || comboBoxSpecialist.SelectedItem == null)
            {
                MessageBox.Show("Пожалуйста, заполните все поля.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string description = richTextBoxDescription.Text.Trim();

            string clientName = comboBoxClient.SelectedItem.ToString();
            string equipmentDesc = comboBoxEquipment.SelectedItem.ToString();
            string typeName = comboBoxType.SelectedItem.ToString();
            string statusName = comboBoxStatus.SelectedItem.ToString();
            string specialistName = comboBoxSpecialist.SelectedItem.ToString();

            dateBase.OpenConnection();

            try
            {
                int clientId = GetIdByName("client", "full_name", clientName);
                int equipmentId = GetIdByName("equipment", "equipment_description", equipmentDesc);
                int typeId = GetIdByName("fault_type", "type_name", typeName);
                int statusId = GetIdByName("status", "status_name", statusName);
                int specialistId = GetIdByName("specialist", "full_name", specialistName);

                string insertQuery = @"INSERT INTO request 
                                        (request_date, client_id, equipment_id, type_id, request_description, status_id, specialist_id)
                                        VALUES (@date, @client, @equipment, @type, @desc, @status, @spec)";

                using (SqlCommand cmd = new SqlCommand(insertQuery, dateBase.Connection))
                {
                    cmd.Parameters.AddWithValue("@date", requestDate);
                    cmd.Parameters.AddWithValue("@client", clientId);
                    cmd.Parameters.AddWithValue("@equipment", equipmentId);
                    cmd.Parameters.AddWithValue("@type", typeId);
                    cmd.Parameters.AddWithValue("@desc", description);
                    cmd.Parameters.AddWithValue("@status", statusId);
                    cmd.Parameters.AddWithValue("@spec", specialistId);

                    cmd.ExecuteNonQuery();
                }

                MessageBox.Show("Заявка успешно добавлена.", "Успешно", MessageBoxButtons.OK, MessageBoxIcon.Information);
                
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка при добавлении заявки: " + ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                dateBase.CloseConnection();
            }
        }

        private int GetIdByName(string table, string column, string value)
        {
            string query = $"SELECT {table}_id FROM {table} WHERE {column} = @value";
            using (SqlCommand cmd = new SqlCommand(query, dateBase.Connection))
            {
                cmd.Parameters.AddWithValue("@value", value);
                object result = cmd.ExecuteScalar();
                if (result != null && int.TryParse(result.ToString(), out int id))
                    return id;
                else
                    throw new Exception($"Не удалось найти ID для {value} в таблице {table}.");
            }
        }


        public void loadComboBox()
        {
            comboBoxClient.Items.Clear();
            comboBoxEquipment.Items.Clear();
            comboBoxSpecialist.Items.Clear();
            comboBoxStatus.Items.Clear();
            comboBoxType.Items.Clear();

            dateBase.OpenConnection();

            string queryClient = "SELECT full_name FROM client";
            using (var cmd = new SqlCommand(queryClient, dateBase.Connection))
            using (var rdr = cmd.ExecuteReader())
            {
                while (rdr.Read())
                    comboBoxClient.Items.Add(rdr["full_name"].ToString());
            }

            string queryEquipment = "SELECT equipment_description FROM equipment";
            using (var cmd = new SqlCommand(queryEquipment, dateBase.Connection))
            using (var rdr = cmd.ExecuteReader())
            {
                while (rdr.Read())
                    comboBoxEquipment.Items.Add(rdr["equipment_description"].ToString());
            }

            string querySpecialist = "SELECT full_name FROM specialist";
            using (var cmd = new SqlCommand(querySpecialist, dateBase.Connection))
            using (var rdr = cmd.ExecuteReader())
            {
                while (rdr.Read())
                    comboBoxSpecialist.Items.Add(rdr["full_name"].ToString());
            }

            string queryStatus = "SELECT status_name FROM status";
            using (var cmd = new SqlCommand(queryStatus, dateBase.Connection))
            using (var rdr = cmd.ExecuteReader())
            {
                while (rdr.Read())
                    comboBoxStatus.Items.Add(rdr["status_name"].ToString());
            }

            string queryType = "SELECT type_name FROM fault_type";
            using (var cmd = new SqlCommand(queryType, dateBase.Connection))
            using (var rdr = cmd.ExecuteReader())
            {
                while (rdr.Read())
                    comboBoxType.Items.Add(rdr["type_name"].ToString());
            }

            dateBase.CloseConnection();
        }
    }
}
