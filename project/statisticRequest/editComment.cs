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
    public partial class editComment : Form
    {
        public editComment()
        {
            InitializeComponent();
        }

        private void editComment_Load(object sender, EventArgs e)
        {
            loadComboBox();
            loadComponent();
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

        public void loadComponent()
        {
            string query = @"
                            SELECT 
                                c.comment_id,
                                r.request_id,
                                s.full_name,
                                c.comment_description,
                                FORMAT(c.comment_date, 'dd.MM.yyyy') AS comment_date
                            FROM comment c
                            JOIN request r ON c.request_id = r.request_id
                            JOIN specialist s ON c.specialist_id = s.specialist_id
                            WHERE c.comment_id = @id;
            ";

            using (SqlCommand cmd = new SqlCommand(query, dateBase.Connection))
            {
                cmd.Parameters.AddWithValue("@id", data.indexComment);

                dateBase.OpenConnection();

                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        //устанавливаем значения в элементы формы
                        maskedTextBoxDate.Text = Convert.ToDateTime(reader["comment_date"]).ToString("dd.MM.yyyy");
                        comboBoxRequest.SelectedItem = reader["request_id"].ToString();
                        comboBoxSpecialist.SelectedItem = reader["full_name"].ToString();
                        richTextBoxComment.Text = reader["comment_description"].ToString();
                    }
                }

                dateBase.CloseConnection();
            }
        }

        private void buttonEdit_Click(object sender, EventArgs e)
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

            dateBase.OpenConnection();

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
                                UPDATE comment
                                SET
                                    request_id = @request_id,
                                    specialist_id = @specialist_id,
                                    comment_description = @description,
                                    comment_date = @comment_date
                                WHERE comment_id = @id;
                ";

                SqlCommand command = new SqlCommand(query, dateBase.Connection);
                command.Parameters.AddWithValue("@request_id", requestId);
                command.Parameters.AddWithValue("@specialist_id", specialistId);
                command.Parameters.AddWithValue("@description", commentText);
                command.Parameters.AddWithValue("@comment_date", commentDate);
                command.Parameters.AddWithValue("@id", data.indexComment);

                int result = command.ExecuteNonQuery();

                if (result > 0)
                {
                    MessageBox.Show("Комментарий успешно обновлен!", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Ошибка при обновлении комментария.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка при обновлении комментария: " + ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                dateBase.CloseConnection();
            }
        }
    }
}
