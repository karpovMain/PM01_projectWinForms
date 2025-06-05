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
    public partial class editRequest : Form
    {
        public event EventHandler<StatusUpdatedEventArgs> StatusUpdated;
        public string oldStatus = "";
        public editRequest()
        {
            InitializeComponent();
        }

        private void editRequest_Load(object sender, EventArgs e)
        {
            loadComboBox();
            loadComponent();
            oldStatus = comboBoxStatus.Text;
        }

        public void loadComponent()
        {
            string query = @"SELECT 
                        a.request_id,
                        a.request_date,
                        c.full_name AS client_name,
                        e.equipment_description,
                        rt.type_name,
                        a.request_description,
                        s.status_name,
                        sp.full_name AS specialist_name
                    FROM 
                        request a
                    JOIN client c ON a.client_id = c.client_id
                    JOIN equipment e ON a.equipment_id = e.equipment_id
                    JOIN fault_type rt ON a.type_id = rt.fault_type_id
                    JOIN status s ON a.status_id = s.status_id
                    JOIN specialist sp ON a.specialist_id = sp.specialist_id
                    WHERE a.request_id = @id";

            using (SqlCommand cmd = new SqlCommand(query, dateBase.Connection))
            {
                cmd.Parameters.AddWithValue("@id", data.indexRequest);

                dateBase.OpenConnection();

                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        //устанавливаем значения в элементы формы
                        maskedTextBoxDate.Text = Convert.ToDateTime(reader["request_date"]).ToString("dd.MM.yyyy");

                        comboBoxClient.SelectedItem = reader["client_name"].ToString();
                        comboBoxEquipment.SelectedItem = reader["equipment_description"].ToString();
                        comboBoxType.SelectedItem = reader["type_name"].ToString();
                        comboBoxStatus.SelectedItem = reader["status_name"].ToString();
                        comboBoxSpecialist.SelectedItem = reader["specialist_name"].ToString();

                        richTextBoxDescription.Text = reader["request_description"].ToString();
                    }
                }

                dateBase.CloseConnection();
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

        private void buttonEdit_Click(object sender, EventArgs e)
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

            string newStatus = comboBoxStatus.Text;

            try
            {
                dateBase.OpenConnection();

                // Получаем ID из значений ComboBox'ов
                int clientId = GetIdByValue("client", "client_id", "full_name", comboBoxClient.SelectedItem.ToString());
                int equipmentId = GetIdByValue("equipment", "equipment_id", "equipment_description", comboBoxEquipment.SelectedItem.ToString());
                int typeId = GetIdByValue("fault_type", "fault_type_id", "type_name", comboBoxType.SelectedItem.ToString());
                int statusId = GetIdByValue("status", "status_id", "status_name", comboBoxStatus.SelectedItem.ToString());
                int specialistId = GetIdByValue("specialist", "specialist_id", "full_name", comboBoxSpecialist.SelectedItem.ToString());

                string updateQuery = @"UPDATE request 
                               SET 
                                   request_date = @date,
                                   client_id = @clientId,
                                   equipment_id = @equipmentId,
                                   type_id = @typeId,
                                   request_description = @description,
                                   status_id = @statusId,
                                   specialist_id = @specialistId
                               WHERE request_id = @requestId";

                using (SqlCommand cmd = new SqlCommand(updateQuery, dateBase.Connection))
                {
                    cmd.Parameters.AddWithValue("@date", requestDate);
                    cmd.Parameters.AddWithValue("@clientId", clientId);
                    cmd.Parameters.AddWithValue("@equipmentId", equipmentId);
                    cmd.Parameters.AddWithValue("@typeId", typeId);
                    cmd.Parameters.AddWithValue("@description", richTextBoxDescription.Text.Trim());
                    cmd.Parameters.AddWithValue("@statusId", statusId);
                    cmd.Parameters.AddWithValue("@specialistId", specialistId);
                    cmd.Parameters.AddWithValue("@requestId", data.indexRequest);

                    int rows = cmd.ExecuteNonQuery();
                    if (rows > 0)
                    {
                        MessageBox.Show("Заявка успешно обновлена!", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Не удалось обновить заявку.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                    if (newStatus != oldStatus)
                    {
                        int requestId = data.indexRequest;
                        StatusUpdated?.Invoke(this, new StatusUpdatedEventArgs(requestId, newStatus));
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка: " + ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                dateBase.CloseConnection();
            }
        }

        private int GetIdByValue(string table, string idColumn, string nameColumn, string value)
        {
            string query = $"SELECT {idColumn} FROM {table} WHERE {nameColumn} = @value";

            using (SqlCommand cmd = new SqlCommand(query, dateBase.Connection))
            {
                cmd.Parameters.AddWithValue("@value", value);
                object result = cmd.ExecuteScalar();
                if (result != null)
                    return Convert.ToInt32(result);
                else
                    throw new Exception($"Не найдено значение '{value}' в таблице {table}");
            }
        }

    }

    public class StatusUpdatedEventArgs : EventArgs
    {
        public int RequestId { get; }
        public string NewStatus { get; }

        public StatusUpdatedEventArgs(int requestId, string newStatus)
        {
            RequestId = requestId;
            NewStatus = newStatus;
        }
    }

}
