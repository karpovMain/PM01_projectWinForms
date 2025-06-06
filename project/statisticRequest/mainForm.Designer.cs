using System.Drawing;
using System.Windows.Forms.DataVisualization.Charting;

namespace statisticRequest
{
    partial class mainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartFaultStats;
        private System.Windows.Forms.ListView chartValuesListView;


        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(mainForm));
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.label1 = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.addRequestButton = new System.Windows.Forms.Button();
            this.deleteRequestButton = new System.Windows.Forms.Button();
            this.editRequestButton = new System.Windows.Forms.Button();
            this.addCommentButton = new System.Windows.Forms.Button();
            this.deleteCommentButton = new System.Windows.Forms.Button();
            this.editCommentButton = new System.Windows.Forms.Button();
            this.addEquipmentButton = new System.Windows.Forms.Button();
            this.deleteEquipmentButton = new System.Windows.Forms.Button();
            this.editEquipmentButton = new System.Windows.Forms.Button();
            this.addClientButton = new System.Windows.Forms.Button();
            this.deleteClientButton = new System.Windows.Forms.Button();
            this.editClientButton = new System.Windows.Forms.Button();
            this.addSpecialistButton = new System.Windows.Forms.Button();
            this.deleteSpecialistButton = new System.Windows.Forms.Button();
            this.editSpecialistButton = new System.Windows.Forms.Button();
            this.addReportButton = new System.Windows.Forms.Button();
            this.deleteReportButton = new System.Windows.Forms.Button();
            this.editReportButton = new System.Windows.Forms.Button();
            this.statisticTabPage = new System.Windows.Forms.TabPage();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.chartFaultStats = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chartValuesListView = new System.Windows.Forms.ListView();
            this.kpiPanel = new System.Windows.Forms.Panel();
            this.completedCountLabel = new System.Windows.Forms.Label();
            this.avgTimeLabel = new System.Windows.Forms.Label();
            this.specialistTabPage = new System.Windows.Forms.TabPage();
            this.specialistPanel = new System.Windows.Forms.Panel();
            this.tablePanel4 = new System.Windows.Forms.Panel();
            this.specialistDGV = new System.Windows.Forms.DataGridView();
            this.searchPanel4 = new System.Windows.Forms.Panel();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.groupBox8 = new System.Windows.Forms.GroupBox();
            this.searchSpecialistTextBox = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.filterSpecialistComboBox = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.clientTabPage = new System.Windows.Forms.TabPage();
            this.clientPanel = new System.Windows.Forms.Panel();
            this.tablePanel3 = new System.Windows.Forms.Panel();
            this.clientDGV = new System.Windows.Forms.DataGridView();
            this.searchPanel3 = new System.Windows.Forms.Panel();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.searchClientTextBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.filterClientComboBox = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.equipmentTabPage = new System.Windows.Forms.TabPage();
            this.equipmentPanel = new System.Windows.Forms.Panel();
            this.tablePanel2 = new System.Windows.Forms.Panel();
            this.equipmentDGV = new System.Windows.Forms.DataGridView();
            this.searchPanel2 = new System.Windows.Forms.Panel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.searchEquipmentTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.filterEquipmentComboBox = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.requestTabPage = new System.Windows.Forms.TabPage();
            this.tablePanel = new System.Windows.Forms.Panel();
            this.requestDGV = new System.Windows.Forms.DataGridView();
            this.searchPanel = new System.Windows.Forms.Panel();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.searchRequestTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.filterRequestComboBox = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.commentTabPage = new System.Windows.Forms.TabPage();
            this.tabelPanel5 = new System.Windows.Forms.Panel();
            this.commentDGV = new System.Windows.Forms.DataGridView();
            this.searchPanel5 = new System.Windows.Forms.Panel();
            this.groupBox9 = new System.Windows.Forms.GroupBox();
            this.groupBox10 = new System.Windows.Forms.GroupBox();
            this.searchCommentTextBox = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.filterCommentComboBox = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.reportTabPage = new System.Windows.Forms.TabPage();
            this.tablePanel6 = new System.Windows.Forms.Panel();
            this.reportDGV = new System.Windows.Forms.DataGridView();
            this.searchPanel6 = new System.Windows.Forms.Panel();
            this.groupBox11 = new System.Windows.Forms.GroupBox();
            this.groupBox12 = new System.Windows.Forms.GroupBox();
            this.searchReportTextBox = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.filterReportComboBox = new System.Windows.Forms.ComboBox();
            this.label13 = new System.Windows.Forms.Label();
            this.notifyIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.statisticTabPage.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartFaultStats)).BeginInit();
            this.kpiPanel.SuspendLayout();
            this.specialistTabPage.SuspendLayout();
            this.specialistPanel.SuspendLayout();
            this.tablePanel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.specialistDGV)).BeginInit();
            this.searchPanel4.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox8.SuspendLayout();
            this.clientTabPage.SuspendLayout();
            this.clientPanel.SuspendLayout();
            this.tablePanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.clientDGV)).BeginInit();
            this.searchPanel3.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox7.SuspendLayout();
            this.equipmentTabPage.SuspendLayout();
            this.equipmentPanel.SuspendLayout();
            this.tablePanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.equipmentDGV)).BeginInit();
            this.searchPanel2.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.requestTabPage.SuspendLayout();
            this.tablePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.requestDGV)).BeginInit();
            this.searchPanel.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tabControl.SuspendLayout();
            this.commentTabPage.SuspendLayout();
            this.tabelPanel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.commentDGV)).BeginInit();
            this.searchPanel5.SuspendLayout();
            this.groupBox9.SuspendLayout();
            this.groupBox10.SuspendLayout();
            this.reportTabPage.SuspendLayout();
            this.tablePanel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.reportDGV)).BeginInit();
            this.searchPanel6.SuspendLayout();
            this.groupBox11.SuspendLayout();
            this.groupBox12.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoEllipsis = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(142)))), ((int)(((byte)(255)))));
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1264, 60);
            this.label1.TabIndex = 0;
            this.label1.Text = "Система учёта заявок на ремонт оборудования";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // addRequestButton
            // 
            this.addRequestButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(70)))), ((int)(((byte)(209)))));
            this.addRequestButton.FlatAppearance.BorderSize = 0;
            this.addRequestButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addRequestButton.ForeColor = System.Drawing.Color.White;
            this.addRequestButton.Image = ((System.Drawing.Image)(resources.GetObject("addRequestButton.Image")));
            this.addRequestButton.Location = new System.Drawing.Point(16, 25);
            this.addRequestButton.Name = "addRequestButton";
            this.addRequestButton.Size = new System.Drawing.Size(90, 35);
            this.addRequestButton.TabIndex = 1;
            this.addRequestButton.Text = "Добавить";
            this.addRequestButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.toolTip1.SetToolTip(this.addRequestButton, "Добавить заявку");
            this.addRequestButton.UseVisualStyleBackColor = false;
            this.addRequestButton.Click += new System.EventHandler(this.addRequestButton_Click);
            // 
            // deleteRequestButton
            // 
            this.deleteRequestButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(70)))), ((int)(((byte)(209)))));
            this.deleteRequestButton.FlatAppearance.BorderSize = 0;
            this.deleteRequestButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deleteRequestButton.ForeColor = System.Drawing.Color.White;
            this.deleteRequestButton.Image = ((System.Drawing.Image)(resources.GetObject("deleteRequestButton.Image")));
            this.deleteRequestButton.Location = new System.Drawing.Point(208, 24);
            this.deleteRequestButton.Name = "deleteRequestButton";
            this.deleteRequestButton.Size = new System.Drawing.Size(90, 35);
            this.deleteRequestButton.TabIndex = 3;
            this.deleteRequestButton.Text = "Удалить";
            this.deleteRequestButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.toolTip1.SetToolTip(this.deleteRequestButton, "Удалить заявку");
            this.deleteRequestButton.UseVisualStyleBackColor = false;
            this.deleteRequestButton.Click += new System.EventHandler(this.deleteRequestButton_Click);
            // 
            // editRequestButton
            // 
            this.editRequestButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(70)))), ((int)(((byte)(209)))));
            this.editRequestButton.FlatAppearance.BorderSize = 0;
            this.editRequestButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.editRequestButton.ForeColor = System.Drawing.Color.White;
            this.editRequestButton.Image = ((System.Drawing.Image)(resources.GetObject("editRequestButton.Image")));
            this.editRequestButton.Location = new System.Drawing.Point(112, 24);
            this.editRequestButton.Name = "editRequestButton";
            this.editRequestButton.Size = new System.Drawing.Size(90, 35);
            this.editRequestButton.TabIndex = 2;
            this.editRequestButton.Text = "Изменить";
            this.editRequestButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.toolTip1.SetToolTip(this.editRequestButton, "Редактировать заявку");
            this.editRequestButton.UseVisualStyleBackColor = false;
            this.editRequestButton.Click += new System.EventHandler(this.editRequestButton_Click);
            // 
            // addCommentButton
            // 
            this.addCommentButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(70)))), ((int)(((byte)(209)))));
            this.addCommentButton.FlatAppearance.BorderSize = 0;
            this.addCommentButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addCommentButton.ForeColor = System.Drawing.Color.White;
            this.addCommentButton.Image = ((System.Drawing.Image)(resources.GetObject("addCommentButton.Image")));
            this.addCommentButton.Location = new System.Drawing.Point(16, 25);
            this.addCommentButton.Name = "addCommentButton";
            this.addCommentButton.Size = new System.Drawing.Size(90, 35);
            this.addCommentButton.TabIndex = 1;
            this.addCommentButton.Text = "Добавить";
            this.addCommentButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.toolTip1.SetToolTip(this.addCommentButton, "Добавить комментарий");
            this.addCommentButton.UseVisualStyleBackColor = false;
            this.addCommentButton.Click += new System.EventHandler(this.addCommentButton_Click);
            // 
            // deleteCommentButton
            // 
            this.deleteCommentButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(70)))), ((int)(((byte)(209)))));
            this.deleteCommentButton.FlatAppearance.BorderSize = 0;
            this.deleteCommentButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deleteCommentButton.ForeColor = System.Drawing.Color.White;
            this.deleteCommentButton.Image = ((System.Drawing.Image)(resources.GetObject("deleteCommentButton.Image")));
            this.deleteCommentButton.Location = new System.Drawing.Point(208, 24);
            this.deleteCommentButton.Name = "deleteCommentButton";
            this.deleteCommentButton.Size = new System.Drawing.Size(90, 35);
            this.deleteCommentButton.TabIndex = 3;
            this.deleteCommentButton.Text = "Удалить";
            this.deleteCommentButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.toolTip1.SetToolTip(this.deleteCommentButton, "Удалить комментарий");
            this.deleteCommentButton.UseVisualStyleBackColor = false;
            this.deleteCommentButton.Click += new System.EventHandler(this.deleteCommentButton_Click);
            // 
            // editCommentButton
            // 
            this.editCommentButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(70)))), ((int)(((byte)(209)))));
            this.editCommentButton.FlatAppearance.BorderSize = 0;
            this.editCommentButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.editCommentButton.ForeColor = System.Drawing.Color.White;
            this.editCommentButton.Image = ((System.Drawing.Image)(resources.GetObject("editCommentButton.Image")));
            this.editCommentButton.Location = new System.Drawing.Point(112, 24);
            this.editCommentButton.Name = "editCommentButton";
            this.editCommentButton.Size = new System.Drawing.Size(90, 35);
            this.editCommentButton.TabIndex = 2;
            this.editCommentButton.Text = "Изменить";
            this.editCommentButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.toolTip1.SetToolTip(this.editCommentButton, "Редактировать комментарий");
            this.editCommentButton.UseVisualStyleBackColor = false;
            this.editCommentButton.Click += new System.EventHandler(this.editCommentButton_Click);
            // 
            // addEquipmentButton
            // 
            this.addEquipmentButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(70)))), ((int)(((byte)(209)))));
            this.addEquipmentButton.FlatAppearance.BorderSize = 0;
            this.addEquipmentButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addEquipmentButton.Font = new System.Drawing.Font("Tahoma", 9F);
            this.addEquipmentButton.ForeColor = System.Drawing.Color.White;
            this.addEquipmentButton.Image = ((System.Drawing.Image)(resources.GetObject("addEquipmentButton.Image")));
            this.addEquipmentButton.Location = new System.Drawing.Point(16, 25);
            this.addEquipmentButton.Name = "addEquipmentButton";
            this.addEquipmentButton.Size = new System.Drawing.Size(90, 35);
            this.addEquipmentButton.TabIndex = 1;
            this.addEquipmentButton.Text = "Добавить";
            this.addEquipmentButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.toolTip1.SetToolTip(this.addEquipmentButton, "Добавить оборудование");
            this.addEquipmentButton.UseVisualStyleBackColor = false;
            this.addEquipmentButton.Click += new System.EventHandler(this.addEquipmentButton_Click);
            // 
            // deleteEquipmentButton
            // 
            this.deleteEquipmentButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(70)))), ((int)(((byte)(209)))));
            this.deleteEquipmentButton.FlatAppearance.BorderSize = 0;
            this.deleteEquipmentButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deleteEquipmentButton.Font = new System.Drawing.Font("Tahoma", 9F);
            this.deleteEquipmentButton.ForeColor = System.Drawing.Color.White;
            this.deleteEquipmentButton.Image = ((System.Drawing.Image)(resources.GetObject("deleteEquipmentButton.Image")));
            this.deleteEquipmentButton.Location = new System.Drawing.Point(208, 24);
            this.deleteEquipmentButton.Name = "deleteEquipmentButton";
            this.deleteEquipmentButton.Size = new System.Drawing.Size(90, 35);
            this.deleteEquipmentButton.TabIndex = 3;
            this.deleteEquipmentButton.Text = "Удалить";
            this.deleteEquipmentButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.toolTip1.SetToolTip(this.deleteEquipmentButton, "Удалить оборудование");
            this.deleteEquipmentButton.UseVisualStyleBackColor = false;
            this.deleteEquipmentButton.Click += new System.EventHandler(this.deleteEquipmentButton_Click);
            // 
            // editEquipmentButton
            // 
            this.editEquipmentButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(70)))), ((int)(((byte)(209)))));
            this.editEquipmentButton.FlatAppearance.BorderSize = 0;
            this.editEquipmentButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.editEquipmentButton.Font = new System.Drawing.Font("Tahoma", 9F);
            this.editEquipmentButton.ForeColor = System.Drawing.Color.White;
            this.editEquipmentButton.Image = ((System.Drawing.Image)(resources.GetObject("editEquipmentButton.Image")));
            this.editEquipmentButton.Location = new System.Drawing.Point(112, 24);
            this.editEquipmentButton.Name = "editEquipmentButton";
            this.editEquipmentButton.Size = new System.Drawing.Size(90, 35);
            this.editEquipmentButton.TabIndex = 2;
            this.editEquipmentButton.Text = "Изменить";
            this.editEquipmentButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.toolTip1.SetToolTip(this.editEquipmentButton, "Редактировать оборудование");
            this.editEquipmentButton.UseVisualStyleBackColor = false;
            this.editEquipmentButton.Click += new System.EventHandler(this.editEquipmentButton_Click);
            // 
            // addClientButton
            // 
            this.addClientButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(70)))), ((int)(((byte)(209)))));
            this.addClientButton.FlatAppearance.BorderSize = 0;
            this.addClientButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addClientButton.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.addClientButton.ForeColor = System.Drawing.Color.White;
            this.addClientButton.Image = ((System.Drawing.Image)(resources.GetObject("addClientButton.Image")));
            this.addClientButton.Location = new System.Drawing.Point(16, 25);
            this.addClientButton.Name = "addClientButton";
            this.addClientButton.Size = new System.Drawing.Size(90, 35);
            this.addClientButton.TabIndex = 1;
            this.addClientButton.Text = "Добавить";
            this.addClientButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.toolTip1.SetToolTip(this.addClientButton, "Добавить клиента");
            this.addClientButton.UseVisualStyleBackColor = false;
            this.addClientButton.Click += new System.EventHandler(this.addClientButton_Click);
            // 
            // deleteClientButton
            // 
            this.deleteClientButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(70)))), ((int)(((byte)(209)))));
            this.deleteClientButton.FlatAppearance.BorderSize = 0;
            this.deleteClientButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deleteClientButton.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.deleteClientButton.ForeColor = System.Drawing.Color.White;
            this.deleteClientButton.Image = ((System.Drawing.Image)(resources.GetObject("deleteClientButton.Image")));
            this.deleteClientButton.Location = new System.Drawing.Point(208, 24);
            this.deleteClientButton.Name = "deleteClientButton";
            this.deleteClientButton.Size = new System.Drawing.Size(90, 35);
            this.deleteClientButton.TabIndex = 3;
            this.deleteClientButton.Text = "Удалить";
            this.deleteClientButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.toolTip1.SetToolTip(this.deleteClientButton, "Удалить клиента");
            this.deleteClientButton.UseVisualStyleBackColor = false;
            this.deleteClientButton.Click += new System.EventHandler(this.deleteClientButton_Click);
            // 
            // editClientButton
            // 
            this.editClientButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(70)))), ((int)(((byte)(209)))));
            this.editClientButton.FlatAppearance.BorderSize = 0;
            this.editClientButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.editClientButton.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.editClientButton.ForeColor = System.Drawing.Color.White;
            this.editClientButton.Image = ((System.Drawing.Image)(resources.GetObject("editClientButton.Image")));
            this.editClientButton.Location = new System.Drawing.Point(112, 24);
            this.editClientButton.Name = "editClientButton";
            this.editClientButton.Size = new System.Drawing.Size(90, 35);
            this.editClientButton.TabIndex = 2;
            this.editClientButton.Text = "Изменить";
            this.editClientButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.toolTip1.SetToolTip(this.editClientButton, "Редактировать клиента");
            this.editClientButton.UseVisualStyleBackColor = false;
            this.editClientButton.Click += new System.EventHandler(this.editClientButton_Click);
            // 
            // addSpecialistButton
            // 
            this.addSpecialistButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(70)))), ((int)(((byte)(209)))));
            this.addSpecialistButton.FlatAppearance.BorderSize = 0;
            this.addSpecialistButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addSpecialistButton.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.addSpecialistButton.ForeColor = System.Drawing.Color.White;
            this.addSpecialistButton.Image = ((System.Drawing.Image)(resources.GetObject("addSpecialistButton.Image")));
            this.addSpecialistButton.Location = new System.Drawing.Point(16, 25);
            this.addSpecialistButton.Name = "addSpecialistButton";
            this.addSpecialistButton.Size = new System.Drawing.Size(90, 35);
            this.addSpecialistButton.TabIndex = 1;
            this.addSpecialistButton.Text = "Добавить";
            this.addSpecialistButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.toolTip1.SetToolTip(this.addSpecialistButton, "Добавить специалиста");
            this.addSpecialistButton.UseVisualStyleBackColor = false;
            this.addSpecialistButton.Click += new System.EventHandler(this.addSpecialistButton_Click);
            // 
            // deleteSpecialistButton
            // 
            this.deleteSpecialistButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(70)))), ((int)(((byte)(209)))));
            this.deleteSpecialistButton.FlatAppearance.BorderSize = 0;
            this.deleteSpecialistButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deleteSpecialistButton.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.deleteSpecialistButton.ForeColor = System.Drawing.Color.White;
            this.deleteSpecialistButton.Image = ((System.Drawing.Image)(resources.GetObject("deleteSpecialistButton.Image")));
            this.deleteSpecialistButton.Location = new System.Drawing.Point(208, 24);
            this.deleteSpecialistButton.Name = "deleteSpecialistButton";
            this.deleteSpecialistButton.Size = new System.Drawing.Size(90, 35);
            this.deleteSpecialistButton.TabIndex = 3;
            this.deleteSpecialistButton.Text = "Удалить";
            this.deleteSpecialistButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.toolTip1.SetToolTip(this.deleteSpecialistButton, "Удалить специалиста");
            this.deleteSpecialistButton.UseVisualStyleBackColor = false;
            this.deleteSpecialistButton.Click += new System.EventHandler(this.deleteSpecialistButton_Click);
            // 
            // editSpecialistButton
            // 
            this.editSpecialistButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(70)))), ((int)(((byte)(209)))));
            this.editSpecialistButton.FlatAppearance.BorderSize = 0;
            this.editSpecialistButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.editSpecialistButton.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.editSpecialistButton.ForeColor = System.Drawing.Color.White;
            this.editSpecialistButton.Image = ((System.Drawing.Image)(resources.GetObject("editSpecialistButton.Image")));
            this.editSpecialistButton.Location = new System.Drawing.Point(112, 24);
            this.editSpecialistButton.Name = "editSpecialistButton";
            this.editSpecialistButton.Size = new System.Drawing.Size(90, 35);
            this.editSpecialistButton.TabIndex = 2;
            this.editSpecialistButton.Text = "Изменить";
            this.editSpecialistButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.toolTip1.SetToolTip(this.editSpecialistButton, "Редактировать специалиста");
            this.editSpecialistButton.UseVisualStyleBackColor = false;
            this.editSpecialistButton.Click += new System.EventHandler(this.editSpecialistButton_Click);
            // 
            // addReportButton
            // 
            this.addReportButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(70)))), ((int)(((byte)(209)))));
            this.addReportButton.FlatAppearance.BorderSize = 0;
            this.addReportButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addReportButton.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.addReportButton.ForeColor = System.Drawing.Color.White;
            this.addReportButton.Image = ((System.Drawing.Image)(resources.GetObject("addReportButton.Image")));
            this.addReportButton.Location = new System.Drawing.Point(16, 25);
            this.addReportButton.Name = "addReportButton";
            this.addReportButton.Size = new System.Drawing.Size(90, 35);
            this.addReportButton.TabIndex = 1;
            this.addReportButton.Text = "Добавить";
            this.addReportButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.toolTip1.SetToolTip(this.addReportButton, "Добавить отчет");
            this.addReportButton.UseVisualStyleBackColor = false;
            this.addReportButton.Click += new System.EventHandler(this.addReportButton_Click);
            // 
            // deleteReportButton
            // 
            this.deleteReportButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(70)))), ((int)(((byte)(209)))));
            this.deleteReportButton.FlatAppearance.BorderSize = 0;
            this.deleteReportButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deleteReportButton.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.deleteReportButton.ForeColor = System.Drawing.Color.White;
            this.deleteReportButton.Image = ((System.Drawing.Image)(resources.GetObject("deleteReportButton.Image")));
            this.deleteReportButton.Location = new System.Drawing.Point(208, 24);
            this.deleteReportButton.Name = "deleteReportButton";
            this.deleteReportButton.Size = new System.Drawing.Size(90, 35);
            this.deleteReportButton.TabIndex = 3;
            this.deleteReportButton.Text = "Удалить";
            this.deleteReportButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.toolTip1.SetToolTip(this.deleteReportButton, "Удалить отчет");
            this.deleteReportButton.UseVisualStyleBackColor = false;
            this.deleteReportButton.Click += new System.EventHandler(this.deleteReportButton_Click);
            // 
            // editReportButton
            // 
            this.editReportButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(70)))), ((int)(((byte)(209)))));
            this.editReportButton.FlatAppearance.BorderSize = 0;
            this.editReportButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.editReportButton.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.editReportButton.ForeColor = System.Drawing.Color.White;
            this.editReportButton.Image = ((System.Drawing.Image)(resources.GetObject("editReportButton.Image")));
            this.editReportButton.Location = new System.Drawing.Point(112, 24);
            this.editReportButton.Name = "editReportButton";
            this.editReportButton.Size = new System.Drawing.Size(90, 35);
            this.editReportButton.TabIndex = 2;
            this.editReportButton.Text = "Изменить";
            this.editReportButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.toolTip1.SetToolTip(this.editReportButton, "Редактировать отчет");
            this.editReportButton.UseVisualStyleBackColor = false;
            this.editReportButton.Click += new System.EventHandler(this.editReportButton_Click);
            // 
            // statisticTabPage
            // 
            this.statisticTabPage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(70)))), ((int)(((byte)(209)))));
            this.statisticTabPage.Controls.Add(this.panel4);
            this.statisticTabPage.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(229)))), ((int)(((byte)(229)))));
            this.statisticTabPage.Location = new System.Drawing.Point(4, 23);
            this.statisticTabPage.Name = "statisticTabPage";
            this.statisticTabPage.Size = new System.Drawing.Size(1256, 674);
            this.statisticTabPage.TabIndex = 3;
            this.statisticTabPage.Text = "Статистика";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(70)))), ((int)(((byte)(209)))));
            this.panel4.Controls.Add(this.panel1);
            this.panel4.Controls.Add(this.kpiPanel);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1256, 674);
            this.panel4.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(70)))), ((int)(((byte)(209)))));
            this.panel1.Controls.Add(this.chartFaultStats);
            this.panel1.Controls.Add(this.chartValuesListView);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 100);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1256, 574);
            this.panel1.TabIndex = 3;
            // 
            // chartFaultStats
            // 
            this.chartFaultStats.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(142)))), ((int)(((byte)(255)))));
            this.chartFaultStats.BorderlineColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(70)))), ((int)(((byte)(209)))));
            this.chartFaultStats.BorderlineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Solid;
            chartArea2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(70)))), ((int)(((byte)(209)))));
            chartArea2.BackSecondaryColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(46)))));
            chartArea2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(46)))));
            chartArea2.Name = "ChartArea1";
            chartArea2.ShadowColor = System.Drawing.Color.Transparent;
            this.chartFaultStats.ChartAreas.Add(chartArea2);
            this.chartFaultStats.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chartFaultStats.Location = new System.Drawing.Point(0, 0);
            this.chartFaultStats.Name = "chartFaultStats";
            this.chartFaultStats.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Excel;
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series2.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            series2.LabelForeColor = System.Drawing.Color.White;
            series2.Name = "Типы";
            this.chartFaultStats.Series.Add(series2);
            this.chartFaultStats.Size = new System.Drawing.Size(831, 574);
            this.chartFaultStats.TabIndex = 0;
            // 
            // chartValuesListView
            // 
            this.chartValuesListView.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(70)))), ((int)(((byte)(209)))));
            this.chartValuesListView.Dock = System.Windows.Forms.DockStyle.Right;
            this.chartValuesListView.Font = new System.Drawing.Font("Tahoma", 10F);
            this.chartValuesListView.ForeColor = System.Drawing.Color.White;
            this.chartValuesListView.HideSelection = false;
            this.chartValuesListView.Location = new System.Drawing.Point(831, 0);
            this.chartValuesListView.Name = "chartValuesListView";
            this.chartValuesListView.Size = new System.Drawing.Size(425, 574);
            this.chartValuesListView.TabIndex = 1;
            this.chartValuesListView.UseCompatibleStateImageBehavior = false;
            this.chartValuesListView.View = System.Windows.Forms.View.Details;
            // 
            // kpiPanel
            // 
            this.kpiPanel.Controls.Add(this.completedCountLabel);
            this.kpiPanel.Controls.Add(this.avgTimeLabel);
            this.kpiPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.kpiPanel.Location = new System.Drawing.Point(0, 0);
            this.kpiPanel.Name = "kpiPanel";
            this.kpiPanel.Size = new System.Drawing.Size(1256, 100);
            this.kpiPanel.TabIndex = 2;
            // 
            // completedCountLabel
            // 
            this.completedCountLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(70)))), ((int)(((byte)(209)))));
            this.completedCountLabel.Dock = System.Windows.Forms.DockStyle.Top;
            this.completedCountLabel.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.completedCountLabel.Location = new System.Drawing.Point(0, 0);
            this.completedCountLabel.Name = "completedCountLabel";
            this.completedCountLabel.Size = new System.Drawing.Size(1256, 37);
            this.completedCountLabel.TabIndex = 0;
            this.completedCountLabel.Text = "Выполненные заявки: 0";
            this.completedCountLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // avgTimeLabel
            // 
            this.avgTimeLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(70)))), ((int)(((byte)(209)))));
            this.avgTimeLabel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.avgTimeLabel.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.avgTimeLabel.Location = new System.Drawing.Point(0, 37);
            this.avgTimeLabel.Name = "avgTimeLabel";
            this.avgTimeLabel.Size = new System.Drawing.Size(1256, 63);
            this.avgTimeLabel.TabIndex = 1;
            this.avgTimeLabel.Text = "Среднее время выполнения заявок: 0 ч.";
            this.avgTimeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // specialistTabPage
            // 
            this.specialistTabPage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(142)))), ((int)(((byte)(255)))));
            this.specialistTabPage.Controls.Add(this.specialistPanel);
            this.specialistTabPage.Location = new System.Drawing.Point(4, 23);
            this.specialistTabPage.Name = "specialistTabPage";
            this.specialistTabPage.Size = new System.Drawing.Size(1256, 674);
            this.specialistTabPage.TabIndex = 5;
            this.specialistTabPage.Text = "Специалисты";
            // 
            // specialistPanel
            // 
            this.specialistPanel.Controls.Add(this.tablePanel4);
            this.specialistPanel.Controls.Add(this.searchPanel4);
            this.specialistPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.specialistPanel.Location = new System.Drawing.Point(0, 0);
            this.specialistPanel.Name = "specialistPanel";
            this.specialistPanel.Size = new System.Drawing.Size(1256, 674);
            this.specialistPanel.TabIndex = 4;
            // 
            // tablePanel4
            // 
            this.tablePanel4.Controls.Add(this.specialistDGV);
            this.tablePanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tablePanel4.Location = new System.Drawing.Point(0, 72);
            this.tablePanel4.Name = "tablePanel4";
            this.tablePanel4.Size = new System.Drawing.Size(1256, 602);
            this.tablePanel4.TabIndex = 2;
            // 
            // specialistDGV
            // 
            this.specialistDGV.AllowUserToAddRows = false;
            this.specialistDGV.AllowUserToDeleteRows = false;
            this.specialistDGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.specialistDGV.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(70)))), ((int)(((byte)(209)))));
            this.specialistDGV.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.specialistDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.specialistDGV.Dock = System.Windows.Forms.DockStyle.Fill;
            this.specialistDGV.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(70)))), ((int)(((byte)(209)))));
            this.specialistDGV.Location = new System.Drawing.Point(0, 0);
            this.specialistDGV.MultiSelect = false;
            this.specialistDGV.Name = "specialistDGV";
            this.specialistDGV.ReadOnly = true;
            this.specialistDGV.RowHeadersWidth = 62;
            this.specialistDGV.RowTemplate.Height = 28;
            this.specialistDGV.Size = new System.Drawing.Size(1256, 602);
            this.specialistDGV.TabIndex = 0;
            this.specialistDGV.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.specialistDGV_CellClick);
            // 
            // searchPanel4
            // 
            this.searchPanel4.Controls.Add(this.groupBox4);
            this.searchPanel4.Controls.Add(this.groupBox8);
            this.searchPanel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.searchPanel4.Location = new System.Drawing.Point(0, 0);
            this.searchPanel4.Name = "searchPanel4";
            this.searchPanel4.Size = new System.Drawing.Size(1256, 72);
            this.searchPanel4.TabIndex = 1;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.addSpecialistButton);
            this.groupBox4.Controls.Add(this.deleteSpecialistButton);
            this.groupBox4.Controls.Add(this.editSpecialistButton);
            this.groupBox4.Dock = System.Windows.Forms.DockStyle.Right;
            this.groupBox4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox4.Font = new System.Drawing.Font("Tahoma", 9F);
            this.groupBox4.ForeColor = System.Drawing.Color.White;
            this.groupBox4.Location = new System.Drawing.Point(634, 0);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(622, 72);
            this.groupBox4.TabIndex = 2;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Управление специалистами";
            // 
            // groupBox8
            // 
            this.groupBox8.Controls.Add(this.searchSpecialistTextBox);
            this.groupBox8.Controls.Add(this.label8);
            this.groupBox8.Controls.Add(this.filterSpecialistComboBox);
            this.groupBox8.Controls.Add(this.label9);
            this.groupBox8.Dock = System.Windows.Forms.DockStyle.Left;
            this.groupBox8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox8.Font = new System.Drawing.Font("Tahoma", 9F);
            this.groupBox8.ForeColor = System.Drawing.Color.White;
            this.groupBox8.Location = new System.Drawing.Point(0, 0);
            this.groupBox8.Name = "groupBox8";
            this.groupBox8.Size = new System.Drawing.Size(622, 72);
            this.groupBox8.TabIndex = 1;
            this.groupBox8.TabStop = false;
            this.groupBox8.Text = "Поиск";
            // 
            // searchSpecialistTextBox
            // 
            this.searchSpecialistTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(70)))), ((int)(((byte)(209)))));
            this.searchSpecialistTextBox.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.searchSpecialistTextBox.ForeColor = System.Drawing.Color.White;
            this.searchSpecialistTextBox.Location = new System.Drawing.Point(368, 29);
            this.searchSpecialistTextBox.Margin = new System.Windows.Forms.Padding(10, 5, 10, 5);
            this.searchSpecialistTextBox.Name = "searchSpecialistTextBox";
            this.searchSpecialistTextBox.Size = new System.Drawing.Size(232, 22);
            this.searchSpecialistTextBox.TabIndex = 4;
            this.searchSpecialistTextBox.TextChanged += new System.EventHandler(this.searchSpecialistTextBox_TextChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.Location = new System.Drawing.Point(297, 32);
            this.label8.Margin = new System.Windows.Forms.Padding(10, 5, 10, 5);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(65, 14);
            this.label8.TabIndex = 3;
            this.label8.Text = "Значение:";
            // 
            // filterSpecialistComboBox
            // 
            this.filterSpecialistComboBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(70)))), ((int)(((byte)(209)))));
            this.filterSpecialistComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.filterSpecialistComboBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.filterSpecialistComboBox.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.filterSpecialistComboBox.ForeColor = System.Drawing.Color.White;
            this.filterSpecialistComboBox.FormattingEnabled = true;
            this.filterSpecialistComboBox.Items.AddRange(new object[] {
            "По номеру специалиста",
            "По ФИО",
            "По электронной почте",
            "По номеру телефона"});
            this.filterSpecialistComboBox.Location = new System.Drawing.Point(111, 29);
            this.filterSpecialistComboBox.Margin = new System.Windows.Forms.Padding(10, 5, 10, 5);
            this.filterSpecialistComboBox.Name = "filterSpecialistComboBox";
            this.filterSpecialistComboBox.Size = new System.Drawing.Size(166, 22);
            this.filterSpecialistComboBox.TabIndex = 1;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label9.Location = new System.Drawing.Point(21, 32);
            this.label9.Margin = new System.Windows.Forms.Padding(10, 5, 10, 5);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(81, 14);
            this.label9.TabIndex = 2;
            this.label9.Text = "Фильтрация:";
            // 
            // clientTabPage
            // 
            this.clientTabPage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(142)))), ((int)(((byte)(255)))));
            this.clientTabPage.Controls.Add(this.clientPanel);
            this.clientTabPage.Location = new System.Drawing.Point(4, 23);
            this.clientTabPage.Name = "clientTabPage";
            this.clientTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.clientTabPage.Size = new System.Drawing.Size(1256, 674);
            this.clientTabPage.TabIndex = 4;
            this.clientTabPage.Text = "Клиенты";
            // 
            // clientPanel
            // 
            this.clientPanel.Controls.Add(this.tablePanel3);
            this.clientPanel.Controls.Add(this.searchPanel3);
            this.clientPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.clientPanel.Location = new System.Drawing.Point(3, 3);
            this.clientPanel.Name = "clientPanel";
            this.clientPanel.Size = new System.Drawing.Size(1250, 668);
            this.clientPanel.TabIndex = 3;
            // 
            // tablePanel3
            // 
            this.tablePanel3.Controls.Add(this.clientDGV);
            this.tablePanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tablePanel3.Location = new System.Drawing.Point(0, 72);
            this.tablePanel3.Name = "tablePanel3";
            this.tablePanel3.Size = new System.Drawing.Size(1250, 596);
            this.tablePanel3.TabIndex = 2;
            // 
            // clientDGV
            // 
            this.clientDGV.AllowUserToAddRows = false;
            this.clientDGV.AllowUserToDeleteRows = false;
            this.clientDGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.clientDGV.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(70)))), ((int)(((byte)(209)))));
            this.clientDGV.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.clientDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.clientDGV.Dock = System.Windows.Forms.DockStyle.Fill;
            this.clientDGV.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(70)))), ((int)(((byte)(209)))));
            this.clientDGV.Location = new System.Drawing.Point(0, 0);
            this.clientDGV.MultiSelect = false;
            this.clientDGV.Name = "clientDGV";
            this.clientDGV.ReadOnly = true;
            this.clientDGV.RowHeadersWidth = 62;
            this.clientDGV.RowTemplate.Height = 28;
            this.clientDGV.Size = new System.Drawing.Size(1250, 596);
            this.clientDGV.TabIndex = 0;
            this.clientDGV.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.clientDGV_CellClick);
            // 
            // searchPanel3
            // 
            this.searchPanel3.Controls.Add(this.groupBox3);
            this.searchPanel3.Controls.Add(this.groupBox7);
            this.searchPanel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.searchPanel3.Location = new System.Drawing.Point(0, 0);
            this.searchPanel3.Name = "searchPanel3";
            this.searchPanel3.Size = new System.Drawing.Size(1250, 72);
            this.searchPanel3.TabIndex = 1;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.addClientButton);
            this.groupBox3.Controls.Add(this.deleteClientButton);
            this.groupBox3.Controls.Add(this.editClientButton);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Right;
            this.groupBox3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox3.Font = new System.Drawing.Font("Tahoma", 9F);
            this.groupBox3.ForeColor = System.Drawing.Color.White;
            this.groupBox3.Location = new System.Drawing.Point(628, 0);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(622, 72);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Управление клиентами";
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.searchClientTextBox);
            this.groupBox7.Controls.Add(this.label6);
            this.groupBox7.Controls.Add(this.filterClientComboBox);
            this.groupBox7.Controls.Add(this.label7);
            this.groupBox7.Dock = System.Windows.Forms.DockStyle.Left;
            this.groupBox7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox7.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox7.ForeColor = System.Drawing.Color.White;
            this.groupBox7.Location = new System.Drawing.Point(0, 0);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(622, 72);
            this.groupBox7.TabIndex = 1;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "Поиск";
            // 
            // searchClientTextBox
            // 
            this.searchClientTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(70)))), ((int)(((byte)(209)))));
            this.searchClientTextBox.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.searchClientTextBox.ForeColor = System.Drawing.Color.White;
            this.searchClientTextBox.Location = new System.Drawing.Point(368, 29);
            this.searchClientTextBox.Margin = new System.Windows.Forms.Padding(10, 5, 10, 5);
            this.searchClientTextBox.Name = "searchClientTextBox";
            this.searchClientTextBox.Size = new System.Drawing.Size(232, 22);
            this.searchClientTextBox.TabIndex = 4;
            this.searchClientTextBox.TextChanged += new System.EventHandler(this.searchClientTextBox_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(297, 32);
            this.label6.Margin = new System.Windows.Forms.Padding(10, 5, 10, 5);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 14);
            this.label6.TabIndex = 3;
            this.label6.Text = "Значение:";
            // 
            // filterClientComboBox
            // 
            this.filterClientComboBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(70)))), ((int)(((byte)(209)))));
            this.filterClientComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.filterClientComboBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.filterClientComboBox.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.filterClientComboBox.ForeColor = System.Drawing.Color.White;
            this.filterClientComboBox.FormattingEnabled = true;
            this.filterClientComboBox.Items.AddRange(new object[] {
            "По номеру клиента",
            "По ФИО",
            "По электронной почте",
            "По номеру телефона"});
            this.filterClientComboBox.Location = new System.Drawing.Point(111, 29);
            this.filterClientComboBox.Margin = new System.Windows.Forms.Padding(10, 5, 10, 5);
            this.filterClientComboBox.Name = "filterClientComboBox";
            this.filterClientComboBox.Size = new System.Drawing.Size(166, 22);
            this.filterClientComboBox.TabIndex = 1;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(21, 32);
            this.label7.Margin = new System.Windows.Forms.Padding(10, 5, 10, 5);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(81, 14);
            this.label7.TabIndex = 2;
            this.label7.Text = "Фильтрация:";
            // 
            // equipmentTabPage
            // 
            this.equipmentTabPage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(142)))), ((int)(((byte)(255)))));
            this.equipmentTabPage.Controls.Add(this.equipmentPanel);
            this.equipmentTabPage.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(229)))), ((int)(((byte)(229)))));
            this.equipmentTabPage.Location = new System.Drawing.Point(4, 23);
            this.equipmentTabPage.Name = "equipmentTabPage";
            this.equipmentTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.equipmentTabPage.Size = new System.Drawing.Size(1256, 674);
            this.equipmentTabPage.TabIndex = 1;
            this.equipmentTabPage.Text = "Оборудование";
            // 
            // equipmentPanel
            // 
            this.equipmentPanel.Controls.Add(this.tablePanel2);
            this.equipmentPanel.Controls.Add(this.searchPanel2);
            this.equipmentPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.equipmentPanel.Location = new System.Drawing.Point(3, 3);
            this.equipmentPanel.Name = "equipmentPanel";
            this.equipmentPanel.Size = new System.Drawing.Size(1250, 668);
            this.equipmentPanel.TabIndex = 2;
            // 
            // tablePanel2
            // 
            this.tablePanel2.Controls.Add(this.equipmentDGV);
            this.tablePanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tablePanel2.Location = new System.Drawing.Point(0, 72);
            this.tablePanel2.Name = "tablePanel2";
            this.tablePanel2.Size = new System.Drawing.Size(1250, 596);
            this.tablePanel2.TabIndex = 2;
            // 
            // equipmentDGV
            // 
            this.equipmentDGV.AllowUserToAddRows = false;
            this.equipmentDGV.AllowUserToDeleteRows = false;
            this.equipmentDGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.equipmentDGV.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(70)))), ((int)(((byte)(209)))));
            this.equipmentDGV.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.equipmentDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.equipmentDGV.Dock = System.Windows.Forms.DockStyle.Fill;
            this.equipmentDGV.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(70)))), ((int)(((byte)(209)))));
            this.equipmentDGV.Location = new System.Drawing.Point(0, 0);
            this.equipmentDGV.MultiSelect = false;
            this.equipmentDGV.Name = "equipmentDGV";
            this.equipmentDGV.ReadOnly = true;
            this.equipmentDGV.RowHeadersWidth = 62;
            this.equipmentDGV.RowTemplate.Height = 28;
            this.equipmentDGV.Size = new System.Drawing.Size(1250, 596);
            this.equipmentDGV.TabIndex = 0;
            this.equipmentDGV.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.equipmentDGV_CellClick);
            // 
            // searchPanel2
            // 
            this.searchPanel2.Controls.Add(this.groupBox2);
            this.searchPanel2.Controls.Add(this.groupBox6);
            this.searchPanel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.searchPanel2.Location = new System.Drawing.Point(0, 0);
            this.searchPanel2.Name = "searchPanel2";
            this.searchPanel2.Size = new System.Drawing.Size(1250, 72);
            this.searchPanel2.TabIndex = 1;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.addEquipmentButton);
            this.groupBox2.Controls.Add(this.deleteEquipmentButton);
            this.groupBox2.Controls.Add(this.editEquipmentButton);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Right;
            this.groupBox2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox2.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox2.ForeColor = System.Drawing.Color.White;
            this.groupBox2.Location = new System.Drawing.Point(628, 0);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(622, 72);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Управление оборудованием";
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.searchEquipmentTextBox);
            this.groupBox6.Controls.Add(this.label4);
            this.groupBox6.Controls.Add(this.filterEquipmentComboBox);
            this.groupBox6.Controls.Add(this.label5);
            this.groupBox6.Dock = System.Windows.Forms.DockStyle.Left;
            this.groupBox6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox6.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox6.ForeColor = System.Drawing.Color.White;
            this.groupBox6.Location = new System.Drawing.Point(0, 0);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(622, 72);
            this.groupBox6.TabIndex = 1;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Поиск";
            // 
            // searchEquipmentTextBox
            // 
            this.searchEquipmentTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(70)))), ((int)(((byte)(209)))));
            this.searchEquipmentTextBox.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.searchEquipmentTextBox.ForeColor = System.Drawing.Color.White;
            this.searchEquipmentTextBox.Location = new System.Drawing.Point(368, 29);
            this.searchEquipmentTextBox.Margin = new System.Windows.Forms.Padding(10, 5, 10, 5);
            this.searchEquipmentTextBox.Name = "searchEquipmentTextBox";
            this.searchEquipmentTextBox.Size = new System.Drawing.Size(232, 22);
            this.searchEquipmentTextBox.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(297, 32);
            this.label4.Margin = new System.Windows.Forms.Padding(10, 5, 10, 5);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 14);
            this.label4.TabIndex = 3;
            this.label4.Text = "Значение:";
            // 
            // filterEquipmentComboBox
            // 
            this.filterEquipmentComboBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(70)))), ((int)(((byte)(209)))));
            this.filterEquipmentComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.filterEquipmentComboBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.filterEquipmentComboBox.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.filterEquipmentComboBox.ForeColor = System.Drawing.Color.White;
            this.filterEquipmentComboBox.FormattingEnabled = true;
            this.filterEquipmentComboBox.Items.AddRange(new object[] {
            "По номеру оборудования",
            "По серийному номеру",
            "По типу оборудования",
            "По названию"});
            this.filterEquipmentComboBox.Location = new System.Drawing.Point(111, 29);
            this.filterEquipmentComboBox.Margin = new System.Windows.Forms.Padding(10, 5, 10, 5);
            this.filterEquipmentComboBox.Name = "filterEquipmentComboBox";
            this.filterEquipmentComboBox.Size = new System.Drawing.Size(166, 22);
            this.filterEquipmentComboBox.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(21, 32);
            this.label5.Margin = new System.Windows.Forms.Padding(10, 5, 10, 5);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(81, 14);
            this.label5.TabIndex = 2;
            this.label5.Text = "Фильтрация:";
            // 
            // requestTabPage
            // 
            this.requestTabPage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(142)))), ((int)(((byte)(255)))));
            this.requestTabPage.Controls.Add(this.tablePanel);
            this.requestTabPage.Controls.Add(this.searchPanel);
            this.requestTabPage.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.requestTabPage.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(229)))), ((int)(((byte)(229)))));
            this.requestTabPage.Location = new System.Drawing.Point(4, 23);
            this.requestTabPage.Name = "requestTabPage";
            this.requestTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.requestTabPage.Size = new System.Drawing.Size(1256, 674);
            this.requestTabPage.TabIndex = 0;
            this.requestTabPage.Text = "Заявки";
            // 
            // tablePanel
            // 
            this.tablePanel.Controls.Add(this.requestDGV);
            this.tablePanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tablePanel.Location = new System.Drawing.Point(3, 75);
            this.tablePanel.Name = "tablePanel";
            this.tablePanel.Size = new System.Drawing.Size(1250, 596);
            this.tablePanel.TabIndex = 1;
            // 
            // requestDGV
            // 
            this.requestDGV.AllowUserToAddRows = false;
            this.requestDGV.AllowUserToDeleteRows = false;
            this.requestDGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.requestDGV.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(70)))), ((int)(((byte)(209)))));
            this.requestDGV.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.requestDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.requestDGV.Dock = System.Windows.Forms.DockStyle.Fill;
            this.requestDGV.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(70)))), ((int)(((byte)(209)))));
            this.requestDGV.Location = new System.Drawing.Point(0, 0);
            this.requestDGV.MultiSelect = false;
            this.requestDGV.Name = "requestDGV";
            this.requestDGV.ReadOnly = true;
            this.requestDGV.RowHeadersWidth = 62;
            this.requestDGV.RowTemplate.Height = 28;
            this.requestDGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.requestDGV.Size = new System.Drawing.Size(1250, 596);
            this.requestDGV.TabIndex = 0;
            this.requestDGV.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.requestDGV_CellClick);
            // 
            // searchPanel
            // 
            this.searchPanel.Controls.Add(this.groupBox5);
            this.searchPanel.Controls.Add(this.groupBox1);
            this.searchPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.searchPanel.Location = new System.Drawing.Point(3, 3);
            this.searchPanel.Name = "searchPanel";
            this.searchPanel.Size = new System.Drawing.Size(1250, 72);
            this.searchPanel.TabIndex = 0;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.addRequestButton);
            this.groupBox5.Controls.Add(this.deleteRequestButton);
            this.groupBox5.Controls.Add(this.editRequestButton);
            this.groupBox5.Dock = System.Windows.Forms.DockStyle.Right;
            this.groupBox5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox5.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox5.ForeColor = System.Drawing.Color.White;
            this.groupBox5.Location = new System.Drawing.Point(628, 0);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(622, 72);
            this.groupBox5.TabIndex = 2;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Управление заявками";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.searchRequestTextBox);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.filterRequestComboBox);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Left;
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox1.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(622, 72);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Поиск";
            // 
            // searchRequestTextBox
            // 
            this.searchRequestTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(70)))), ((int)(((byte)(209)))));
            this.searchRequestTextBox.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.searchRequestTextBox.ForeColor = System.Drawing.Color.White;
            this.searchRequestTextBox.Location = new System.Drawing.Point(368, 29);
            this.searchRequestTextBox.Margin = new System.Windows.Forms.Padding(10, 5, 10, 5);
            this.searchRequestTextBox.Name = "searchRequestTextBox";
            this.searchRequestTextBox.Size = new System.Drawing.Size(232, 22);
            this.searchRequestTextBox.TabIndex = 4;
            this.searchRequestTextBox.TextChanged += new System.EventHandler(this.searchTextBox_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(297, 32);
            this.label3.Margin = new System.Windows.Forms.Padding(10, 5, 10, 5);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 14);
            this.label3.TabIndex = 3;
            this.label3.Text = "Значение:";
            // 
            // filterRequestComboBox
            // 
            this.filterRequestComboBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(70)))), ((int)(((byte)(209)))));
            this.filterRequestComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.filterRequestComboBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.filterRequestComboBox.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.filterRequestComboBox.ForeColor = System.Drawing.Color.White;
            this.filterRequestComboBox.FormattingEnabled = true;
            this.filterRequestComboBox.Items.AddRange(new object[] {
            "По номеру заявки",
            "По клиенту",
            "По оборудованию",
            "По статусу"});
            this.filterRequestComboBox.Location = new System.Drawing.Point(111, 29);
            this.filterRequestComboBox.Margin = new System.Windows.Forms.Padding(10, 5, 10, 5);
            this.filterRequestComboBox.Name = "filterRequestComboBox";
            this.filterRequestComboBox.Size = new System.Drawing.Size(166, 22);
            this.filterRequestComboBox.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(21, 32);
            this.label2.Margin = new System.Windows.Forms.Padding(10, 5, 10, 5);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 14);
            this.label2.TabIndex = 2;
            this.label2.Text = "Фильтрация:";
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.requestTabPage);
            this.tabControl.Controls.Add(this.commentTabPage);
            this.tabControl.Controls.Add(this.equipmentTabPage);
            this.tabControl.Controls.Add(this.clientTabPage);
            this.tabControl.Controls.Add(this.specialistTabPage);
            this.tabControl.Controls.Add(this.reportTabPage);
            this.tabControl.Controls.Add(this.statisticTabPage);
            this.tabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tabControl.Location = new System.Drawing.Point(0, 60);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(1264, 701);
            this.tabControl.TabIndex = 1;
            this.tabControl.SelectedIndexChanged += new System.EventHandler(this.tabControl1_SelectedIndexChanged);
            // 
            // commentTabPage
            // 
            this.commentTabPage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(142)))), ((int)(((byte)(255)))));
            this.commentTabPage.Controls.Add(this.tabelPanel5);
            this.commentTabPage.Controls.Add(this.searchPanel5);
            this.commentTabPage.Location = new System.Drawing.Point(4, 23);
            this.commentTabPage.Name = "commentTabPage";
            this.commentTabPage.Size = new System.Drawing.Size(1256, 674);
            this.commentTabPage.TabIndex = 6;
            this.commentTabPage.Text = "Комментарии";
            // 
            // tabelPanel5
            // 
            this.tabelPanel5.Controls.Add(this.commentDGV);
            this.tabelPanel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabelPanel5.Location = new System.Drawing.Point(0, 72);
            this.tabelPanel5.Name = "tabelPanel5";
            this.tabelPanel5.Size = new System.Drawing.Size(1256, 602);
            this.tabelPanel5.TabIndex = 2;
            // 
            // commentDGV
            // 
            this.commentDGV.AllowUserToAddRows = false;
            this.commentDGV.AllowUserToDeleteRows = false;
            this.commentDGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.commentDGV.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(70)))), ((int)(((byte)(209)))));
            this.commentDGV.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.commentDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.commentDGV.Dock = System.Windows.Forms.DockStyle.Fill;
            this.commentDGV.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(70)))), ((int)(((byte)(209)))));
            this.commentDGV.Location = new System.Drawing.Point(0, 0);
            this.commentDGV.MultiSelect = false;
            this.commentDGV.Name = "commentDGV";
            this.commentDGV.ReadOnly = true;
            this.commentDGV.RowHeadersWidth = 62;
            this.commentDGV.RowTemplate.Height = 28;
            this.commentDGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.commentDGV.Size = new System.Drawing.Size(1256, 602);
            this.commentDGV.TabIndex = 0;
            this.commentDGV.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.commentDGV_CellClick);
            // 
            // searchPanel5
            // 
            this.searchPanel5.Controls.Add(this.groupBox9);
            this.searchPanel5.Controls.Add(this.groupBox10);
            this.searchPanel5.Dock = System.Windows.Forms.DockStyle.Top;
            this.searchPanel5.Location = new System.Drawing.Point(0, 0);
            this.searchPanel5.Name = "searchPanel5";
            this.searchPanel5.Size = new System.Drawing.Size(1256, 72);
            this.searchPanel5.TabIndex = 1;
            // 
            // groupBox9
            // 
            this.groupBox9.Controls.Add(this.addCommentButton);
            this.groupBox9.Controls.Add(this.deleteCommentButton);
            this.groupBox9.Controls.Add(this.editCommentButton);
            this.groupBox9.Dock = System.Windows.Forms.DockStyle.Right;
            this.groupBox9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox9.ForeColor = System.Drawing.Color.White;
            this.groupBox9.Location = new System.Drawing.Point(634, 0);
            this.groupBox9.Name = "groupBox9";
            this.groupBox9.Size = new System.Drawing.Size(622, 72);
            this.groupBox9.TabIndex = 2;
            this.groupBox9.TabStop = false;
            this.groupBox9.Text = "Управление комментариями";
            // 
            // groupBox10
            // 
            this.groupBox10.Controls.Add(this.searchCommentTextBox);
            this.groupBox10.Controls.Add(this.label10);
            this.groupBox10.Controls.Add(this.filterCommentComboBox);
            this.groupBox10.Controls.Add(this.label11);
            this.groupBox10.Dock = System.Windows.Forms.DockStyle.Left;
            this.groupBox10.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox10.ForeColor = System.Drawing.Color.White;
            this.groupBox10.Location = new System.Drawing.Point(0, 0);
            this.groupBox10.Name = "groupBox10";
            this.groupBox10.Size = new System.Drawing.Size(622, 72);
            this.groupBox10.TabIndex = 1;
            this.groupBox10.TabStop = false;
            this.groupBox10.Text = "Поиск";
            // 
            // searchCommentTextBox
            // 
            this.searchCommentTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(70)))), ((int)(((byte)(209)))));
            this.searchCommentTextBox.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.searchCommentTextBox.ForeColor = System.Drawing.Color.White;
            this.searchCommentTextBox.Location = new System.Drawing.Point(368, 29);
            this.searchCommentTextBox.Margin = new System.Windows.Forms.Padding(10, 5, 10, 5);
            this.searchCommentTextBox.Name = "searchCommentTextBox";
            this.searchCommentTextBox.Size = new System.Drawing.Size(232, 22);
            this.searchCommentTextBox.TabIndex = 4;
            this.searchCommentTextBox.TextChanged += new System.EventHandler(this.searchCommentTextBox_TextChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label10.Location = new System.Drawing.Point(297, 32);
            this.label10.Margin = new System.Windows.Forms.Padding(10, 5, 10, 5);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(65, 14);
            this.label10.TabIndex = 3;
            this.label10.Text = "Значение:";
            // 
            // filterCommentComboBox
            // 
            this.filterCommentComboBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(70)))), ((int)(((byte)(209)))));
            this.filterCommentComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.filterCommentComboBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.filterCommentComboBox.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.filterCommentComboBox.ForeColor = System.Drawing.Color.White;
            this.filterCommentComboBox.FormattingEnabled = true;
            this.filterCommentComboBox.Items.AddRange(new object[] {
            "По номеру комментария",
            "По номеру заявки",
            "По ФИО"});
            this.filterCommentComboBox.Location = new System.Drawing.Point(111, 29);
            this.filterCommentComboBox.Margin = new System.Windows.Forms.Padding(10, 5, 10, 5);
            this.filterCommentComboBox.Name = "filterCommentComboBox";
            this.filterCommentComboBox.Size = new System.Drawing.Size(166, 22);
            this.filterCommentComboBox.TabIndex = 1;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label11.Location = new System.Drawing.Point(21, 32);
            this.label11.Margin = new System.Windows.Forms.Padding(10, 5, 10, 5);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(81, 14);
            this.label11.TabIndex = 2;
            this.label11.Text = "Фильтрация:";
            // 
            // reportTabPage
            // 
            this.reportTabPage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(142)))), ((int)(((byte)(255)))));
            this.reportTabPage.Controls.Add(this.tablePanel6);
            this.reportTabPage.Controls.Add(this.searchPanel6);
            this.reportTabPage.Location = new System.Drawing.Point(4, 23);
            this.reportTabPage.Name = "reportTabPage";
            this.reportTabPage.Size = new System.Drawing.Size(1256, 674);
            this.reportTabPage.TabIndex = 7;
            this.reportTabPage.Text = "Отчеты";
            // 
            // tablePanel6
            // 
            this.tablePanel6.Controls.Add(this.reportDGV);
            this.tablePanel6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tablePanel6.Location = new System.Drawing.Point(0, 72);
            this.tablePanel6.Name = "tablePanel6";
            this.tablePanel6.Size = new System.Drawing.Size(1256, 602);
            this.tablePanel6.TabIndex = 2;
            // 
            // reportDGV
            // 
            this.reportDGV.AllowUserToAddRows = false;
            this.reportDGV.AllowUserToDeleteRows = false;
            this.reportDGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.reportDGV.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(70)))), ((int)(((byte)(209)))));
            this.reportDGV.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.reportDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.reportDGV.Dock = System.Windows.Forms.DockStyle.Fill;
            this.reportDGV.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(70)))), ((int)(((byte)(209)))));
            this.reportDGV.Location = new System.Drawing.Point(0, 0);
            this.reportDGV.MultiSelect = false;
            this.reportDGV.Name = "reportDGV";
            this.reportDGV.ReadOnly = true;
            this.reportDGV.RowHeadersWidth = 62;
            this.reportDGV.RowTemplate.Height = 28;
            this.reportDGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.reportDGV.Size = new System.Drawing.Size(1256, 602);
            this.reportDGV.TabIndex = 0;
            this.reportDGV.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.reportDGV_CellClick);
            // 
            // searchPanel6
            // 
            this.searchPanel6.Controls.Add(this.groupBox11);
            this.searchPanel6.Controls.Add(this.groupBox12);
            this.searchPanel6.Dock = System.Windows.Forms.DockStyle.Top;
            this.searchPanel6.Location = new System.Drawing.Point(0, 0);
            this.searchPanel6.Name = "searchPanel6";
            this.searchPanel6.Size = new System.Drawing.Size(1256, 72);
            this.searchPanel6.TabIndex = 1;
            // 
            // groupBox11
            // 
            this.groupBox11.Controls.Add(this.addReportButton);
            this.groupBox11.Controls.Add(this.deleteReportButton);
            this.groupBox11.Controls.Add(this.editReportButton);
            this.groupBox11.Dock = System.Windows.Forms.DockStyle.Right;
            this.groupBox11.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox11.ForeColor = System.Drawing.Color.White;
            this.groupBox11.Location = new System.Drawing.Point(634, 0);
            this.groupBox11.Name = "groupBox11";
            this.groupBox11.Size = new System.Drawing.Size(622, 72);
            this.groupBox11.TabIndex = 2;
            this.groupBox11.TabStop = false;
            this.groupBox11.Text = "Управление заявками";
            // 
            // groupBox12
            // 
            this.groupBox12.Controls.Add(this.searchReportTextBox);
            this.groupBox12.Controls.Add(this.label12);
            this.groupBox12.Controls.Add(this.filterReportComboBox);
            this.groupBox12.Controls.Add(this.label13);
            this.groupBox12.Dock = System.Windows.Forms.DockStyle.Left;
            this.groupBox12.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox12.ForeColor = System.Drawing.Color.White;
            this.groupBox12.Location = new System.Drawing.Point(0, 0);
            this.groupBox12.Name = "groupBox12";
            this.groupBox12.Size = new System.Drawing.Size(622, 72);
            this.groupBox12.TabIndex = 1;
            this.groupBox12.TabStop = false;
            this.groupBox12.Text = "Поиск";
            // 
            // searchReportTextBox
            // 
            this.searchReportTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(70)))), ((int)(((byte)(209)))));
            this.searchReportTextBox.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.searchReportTextBox.ForeColor = System.Drawing.Color.White;
            this.searchReportTextBox.Location = new System.Drawing.Point(368, 29);
            this.searchReportTextBox.Margin = new System.Windows.Forms.Padding(10, 5, 10, 5);
            this.searchReportTextBox.Name = "searchReportTextBox";
            this.searchReportTextBox.Size = new System.Drawing.Size(232, 22);
            this.searchReportTextBox.TabIndex = 4;
            this.searchReportTextBox.TextChanged += new System.EventHandler(this.searchReportTextBox_TextChanged);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label12.Location = new System.Drawing.Point(297, 32);
            this.label12.Margin = new System.Windows.Forms.Padding(10, 5, 10, 5);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(65, 14);
            this.label12.TabIndex = 3;
            this.label12.Text = "Значение:";
            // 
            // filterReportComboBox
            // 
            this.filterReportComboBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(70)))), ((int)(((byte)(209)))));
            this.filterReportComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.filterReportComboBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.filterReportComboBox.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.filterReportComboBox.ForeColor = System.Drawing.Color.White;
            this.filterReportComboBox.FormattingEnabled = true;
            this.filterReportComboBox.Items.AddRange(new object[] {
            "По номеру отчета",
            "По номеру заявки",
            "По ФИО"});
            this.filterReportComboBox.Location = new System.Drawing.Point(111, 29);
            this.filterReportComboBox.Margin = new System.Windows.Forms.Padding(10, 5, 10, 5);
            this.filterReportComboBox.Name = "filterReportComboBox";
            this.filterReportComboBox.Size = new System.Drawing.Size(166, 22);
            this.filterReportComboBox.TabIndex = 1;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label13.Location = new System.Drawing.Point(21, 32);
            this.label13.Margin = new System.Windows.Forms.Padding(10, 5, 10, 5);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(81, 14);
            this.label13.TabIndex = 2;
            this.label13.Text = "Фильтрация:";
            // 
            // notifyIcon
            // 
            this.notifyIcon.BalloonTipText = "Уведомление!";
            this.notifyIcon.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon.Icon")));
            this.notifyIcon.Text = "notifyIcon1";
            this.notifyIcon.Visible = true;
            // 
            // mainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(142)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(1264, 761);
            this.Controls.Add(this.tabControl);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximumSize = new System.Drawing.Size(1280, 800);
            this.MinimumSize = new System.Drawing.Size(1280, 800);
            this.Name = "mainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Панель управления";
            this.Load += new System.EventHandler(this.mainForm_Load);
            this.statisticTabPage.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chartFaultStats)).EndInit();
            this.kpiPanel.ResumeLayout(false);
            this.specialistTabPage.ResumeLayout(false);
            this.specialistPanel.ResumeLayout(false);
            this.tablePanel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.specialistDGV)).EndInit();
            this.searchPanel4.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox8.ResumeLayout(false);
            this.groupBox8.PerformLayout();
            this.clientTabPage.ResumeLayout(false);
            this.clientPanel.ResumeLayout(false);
            this.tablePanel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.clientDGV)).EndInit();
            this.searchPanel3.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox7.ResumeLayout(false);
            this.groupBox7.PerformLayout();
            this.equipmentTabPage.ResumeLayout(false);
            this.equipmentPanel.ResumeLayout(false);
            this.tablePanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.equipmentDGV)).EndInit();
            this.searchPanel2.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.requestTabPage.ResumeLayout(false);
            this.tablePanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.requestDGV)).EndInit();
            this.searchPanel.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabControl.ResumeLayout(false);
            this.commentTabPage.ResumeLayout(false);
            this.tabelPanel5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.commentDGV)).EndInit();
            this.searchPanel5.ResumeLayout(false);
            this.groupBox9.ResumeLayout(false);
            this.groupBox10.ResumeLayout(false);
            this.groupBox10.PerformLayout();
            this.reportTabPage.ResumeLayout(false);
            this.tablePanel6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.reportDGV)).EndInit();
            this.searchPanel6.ResumeLayout(false);
            this.groupBox11.ResumeLayout(false);
            this.groupBox12.ResumeLayout(false);
            this.groupBox12.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.TabPage statisticTabPage;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.TabPage specialistTabPage;
        private System.Windows.Forms.TabPage clientTabPage;
        private System.Windows.Forms.TabPage equipmentTabPage;
        private System.Windows.Forms.Panel equipmentPanel;
        private System.Windows.Forms.TabPage requestTabPage;
        private System.Windows.Forms.Panel tablePanel;
        private System.Windows.Forms.DataGridView requestDGV;
        private System.Windows.Forms.Panel searchPanel;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox searchRequestTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox filterRequestComboBox;
        public System.Windows.Forms.Label label2;
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Panel searchPanel2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button addEquipmentButton;
        private System.Windows.Forms.Button deleteEquipmentButton;
        private System.Windows.Forms.Button editEquipmentButton;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.TextBox searchEquipmentTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox filterEquipmentComboBox;
        public System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel tablePanel2;
        private System.Windows.Forms.DataGridView equipmentDGV;
        private System.Windows.Forms.Panel clientPanel;
        private System.Windows.Forms.Panel tablePanel3;
        private System.Windows.Forms.DataGridView clientDGV;
        private System.Windows.Forms.Panel searchPanel3;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button addClientButton;
        private System.Windows.Forms.Button deleteClientButton;
        private System.Windows.Forms.Button editClientButton;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.TextBox searchClientTextBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox filterClientComboBox;
        public System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel specialistPanel;
        private System.Windows.Forms.Panel tablePanel4;
        private System.Windows.Forms.DataGridView specialistDGV;
        private System.Windows.Forms.Panel searchPanel4;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button addSpecialistButton;
        private System.Windows.Forms.Button deleteSpecialistButton;
        private System.Windows.Forms.Button editSpecialistButton;
        private System.Windows.Forms.GroupBox groupBox8;
        private System.Windows.Forms.TextBox searchSpecialistTextBox;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox filterSpecialistComboBox;
        public System.Windows.Forms.Label label9;
        private System.Windows.Forms.NotifyIcon notifyIcon;
        private System.Windows.Forms.TabPage commentTabPage;
        private System.Windows.Forms.Panel tabelPanel5;
        private System.Windows.Forms.DataGridView commentDGV;
        private System.Windows.Forms.Panel searchPanel5;
        private System.Windows.Forms.GroupBox groupBox9;
        private System.Windows.Forms.Button addCommentButton;
        private System.Windows.Forms.Button deleteCommentButton;
        private System.Windows.Forms.Button editCommentButton;
        private System.Windows.Forms.GroupBox groupBox10;
        private System.Windows.Forms.TextBox searchCommentTextBox;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox filterCommentComboBox;
        public System.Windows.Forms.Label label11;
        private System.Windows.Forms.TabPage reportTabPage;
        private System.Windows.Forms.Panel tablePanel6;
        private System.Windows.Forms.DataGridView reportDGV;
        private System.Windows.Forms.Panel searchPanel6;
        private System.Windows.Forms.GroupBox groupBox11;
        private System.Windows.Forms.Button addReportButton;
        private System.Windows.Forms.Button deleteReportButton;
        private System.Windows.Forms.Button editReportButton;
        private System.Windows.Forms.GroupBox groupBox12;
        private System.Windows.Forms.TextBox searchReportTextBox;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ComboBox filterReportComboBox;
        public System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label avgTimeLabel;
        private System.Windows.Forms.Label completedCountLabel;
        private System.Windows.Forms.Panel kpiPanel;
        private System.Windows.Forms.Panel panel1;
        public System.Windows.Forms.Button addRequestButton;
        public System.Windows.Forms.Button editRequestButton;
        public System.Windows.Forms.Button deleteRequestButton;
    }
}