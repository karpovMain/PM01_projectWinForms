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
using System.Windows.Forms.DataVisualization.Charting;

namespace statisticRequest
{
    public partial class mainForm : Form
    {
        public mainForm()
        {
            InitializeComponent();
        }

        private void mainForm_Load(object sender, EventArgs e)
        {
            loadRequest();
            differentiationRole();
        }

        public void differentiationRole()
        {
            //для клиента: только свои заявки, только просмотр оборудования, отчётов и т.д.
            if (data.role == "client")
            {
                addRequestButton.Visible = true;
                editRequestButton.Visible = false;
                deleteRequestButton.Visible = false;

                addEquipmentButton.Visible = false;
                editEquipmentButton.Visible = false;
                deleteEquipmentButton.Visible = false;

                addClientButton.Visible = false;
                editClientButton.Visible = false;
                deleteClientButton.Visible = false;

                addSpecialistButton.Visible = false;
                editSpecialistButton.Visible = false;
                deleteSpecialistButton.Visible = false;

                addCommentButton.Visible = false;
                editCommentButton.Visible = false;
                deleteCommentButton.Visible = false;

                addReportButton.Visible = false;
                editReportButton.Visible = false;
                deleteReportButton.Visible = false;
            }
            else if (data.role == "specialist")
            {
                addRequestButton.Visible = false;
                editRequestButton.Visible = false;
                deleteRequestButton.Visible = false;

                addEquipmentButton.Visible = false;
                editEquipmentButton.Visible = false;
                deleteEquipmentButton.Visible = false;

                addClientButton.Visible = false;
                editClientButton.Visible = false;
                deleteClientButton.Visible = false;

                //для специалиста оставить только редактирование своих комментариев и отчётов
                addCommentButton.Visible = true;
                editCommentButton.Visible = true;
                deleteCommentButton.Visible = false;

                addReportButton.Visible = true;
                editReportButton.Visible = true;
                deleteReportButton.Visible = false;
            }
            // admin — полный доступ, ничего не скрываем
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (tabControl.SelectedIndex)
            {
                case 0:
                    loadRequest();
                    break;
                case 1:
                    loadComment(); 
                    break;
                case 2:
                    loadEquipment();
                    break;
                case 3:
                    loadClient();
                    break;
                case 4:
                    loadSpecialist();
                    break;
                case 5:
                    loadReport();
                    break;
                case 6:
                    loadChart();
                    break;
            }
        }

        private void ShowStatusChangedNotification(int requestId, string newStatus)
        {
            if (notifyIcon == null)
            {
                notifyIcon = new NotifyIcon();
                notifyIcon.Icon = SystemIcons.Information;
                notifyIcon.Visible = true;
                notifyIcon.BalloonTipTitle = "Статус заявки изменён";
            }

            notifyIcon.BalloonTipText = $"Статус заявки №{requestId} изменён на \"{newStatus}\"";
            notifyIcon.ShowBalloonTip(3000);
        }


        public void loadRequest()
        {
            //заполнение таблицы заявок
            dateBase.OpenConnection();
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
                            JOIN specialist sp ON a.specialist_id = sp.specialist_id";
            SqlDataAdapter adapter = new SqlDataAdapter(query, dateBase.Connection);
            DataTable table = new DataTable();
            adapter.Fill(table);
            cleanTable(table);

            requestDGV.DataSource = table;
            dateBase.CloseConnection();

            configureDGV(requestDGV);
            //выравнивание записей
            requestDGV.Columns["request_id"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            requestDGV.Columns["request_date"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            requestDGV.Columns["status_name"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            //столбцы на русском
            requestDGV.Columns["request_id"].HeaderText = "Номер заявки";
            requestDGV.Columns["request_date"].HeaderText = "Дата";
            requestDGV.Columns["client_name"].HeaderText = "Клиент";
            requestDGV.Columns["equipment_description"].HeaderText = "Оборудование";
            requestDGV.Columns["type_name"].HeaderText = "Тип ремонта";
            requestDGV.Columns["request_description"].HeaderText = "Описание";
            requestDGV.Columns["status_name"].HeaderText = "Статус";
            requestDGV.Columns["specialist_name"].HeaderText = "Специалист";
        }

        public void loadEquipment()
        {
            //заполнение таблицы оборудования
            dateBase.OpenConnection();
            string query = @"SELECT * From equipment";
            SqlDataAdapter adapter = new SqlDataAdapter(query, dateBase.Connection);
            DataTable table = new DataTable();
            adapter.Fill(table);
            cleanTable(table);

            equipmentDGV.DataSource = table;
            dateBase.CloseConnection();

            configureDGV(equipmentDGV);
            //выравнивание записей
            equipmentDGV.Columns["equipment_id"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            equipmentDGV.Columns["serial_number"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            equipmentDGV.Columns["equipment_type"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            equipmentDGV.Columns["equipment_description"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            //столбцы на русском
            equipmentDGV.Columns["equipment_id"].HeaderText = "Номер оборудования";
            equipmentDGV.Columns["serial_number"].HeaderText = "Серийный номер";
            equipmentDGV.Columns["equipment_type"].HeaderText = "Тип оборудования";
            equipmentDGV.Columns["equipment_description"].HeaderText = "Название оборудование";
        }

        public void loadClient()
        {
            //заполнение таблицы клиенты
            dateBase.OpenConnection();
            string query = @"SELECT * From client";
            SqlDataAdapter adapter = new SqlDataAdapter(query, dateBase.Connection);
            DataTable table = new DataTable();
            adapter.Fill(table);
            cleanTable(table);

            clientDGV.DataSource = table;
            dateBase.CloseConnection();

            configureDGV(clientDGV);
            //выравнивание записей
            clientDGV.Columns["client_id"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            clientDGV.Columns["full_name"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            clientDGV.Columns["email"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            clientDGV.Columns["phone"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            //столбцы на русском
            clientDGV.Columns["client_id"].HeaderText = "Номер клиента";
            clientDGV.Columns["full_name"].HeaderText = "ФИО";
            clientDGV.Columns["email"].HeaderText = "Электронная почта";
            clientDGV.Columns["phone"].HeaderText = "Номер телефона";
        }

        public void loadSpecialist()
        {
            //заполнение таблицы специалисты
            dateBase.OpenConnection();
            string query = @"SELECT * From specialist";
            SqlDataAdapter adapter = new SqlDataAdapter(query, dateBase.Connection);
            DataTable table = new DataTable();
            adapter.Fill(table);
            cleanTable(table);

            specialistDGV.DataSource = table;
            dateBase.CloseConnection();

            configureDGV(specialistDGV);
            //выравнивание записей
            specialistDGV.Columns["specialist_id"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            specialistDGV.Columns["full_name"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            specialistDGV.Columns["email"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            specialistDGV.Columns["phone"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            //столбцы на русском
            specialistDGV.Columns["specialist_id"].HeaderText = "Номер специалиста";
            specialistDGV.Columns["full_name"].HeaderText = "ФИО";
            specialistDGV.Columns["email"].HeaderText = "Электронная почта";
            specialistDGV.Columns["phone"].HeaderText = "Номер телефона";
        }

        public void loadComment()
        {
            //заполнение таблицы комментариев
            dateBase.OpenConnection();

            string query = @"
                            SELECT 
                                c.comment_id,
                                r.request_id,
                                s.full_name,
                                c.comment_description,
                                FORMAT(c.comment_date, 'dd.MM.yyyy') AS comment_date
                            FROM comment c
                            JOIN request r ON c.request_id = r.request_id
                            JOIN specialist s ON c.specialist_id = s.specialist_id;
                        ";

            SqlDataAdapter adapter = new SqlDataAdapter(query, dateBase.Connection);
            DataTable table = new DataTable();
            adapter.Fill(table);
            cleanTable(table);

            commentDGV.DataSource = table;
            dateBase.CloseConnection();

            configureDGV(commentDGV);

            //выравнивание записей
            commentDGV.Columns["comment_id"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            commentDGV.Columns["request_id"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            commentDGV.Columns["full_name"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            commentDGV.Columns["comment_date"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            //столбцы на русском
            commentDGV.Columns["comment_id"].HeaderText = "Номер комментария";
            commentDGV.Columns["request_id"].HeaderText = "Номер заявки";
            commentDGV.Columns["full_name"].HeaderText = "Специалист";
            commentDGV.Columns["comment_description"].HeaderText = "Комментарий";
            commentDGV.Columns["comment_date"].HeaderText = "Дата комментария";
        }

        public void loadReport()
        {
            //заполнение таблицы отчетов
            dateBase.OpenConnection();

            string query = @"
                            SELECT 
                                r.report_id,
                                rq.request_id,
                                s.full_name,
                                r.work_description,
                                r.time_spent,
                                r.material_cost,
                                r.total_cost,
                                FORMAT(r.report_date, 'dd.MM.yyyy') AS report_date
                            FROM report r
                            JOIN request rq ON rq.request_id = r.request_id
                            JOIN specialist s ON r.specialist_id = s.specialist_id;
                        ";

            SqlDataAdapter adapter = new SqlDataAdapter(query, dateBase.Connection);
            DataTable table = new DataTable();
            adapter.Fill(table);
            cleanTable(table);

            reportDGV.DataSource = table;
            dateBase.CloseConnection();

            configureDGV(reportDGV);

            //выравнивание записей
            reportDGV.Columns["report_id"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            reportDGV.Columns["request_id"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            reportDGV.Columns["report_date"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            reportDGV.Columns["time_spent"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            reportDGV.Columns["material_cost"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            reportDGV.Columns["total_cost"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            //столбцы на русском
            reportDGV.Columns["report_id"].HeaderText = "Номер отчета";
            reportDGV.Columns["request_id"].HeaderText = "Номер заявки";
            reportDGV.Columns["full_name"].HeaderText = "Специалист";
            reportDGV.Columns["work_description"].HeaderText = "Описание";
            reportDGV.Columns["time_spent"].HeaderText = "Потрачено времени (часы)";
            reportDGV.Columns["material_cost"].HeaderText = "Стоимость запчастей";
            reportDGV.Columns["total_cost"].HeaderText = "Стоимость работы";
            reportDGV.Columns["report_date"].HeaderText = "Дата";
        }

        public void cleanTable(DataTable table)
        {
            //убрать лишние пробелы
            foreach (DataRow row in table.Rows)
            {
                foreach (DataColumn col in table.Columns)
                {
                    if (row[col] is string str)
                        row[col] = str.Replace("\r", " ").Replace("\n", " ").Replace("\t", " ").Trim();
                }
            }
        }

        public void configureDGV(DataGridView dgv)
        {
            //цветовая тема
            dgv.EnableHeadersVisualStyles = false;
            dgv.BackgroundColor = ColorTranslator.FromHtml("#0046d1");
            dgv.GridColor = ColorTranslator.FromHtml("#568eff");
            dgv.BorderStyle = BorderStyle.None;

            //шрифт и цвет текста
            dgv.DefaultCellStyle.BackColor = ColorTranslator.FromHtml("#0046d1");
            dgv.DefaultCellStyle.ForeColor = ColorTranslator.FromHtml("#E5E5E5");
            dgv.DefaultCellStyle.Font = new Font("Tahoma", 10, FontStyle.Bold);
            dgv.DefaultCellStyle.SelectionBackColor = ColorTranslator.FromHtml("#568eff");
            dgv.DefaultCellStyle.SelectionForeColor = Color.White;

            //заголовки
            dgv.ColumnHeadersDefaultCellStyle.BackColor = ColorTranslator.FromHtml("#0046d1");
            dgv.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dgv.ColumnHeadersDefaultCellStyle.Font = new Font("Tahoma", 10, FontStyle.Bold);
            dgv.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dgv.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            //авторазмер
            dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgv.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dgv.DefaultCellStyle.Alignment = DataGridViewContentAlignment.TopLeft;
            dgv.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            dgv.RowHeadersVisible = false;
        }

        private void searchTextBox_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(searchRequestTextBox.Text) || filterRequestComboBox.SelectedItem == null)
            {
                (requestDGV.DataSource as DataTable).DefaultView.RowFilter = "";
                return;
            }

            string filterColumn = "";
            bool needsConvert = false;

            switch (filterRequestComboBox.SelectedItem.ToString())
            {
                case "По номеру заявки":
                    filterColumn = "request_id";
                    needsConvert = true;
                    break;
                case "По клиенту":
                    filterColumn = "client_name";
                    break;
                case "По оборудованию":
                    filterColumn = "equipment_description";
                    break;
                case "По статусу":
                    filterColumn = "status_name";
                    break;
            }

            string searchText = searchRequestTextBox.Text.Trim().Replace("'", "''");

            string filterExpression = needsConvert
                ? $"Convert({filterColumn}, 'System.String') LIKE '%{searchText}%'"
                : $"{filterColumn} LIKE '%{searchText}%'";

            (requestDGV.DataSource as DataTable).DefaultView.RowFilter = filterExpression;
        }

        private void searchCommentTextBox_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(searchCommentTextBox.Text) || filterCommentComboBox.SelectedItem == null)
            {
                (commentDGV.DataSource as DataTable).DefaultView.RowFilter = "";
                return;
            }

            string filterColumn = "";
            bool needsConvert = false;

            switch (filterCommentComboBox.SelectedItem.ToString())
            {
                case "По номеру комментария":
                    filterColumn = "comment_id";
                    needsConvert = true;
                    break;
                case "По номеру заявки":
                    filterColumn = "request_id";
                    needsConvert = true;
                    break;
                case "По ФИО":
                    filterColumn = "full_name";
                    break;
            }

            string searchText = searchCommentTextBox.Text.Trim().Replace("'", "''");

            string filterExpression = needsConvert
                ? $"Convert({filterColumn}, 'System.String') LIKE '%{searchText}%'"
                : $"{filterColumn} LIKE '%{searchText}%'";

            (commentDGV.DataSource as DataTable).DefaultView.RowFilter = filterExpression;
        }

        private void searchEquipmentTextBox_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(searchEquipmentTextBox.Text) || filterEquipmentComboBox.SelectedItem == null)
            {
                (equipmentDGV.DataSource as DataTable).DefaultView.RowFilter = "";
                return;
            }

            string filterColumn = "";
            bool needsConvert = false;

            switch (filterEquipmentComboBox.SelectedItem.ToString())
            {
                case "По номеру оборудования":
                    filterColumn = "equipment_id";
                    needsConvert = true;
                    break;
                case "По серийному номеру":
                    filterColumn = "serial_number";
                    break;
                case "По типу оборудования":
                    filterColumn = "equipment_type";
                    break;
                case "По названию":
                    filterColumn = "equipment_description";
                    break;
            }

            string searchText = searchEquipmentTextBox.Text.Trim().Replace("'", "''");

            string filterExpression = needsConvert
                ? $"Convert({filterColumn}, 'System.String') LIKE '%{searchText}%'"
                : $"{filterColumn} LIKE '%{searchText}%'";

            (equipmentDGV.DataSource as DataTable).DefaultView.RowFilter = filterExpression;
        }

        private void searchClientTextBox_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(searchClientTextBox.Text) || filterClientComboBox.SelectedItem == null)
            {
                (clientDGV.DataSource as DataTable).DefaultView.RowFilter = "";
                return;
            }

            string filterColumn = "";
            bool needsConvert = false;

            switch (filterClientComboBox.SelectedItem.ToString())
            {
                case "По номеру клиента":
                    filterColumn = "client_id";
                    needsConvert = true;
                    break;
                case "По ФИО":
                    filterColumn = "full_name";
                    break;
                case "По электронной почте":
                    filterColumn = "email";
                    break;
                case "По номеру телефона":
                    filterColumn = "phone";
                    break;
            }

            string searchText = searchClientTextBox.Text.Trim().Replace("'", "''");

            string filterExpression = needsConvert
                ? $"Convert({filterColumn}, 'System.String') LIKE '%{searchText}%'"
                : $"{filterColumn} LIKE '%{searchText}%'";

            (clientDGV.DataSource as DataTable).DefaultView.RowFilter = filterExpression;
        }

        private void searchSpecialistTextBox_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(searchSpecialistTextBox.Text) || filterSpecialistComboBox.SelectedItem == null)
            {
                (specialistDGV.DataSource as DataTable).DefaultView.RowFilter = "";
                return;
            }

            string filterColumn = "";
            bool needsConvert = false;

            switch (filterSpecialistComboBox.SelectedItem.ToString())
            {
                case "По номеру специалиста":
                    filterColumn = "specialist_id";
                    needsConvert = true;
                    break;
                case "По ФИО":
                    filterColumn = "full_name";
                    break;
                case "По электронной почте":
                    filterColumn = "email";
                    break;
                case "По номеру телефона":
                    filterColumn = "phone";
                    break;
            }

            string searchText = searchSpecialistTextBox.Text.Trim().Replace("'", "''");

            string filterExpression = needsConvert
                ? $"Convert({filterColumn}, 'System.String') LIKE '%{searchText}%'"
                : $"{filterColumn} LIKE '%{searchText}%'";

            (specialistDGV.DataSource as DataTable).DefaultView.RowFilter = filterExpression;
        }

        private void addRequestButton_Click(object sender, EventArgs e)
        {
            addRequest addRequestForm = new addRequest();
            addRequestForm.FormClosed += (s, args) => loadRequest();
            addRequestForm.ShowDialog();
        }

        private void editRequestButton_Click(object sender, EventArgs e)
        {
            if (data.indexRequest == 0)
            {
                MessageBox.Show("Пожалуйста, выберите запись для редактирования.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            editRequest editRequestForm = new editRequest();
            editRequestForm.StatusUpdated += (s, args) =>
            {
                var eventData = (StatusUpdatedEventArgs)args;
                ShowStatusChangedNotification(eventData.RequestId, eventData.NewStatus);
                loadRequest();
            };
            editRequestForm.ShowDialog();
        }

        private void requestDGV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int idIndex = (int)requestDGV.Rows[e.RowIndex].Cells[0].Value;
            data.indexRequest = idIndex;
        }

        private void deleteRequestButton_Click(object sender, EventArgs e)
        {
            if (data.indexRequest == 0)
            {
                MessageBox.Show("Пожалуйста, выберите заявку для удаления.", "Удаление", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DialogResult result = MessageBox.Show(
                $"Вы уверены, что хотите удалить заявку №{data.indexRequest}?",
                "Подтверждение удаления",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (result == DialogResult.Yes)
            {
                try
                {
                    dateBase.OpenConnection();

                    string query = "DELETE FROM request WHERE request_id = @id";
                    using (SqlCommand cmd = new SqlCommand(query, dateBase.Connection))
                    {
                        cmd.Parameters.AddWithValue("@id", data.indexRequest);
                        int affectedRows = cmd.ExecuteNonQuery();

                        if (affectedRows > 0)
                        {
                            MessageBox.Show("Заявка успешно удалена.", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("Заявка не найдена или уже удалена.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }

                    dateBase.CloseConnection();

                    loadRequest();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ошибка при удалении заявки: " + ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    dateBase.CloseConnection();
                }
            }
        }

        private void addEquipmentButton_Click(object sender, EventArgs e)
        {
            addEquipment addEquipmentForm = new addEquipment();
            addEquipmentForm.FormClosed += (s, args) => loadEquipment();
            addEquipmentForm.ShowDialog();
        }

        private void editEquipmentButton_Click(object sender, EventArgs e)
        {
            if (data.indexEquipment == 0)
            {
                MessageBox.Show("Пожалуйста, выберите запись для редактирования.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            editEquipment editEquipmentForm = new editEquipment();
            editEquipmentForm.FormClosed += (s, args) => loadEquipment();
            editEquipmentForm.ShowDialog();
        }

        private void equipmentDGV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int idIndex = (int)equipmentDGV.Rows[e.RowIndex].Cells[0].Value;
            data.indexEquipment = idIndex;
        }

        private void deleteEquipmentButton_Click(object sender, EventArgs e)
        {
            if (data.indexEquipment == 0)
            {
                MessageBox.Show("Пожалуйста, выберите оборудование для удаления.", "Удаление", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DialogResult result = MessageBox.Show(
                $"Вы уверены, что хотите удалить оборудование №{data.indexEquipment}?",
                "Подтверждение удаления",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (result == DialogResult.Yes)
            {
                try
                {
                    dateBase.OpenConnection();

                    string query = "DELETE FROM equipment WHERE equipment_id = @id";
                    using (SqlCommand cmd = new SqlCommand(query, dateBase.Connection))
                    {
                        cmd.Parameters.AddWithValue("@id", data.indexEquipment);
                        int affectedRows = cmd.ExecuteNonQuery();

                        if (affectedRows > 0)
                        {
                            MessageBox.Show("Оборудование успешно удалено.", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("Не удалось удалить оборудование.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }

                    dateBase.CloseConnection();

                    loadEquipment();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ошибка при удалении оборудования: " + ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    dateBase.CloseConnection();
                }
            }
        }

        private void addClientButton_Click(object sender, EventArgs e)
        {
            addClient addClientForm = new addClient();
            addClientForm.FormClosed += (s, args) => loadClient();
            addClientForm.ShowDialog();
        }

        private void editClientButton_Click(object sender, EventArgs e)
        {
            if (data.indexClient == 0)
            {
                MessageBox.Show("Пожалуйста, выберите запись для редактирования.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            editClient editClientForm = new editClient();
            editClientForm.FormClosed += (s, args) => loadClient();
            editClientForm.ShowDialog();
        }

        private void clientDGV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int idIndex = (int)clientDGV.Rows[e.RowIndex].Cells[0].Value;
            data.indexClient = idIndex;
        }

        private void deleteClientButton_Click(object sender, EventArgs e)
        {
            if (data.indexClient == 0)
            {
                MessageBox.Show("Пожалуйста, выберите клиента для удаления.", "Удаление", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DialogResult result = MessageBox.Show(
                $"Вы уверены, что хотите удалить клиента №{data.indexClient}?",
                "Подтверждение удаления",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (result == DialogResult.Yes)
            {
                try
                {
                    dateBase.OpenConnection();

                    string query = "DELETE FROM client WHERE client_id = @id";
                    using (SqlCommand cmd = new SqlCommand(query, dateBase.Connection))
                    {
                        cmd.Parameters.AddWithValue("@id", data.indexClient);
                        int affectedRows = cmd.ExecuteNonQuery();

                        if (affectedRows > 0)
                        {
                            MessageBox.Show("Клиент успешно удален.", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("Клиент не найден или уже удален.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }

                    dateBase.CloseConnection();

                    loadClient();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ошибка при удалении клиента: " + ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    dateBase.CloseConnection();
                }
            }
        }

        private void addSpecialistButton_Click(object sender, EventArgs e)
        {
            addSpecialist addSpecialistForm = new addSpecialist();
            addSpecialistForm.FormClosed += (s, args) => loadSpecialist();
            addSpecialistForm.ShowDialog();
        }

        private void specialistDGV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int idIndex = (int)specialistDGV.Rows[e.RowIndex].Cells[0].Value;
            data.indexSpecialist = idIndex;
        }

        private void editSpecialistButton_Click(object sender, EventArgs e)
        {
            if (data.indexSpecialist == 0)
            {
                MessageBox.Show("Пожалуйста, выберите запись для редактирования.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            editSpecialist editSpecialistForm = new editSpecialist();
            editSpecialistForm.FormClosed += (s, args) => loadSpecialist();
            editSpecialistForm.ShowDialog();
        }

        private void deleteSpecialistButton_Click(object sender, EventArgs e)
        {
            if (data.indexSpecialist == 0)
            {
                MessageBox.Show("Пожалуйста, выберите специалиста для удаления.", "Удаление", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DialogResult result = MessageBox.Show(
                $"Вы уверены, что хотите удалить специалиста №{data.indexSpecialist}?",
                "Подтверждение удаления",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (result == DialogResult.Yes)
            {
                try
                {
                    dateBase.OpenConnection();

                    string query = "DELETE FROM specialist WHERE specialist_id = @id";
                    using (SqlCommand cmd = new SqlCommand(query, dateBase.Connection))
                    {
                        cmd.Parameters.AddWithValue("@id", data.indexSpecialist);
                        int affectedRows = cmd.ExecuteNonQuery();

                        if (affectedRows > 0)
                        {
                            MessageBox.Show("Специалист успешно удален.", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("Специалист не найден или уже удален.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }

                    dateBase.CloseConnection();

                    loadSpecialist();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ошибка при удалении специалиста: " + ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    dateBase.CloseConnection();
                }
            }
        }

        private void addCommentButton_Click(object sender, EventArgs e)
        {
            addComment addCommentForm = new addComment();
            addCommentForm.FormClosed += (s, args) => loadComment();
            addCommentForm.ShowDialog();
        }

        private void commentDGV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int idIndex = (int)commentDGV.Rows[e.RowIndex].Cells[0].Value;
            data.indexComment = idIndex;
        }

        private void editCommentButton_Click(object sender, EventArgs e)
        {
            if (data.indexComment == 0)
            {
                MessageBox.Show("Пожалуйста, выберите запись для редактирования.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            editComment editCommentForm = new editComment();
            editCommentForm.FormClosed += (s, args) => loadComment();
            editCommentForm.ShowDialog();
        }

        private void deleteCommentButton_Click(object sender, EventArgs e)
        {
            if (data.indexComment == 0)
            {
                MessageBox.Show("Пожалуйста, выберите комментарий для удаления.", "Удаление", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DialogResult result = MessageBox.Show(
                $"Вы уверены, что хотите удалить комментарий №{data.indexComment}?",
                "Подтверждение удаления",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (result == DialogResult.Yes)
            {
                try
                {
                    dateBase.OpenConnection();

                    string query = "DELETE FROM comment WHERE comment_id = @id";
                    using (SqlCommand cmd = new SqlCommand(query, dateBase.Connection))
                    {
                        cmd.Parameters.AddWithValue("@id", data.indexComment);
                        int affectedRows = cmd.ExecuteNonQuery();

                        if (affectedRows > 0)
                        {
                            MessageBox.Show("Комментарий успешно удален.", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("Комментарий не найден или уже удален.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }

                    dateBase.CloseConnection();

                    loadComment();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ошибка при удалении комментария: " + ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    dateBase.CloseConnection();
                }
            }
        }

        private void searchReportTextBox_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(searchReportTextBox.Text) || filterReportComboBox.SelectedItem == null)
            {
                (reportDGV.DataSource as DataTable).DefaultView.RowFilter = "";
                return;
            }

            string filterColumn = "";
            bool needsConvert = false;

            switch (filterReportComboBox.SelectedItem.ToString())
            {
                case "По номеру отчета":
                    filterColumn = "report_id";
                    needsConvert = true;
                    break;
                case "По номеру заявки":
                    filterColumn = "request_id";
                    needsConvert = true;
                    break;
                case "По ФИО":
                    filterColumn = "full_name";
                    break;
            }

            string searchText = searchReportTextBox.Text.Trim().Replace("'", "''");

            string filterExpression = needsConvert
                ? $"Convert({filterColumn}, 'System.String') LIKE '%{searchText}%'"
                : $"{filterColumn} LIKE '%{searchText}%'";

            (reportDGV.DataSource as DataTable).DefaultView.RowFilter = filterExpression;
        }

        private void addReportButton_Click(object sender, EventArgs e)
        {
            addReport addReportForm = new addReport();
            addReportForm.FormClosed += (s, args) => loadReport();
            addReportForm.ShowDialog();
        }

        private void reportDGV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int idIndex = (int)reportDGV.Rows[e.RowIndex].Cells[0].Value;
            data.indexReport = idIndex;
        }

        private void editReportButton_Click(object sender, EventArgs e)
        {
            if (data.indexReport == 0)
            {
                MessageBox.Show("Пожалуйста, выберите запись для редактирования.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            editReport editReportForm = new editReport();
            editReportForm.FormClosed += (s, args) => loadReport();
            editReportForm.ShowDialog();
        }

        private void deleteReportButton_Click(object sender, EventArgs e)
        {
            if (data.indexReport == 0)
            {
                MessageBox.Show("Пожалуйста, выберите отчет для удаления.", "Удаление", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DialogResult result = MessageBox.Show(
                $"Вы уверены, что хотите удалить отчет №{data.indexReport}?",
                "Подтверждение удаления",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (result == DialogResult.Yes)
            {
                try
                {
                    dateBase.OpenConnection();

                    string query = "DELETE FROM report WHERE report_id = @id";
                    using (SqlCommand cmd = new SqlCommand(query, dateBase.Connection))
                    {
                        cmd.Parameters.AddWithValue("@id", data.indexReport);
                        int affectedRows = cmd.ExecuteNonQuery();

                        if (affectedRows > 0)
                        {
                            MessageBox.Show("Отчет успешно удален.", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("Отчет не найден или уже удален.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }

                    dateBase.CloseConnection();

                    loadReport();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ошибка при удалении отчета: " + ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    dateBase.CloseConnection();
                }
            }
        }

        public void loadChart()
        {
            dateBase.OpenConnection();
            chartValuesListView.Items.Clear();
            chartValuesListView.Columns.Clear();
            chartValuesListView.View = View.Details;
            chartValuesListView.Columns.Add("Тип", 200);
            chartValuesListView.Columns.Add("Количество", 125);
            //количество выполненных заявок
            string completedQuery = "SELECT COUNT(*) FROM request WHERE status_id = (SELECT status_id FROM status WHERE status_name = 'Выполнено')";
            SqlCommand cmd1 = new SqlCommand(completedQuery, dateBase.Connection);
            int count = (int)cmd1.ExecuteScalar();
            completedCountLabel.Text = $"Выполненные заявки: {count}";

            //среднее время
            string avgTimeQuery = "SELECT AVG(time_spent) FROM report";
            SqlCommand cmd2 = new SqlCommand(avgTimeQuery, dateBase.Connection);
            object result = cmd2.ExecuteScalar();
            float avgTime = result != DBNull.Value ? Convert.ToSingle(result) : 0;
            avgTimeLabel.Text = $"Среднее время выполнения заявок: {avgTime:F1} ч.";

            //график типов
            chartFaultStats.Series["Типы"].Points.Clear();
            chartValuesListView.Items.Clear();

            Color[] colors = new Color[]
            {
                Color.FromArgb(68, 114, 196),
                Color.FromArgb(237, 125, 49),
                Color.FromArgb(165, 165, 165),
                Color.FromArgb(255, 192, 0),
                Color.FromArgb(112, 173, 71),
                Color.FromArgb(255, 99, 132),
                Color.FromArgb(70, 130, 180),
                Color.FromArgb(255, 168, 1)
            };

            string chartQuery = @"SELECT ft.type_name, COUNT(*) AS count
                                  FROM request r
                                  JOIN fault_type ft ON r.type_id = ft.fault_type_id
                                  GROUP BY ft.type_name";
            SqlCommand cmd3 = new SqlCommand(chartQuery, dateBase.Connection);
            using (SqlDataReader reader = cmd3.ExecuteReader())
            {
                int colorIndex = 0;
                while (reader.Read())
                {
                    string typeName = reader["type_name"].ToString();
                    int value = Convert.ToInt32(reader["count"]);

                    int pointIndex = chartFaultStats.Series["Типы"].Points.AddXY(typeName, value);

                    chartFaultStats.Series["Типы"].Points[pointIndex].Color = colors[colorIndex % colors.Length];

                    var item = new ListViewItem(typeName);
                    item.SubItems.Add(value.ToString());
                    chartValuesListView.Items.Add(item);

                    colorIndex++;
                }
            }
            dateBase.CloseConnection();
        }
    }
}
