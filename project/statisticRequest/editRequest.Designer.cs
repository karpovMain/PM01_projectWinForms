using System.Drawing;
using System.Windows.Forms;

namespace statisticRequest
{
    partial class editRequest
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(editRequest));
            this.labelDate = new System.Windows.Forms.Label();
            this.maskedTextBoxDate = new System.Windows.Forms.MaskedTextBox();
            this.labelClient = new System.Windows.Forms.Label();
            this.comboBoxClient = new System.Windows.Forms.ComboBox();
            this.labelEquipment = new System.Windows.Forms.Label();
            this.comboBoxEquipment = new System.Windows.Forms.ComboBox();
            this.labelType = new System.Windows.Forms.Label();
            this.comboBoxType = new System.Windows.Forms.ComboBox();
            this.labelDescription = new System.Windows.Forms.Label();
            this.richTextBoxDescription = new System.Windows.Forms.RichTextBox();
            this.labelStatus = new System.Windows.Forms.Label();
            this.comboBoxStatus = new System.Windows.Forms.ComboBox();
            this.labelSpecialist = new System.Windows.Forms.Label();
            this.comboBoxSpecialist = new System.Windows.Forms.ComboBox();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelDate
            // 
            this.labelDate.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelDate.Location = new System.Drawing.Point(12, 9);
            this.labelDate.Name = "labelDate";
            this.labelDate.Size = new System.Drawing.Size(150, 25);
            this.labelDate.TabIndex = 30;
            this.labelDate.Text = "Дата:";
            // 
            // maskedTextBoxDate
            // 
            this.maskedTextBoxDate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(70)))), ((int)(((byte)(209)))));
            this.maskedTextBoxDate.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.maskedTextBoxDate.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.maskedTextBoxDate.ForeColor = System.Drawing.Color.White;
            this.maskedTextBoxDate.Location = new System.Drawing.Point(172, 9);
            this.maskedTextBoxDate.Mask = "00.00.0000";
            this.maskedTextBoxDate.Name = "maskedTextBoxDate";
            this.maskedTextBoxDate.Size = new System.Drawing.Size(100, 26);
            this.maskedTextBoxDate.TabIndex = 31;
            // 
            // labelClient
            // 
            this.labelClient.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelClient.Location = new System.Drawing.Point(12, 49);
            this.labelClient.Name = "labelClient";
            this.labelClient.Size = new System.Drawing.Size(150, 25);
            this.labelClient.TabIndex = 32;
            this.labelClient.Text = "Клиент:";
            // 
            // comboBoxClient
            // 
            this.comboBoxClient.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(70)))), ((int)(((byte)(209)))));
            this.comboBoxClient.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxClient.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBoxClient.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBoxClient.ForeColor = System.Drawing.Color.White;
            this.comboBoxClient.Location = new System.Drawing.Point(172, 49);
            this.comboBoxClient.Name = "comboBoxClient";
            this.comboBoxClient.Size = new System.Drawing.Size(340, 26);
            this.comboBoxClient.TabIndex = 33;
            // 
            // labelEquipment
            // 
            this.labelEquipment.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelEquipment.Location = new System.Drawing.Point(12, 89);
            this.labelEquipment.Name = "labelEquipment";
            this.labelEquipment.Size = new System.Drawing.Size(150, 25);
            this.labelEquipment.TabIndex = 34;
            this.labelEquipment.Text = "Оборудование:";
            // 
            // comboBoxEquipment
            // 
            this.comboBoxEquipment.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(70)))), ((int)(((byte)(209)))));
            this.comboBoxEquipment.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxEquipment.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBoxEquipment.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBoxEquipment.ForeColor = System.Drawing.Color.White;
            this.comboBoxEquipment.Location = new System.Drawing.Point(172, 89);
            this.comboBoxEquipment.Name = "comboBoxEquipment";
            this.comboBoxEquipment.Size = new System.Drawing.Size(340, 26);
            this.comboBoxEquipment.TabIndex = 35;
            // 
            // labelType
            // 
            this.labelType.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelType.Location = new System.Drawing.Point(12, 129);
            this.labelType.Name = "labelType";
            this.labelType.Size = new System.Drawing.Size(150, 25);
            this.labelType.TabIndex = 36;
            this.labelType.Text = "Тип ремонта:";
            // 
            // comboBoxType
            // 
            this.comboBoxType.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(70)))), ((int)(((byte)(209)))));
            this.comboBoxType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxType.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBoxType.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBoxType.ForeColor = System.Drawing.Color.White;
            this.comboBoxType.Location = new System.Drawing.Point(172, 129);
            this.comboBoxType.Name = "comboBoxType";
            this.comboBoxType.Size = new System.Drawing.Size(340, 26);
            this.comboBoxType.TabIndex = 37;
            // 
            // labelDescription
            // 
            this.labelDescription.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelDescription.Location = new System.Drawing.Point(12, 169);
            this.labelDescription.Name = "labelDescription";
            this.labelDescription.Size = new System.Drawing.Size(150, 25);
            this.labelDescription.TabIndex = 38;
            this.labelDescription.Text = "Описание:";
            // 
            // richTextBoxDescription
            // 
            this.richTextBoxDescription.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(70)))), ((int)(((byte)(209)))));
            this.richTextBoxDescription.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.richTextBoxDescription.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.richTextBoxDescription.ForeColor = System.Drawing.Color.White;
            this.richTextBoxDescription.Location = new System.Drawing.Point(172, 169);
            this.richTextBoxDescription.Name = "richTextBoxDescription";
            this.richTextBoxDescription.Size = new System.Drawing.Size(340, 60);
            this.richTextBoxDescription.TabIndex = 39;
            this.richTextBoxDescription.Text = "";
            // 
            // labelStatus
            // 
            this.labelStatus.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelStatus.Location = new System.Drawing.Point(12, 239);
            this.labelStatus.Name = "labelStatus";
            this.labelStatus.Size = new System.Drawing.Size(150, 25);
            this.labelStatus.TabIndex = 40;
            this.labelStatus.Text = "Статус:";
            // 
            // comboBoxStatus
            // 
            this.comboBoxStatus.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(70)))), ((int)(((byte)(209)))));
            this.comboBoxStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxStatus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBoxStatus.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBoxStatus.ForeColor = System.Drawing.Color.White;
            this.comboBoxStatus.Location = new System.Drawing.Point(172, 239);
            this.comboBoxStatus.Name = "comboBoxStatus";
            this.comboBoxStatus.Size = new System.Drawing.Size(340, 26);
            this.comboBoxStatus.TabIndex = 41;
            // 
            // labelSpecialist
            // 
            this.labelSpecialist.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelSpecialist.Location = new System.Drawing.Point(12, 279);
            this.labelSpecialist.Name = "labelSpecialist";
            this.labelSpecialist.Size = new System.Drawing.Size(150, 25);
            this.labelSpecialist.TabIndex = 42;
            this.labelSpecialist.Text = "Специалист:";
            // 
            // comboBoxSpecialist
            // 
            this.comboBoxSpecialist.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(70)))), ((int)(((byte)(209)))));
            this.comboBoxSpecialist.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxSpecialist.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBoxSpecialist.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBoxSpecialist.ForeColor = System.Drawing.Color.White;
            this.comboBoxSpecialist.Location = new System.Drawing.Point(172, 279);
            this.comboBoxSpecialist.Name = "comboBoxSpecialist";
            this.comboBoxSpecialist.Size = new System.Drawing.Size(340, 26);
            this.comboBoxSpecialist.TabIndex = 43;
            // 
            // buttonAdd
            // 
            this.buttonAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(70)))), ((int)(((byte)(209)))));
            this.buttonAdd.FlatAppearance.BorderSize = 0;
            this.buttonAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAdd.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonAdd.ForeColor = System.Drawing.Color.White;
            this.buttonAdd.Location = new System.Drawing.Point(200, 325);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(120, 35);
            this.buttonAdd.TabIndex = 44;
            this.buttonAdd.Text = "Редактировать";
            this.buttonAdd.UseVisualStyleBackColor = false;
            // 
            // editRequest
            // 
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(142)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(536, 385);
            this.Controls.Add(this.labelDate);
            this.Controls.Add(this.maskedTextBoxDate);
            this.Controls.Add(this.labelClient);
            this.Controls.Add(this.comboBoxClient);
            this.Controls.Add(this.labelEquipment);
            this.Controls.Add(this.comboBoxEquipment);
            this.Controls.Add(this.labelType);
            this.Controls.Add(this.comboBoxType);
            this.Controls.Add(this.labelDescription);
            this.Controls.Add(this.richTextBoxDescription);
            this.Controls.Add(this.labelStatus);
            this.Controls.Add(this.comboBoxStatus);
            this.Controls.Add(this.labelSpecialist);
            this.Controls.Add(this.comboBoxSpecialist);
            this.Controls.Add(this.buttonAdd);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ForeColor = System.Drawing.Color.White;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(552, 424);
            this.MinimumSize = new System.Drawing.Size(552, 424);
            this.Name = "editRequest";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Редактирование заявки";
            this.Load += new System.EventHandler(this.editRequest_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label labelDate;
        private MaskedTextBox maskedTextBoxDate;
        private Label labelClient;
        private ComboBox comboBoxClient;
        private Label labelEquipment;
        private ComboBox comboBoxEquipment;
        private Label labelType;
        private ComboBox comboBoxType;
        private Label labelDescription;
        private RichTextBox richTextBoxDescription;
        private Label labelStatus;
        private ComboBox comboBoxStatus;
        private Label labelSpecialist;
        private ComboBox comboBoxSpecialist;
        private Button buttonAdd;
    }
}
