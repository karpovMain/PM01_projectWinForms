using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace statisticRequest
{
    public partial class addReport : Form
    {
        public addReport()
        {
            InitializeComponent();
        }

        private void addReport_Load(object sender, EventArgs e)
        {
            loadComboBox();
        }

        public void loadComboBox()
        {
            comboBoxRequest.Items.Clear();
            comboBoxSpecialist.Items.Clear();

            dateBase.OpenConnection();

            string queryRequest = "SELECT request_id FROM request";
            using (var cmd = new SqlCommand(queryRequest, dateBase.Connection))
            using (var rdr = cmd.ExecuteReader())
            {
                while (rdr.Read())
                    comboBoxRequest.Items.Add(rdr["request_id"].ToString());
            }

            string querySpecialist = "SELECT full_name FROM specialist";
            using (var cmd = new SqlCommand(querySpecialist, dateBase.Connection))
            using (var rdr = cmd.ExecuteReader())
            {
                while (rdr.Read())
                    comboBoxSpecialist.Items.Add(rdr["full_name"].ToString());
            }

            dateBase.CloseConnection();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            if (!DateTime.TryParse(maskedTextBoxDate.Text, out DateTime reportDate))
            {
                MessageBox.Show("Введите корректную дату.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (comboBoxRequest.SelectedItem == null ||
                comboBoxSpecialist.SelectedItem == null ||
                string.IsNullOrWhiteSpace(richTextBoxDescription.Text) ||
                string.IsNullOrWhiteSpace(textBoxTime.Text) ||
                string.IsNullOrWhiteSpace(textBoxMaterial.Text) ||
                string.IsNullOrWhiteSpace(textBoxTotal.Text))
            {
                MessageBox.Show("Пожалуйста, заполните все поля.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            CultureInfo culture = new CultureInfo("ru-RU");

            if (!float.TryParse(textBoxTime.Text, NumberStyles.Float, culture, out float timeSpent) ||
                !float.TryParse(textBoxMaterial.Text, NumberStyles.Float, culture, out float materialCost) ||
                !float.TryParse(textBoxTotal.Text, NumberStyles.Float, culture, out float totalCost))
            {
                MessageBox.Show("Введите корректные числовые значения для времени, стоимости запчастей и стоимости работы.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int requestId = Convert.ToInt32(comboBoxRequest.SelectedItem.ToString());
            int specialistId = 0;
            string workDescription = richTextBoxDescription.Text.Trim();

            dateBase.OpenConnection();

            string querySpecialistId = $@"SELECT specialist_id FROM specialist WHERE full_name = '{comboBoxSpecialist.SelectedItem.ToString()}'";
            using (var cmd = new SqlCommand(querySpecialistId, dateBase.Connection))
            specialistId = (int)cmd.ExecuteScalar();

            try
            {
                string query = @"INSERT INTO report 
                                    (request_id, specialist_id, work_description, time_spent, material_cost, total_cost, report_date)
                                 VALUES 
                                    (@request_id, @specialist_id, @work_description, @time_spent, @material_cost, @total_cost, @report_date);";

                SqlCommand command = new SqlCommand(query, dateBase.Connection);
                command.Parameters.AddWithValue("@request_id", requestId);
                command.Parameters.AddWithValue("@specialist_id", specialistId);
                command.Parameters.AddWithValue("@work_description", workDescription);
                command.Parameters.AddWithValue("@time_spent", timeSpent);
                command.Parameters.AddWithValue("@material_cost", materialCost);
                command.Parameters.AddWithValue("@total_cost", totalCost);
                command.Parameters.AddWithValue("@report_date", reportDate);

                int result = command.ExecuteNonQuery();

                if (result > 0)
                {
                    MessageBox.Show("Отчет успешно добавлен!", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Ошибка при добавлении отчета.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка при добавлении отчета: " + ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                dateBase.CloseConnection();
            }
        }
    }
}
