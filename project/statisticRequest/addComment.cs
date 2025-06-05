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
    public partial class addComment : Form
    {
        public addComment()
        {
            InitializeComponent();
        }

        private void addComment_Load(object sender, EventArgs e)
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
            if (!DateTime.TryParse(maskedTextBoxDate.Text, out DateTime commentDate))
            {
                MessageBox.Show("Введите корректную дату.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (comboBoxRequest.SelectedItem == null || comboBoxSpecialist.SelectedItem == null || string.IsNullOrWhiteSpace(richTextBoxComment.Text))
            {
                MessageBox.Show("Пожалуйста, заполните все поля.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int requestId = Convert.ToInt32(comboBoxRequest.SelectedItem.ToString());
            int specialistId = 0;
            string commentText = richTextBoxComment.Text.Trim();

            dateBase.OpenConnection();

            string querySpecialistId = $@"SELECT specialist_id FROM specialist WHERE full_name = '{comboBoxSpecialist.SelectedItem.ToString()}'";
            using (var cmd = new SqlCommand(querySpecialistId, dateBase.Connection))
            specialistId = (int)cmd.ExecuteScalar();

            try
            {
                string query = @"
                                INSERT INTO comment (request_id, specialist_id, comment_description, comment_date)
                                VALUES (@request_id, @specialist_id, @description, @comment_date);
                ";

                SqlCommand command = new SqlCommand(query, dateBase.Connection);
                command.Parameters.AddWithValue("@request_id", requestId);
                command.Parameters.AddWithValue("@specialist_id", specialistId);
                command.Parameters.AddWithValue("@description", commentText);
                command.Parameters.AddWithValue("@comment_date", commentDate);

                int result = command.ExecuteNonQuery();

                if (result > 0)
                {
                    MessageBox.Show("Комментарий успешно добавлен!", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Ошибка при добавлении комментария.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка при добавлении комментария: " + ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                dateBase.CloseConnection();
            }
        }
    }
}
