using System.Drawing;
using System.Windows.Forms;

namespace statisticRequest
{
    partial class editReport
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(editReport));
            this.labelRequest = new System.Windows.Forms.Label();
            this.comboBoxRequest = new System.Windows.Forms.ComboBox();
            this.labelSpecialist = new System.Windows.Forms.Label();
            this.comboBoxSpecialist = new System.Windows.Forms.ComboBox();
            this.labelDescription = new System.Windows.Forms.Label();
            this.richTextBoxDescription = new System.Windows.Forms.RichTextBox();
            this.labelTime = new System.Windows.Forms.Label();
            this.textBoxTime = new System.Windows.Forms.TextBox();
            this.labelMaterial = new System.Windows.Forms.Label();
            this.textBoxMaterial = new System.Windows.Forms.TextBox();
            this.labelTotal = new System.Windows.Forms.Label();
            this.textBoxTotal = new System.Windows.Forms.TextBox();
            this.labelDate = new System.Windows.Forms.Label();
            this.maskedTextBoxDate = new System.Windows.Forms.MaskedTextBox();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelRequest
            // 
            this.labelRequest.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelRequest.Location = new System.Drawing.Point(12, 9);
            this.labelRequest.Name = "labelRequest";
            this.labelRequest.Size = new System.Drawing.Size(171, 25);
            this.labelRequest.TabIndex = 30;
            this.labelRequest.Text = "Заявка:";
            // 
            // comboBoxRequest
            // 
            this.comboBoxRequest.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(70)))), ((int)(((byte)(209)))));
            this.comboBoxRequest.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxRequest.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBoxRequest.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBoxRequest.ForeColor = System.Drawing.Color.White;
            this.comboBoxRequest.Location = new System.Drawing.Point(189, 9);
            this.comboBoxRequest.Name = "comboBoxRequest";
            this.comboBoxRequest.Size = new System.Drawing.Size(273, 26);
            this.comboBoxRequest.TabIndex = 31;
            // 
            // labelSpecialist
            // 
            this.labelSpecialist.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelSpecialist.Location = new System.Drawing.Point(12, 49);
            this.labelSpecialist.Name = "labelSpecialist";
            this.labelSpecialist.Size = new System.Drawing.Size(171, 25);
            this.labelSpecialist.TabIndex = 32;
            this.labelSpecialist.Text = "Специалист:";
            // 
            // comboBoxSpecialist
            // 
            this.comboBoxSpecialist.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(70)))), ((int)(((byte)(209)))));
            this.comboBoxSpecialist.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxSpecialist.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBoxSpecialist.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBoxSpecialist.ForeColor = System.Drawing.Color.White;
            this.comboBoxSpecialist.Location = new System.Drawing.Point(189, 49);
            this.comboBoxSpecialist.Name = "comboBoxSpecialist";
            this.comboBoxSpecialist.Size = new System.Drawing.Size(273, 26);
            this.comboBoxSpecialist.TabIndex = 33;
            // 
            // labelDescription
            // 
            this.labelDescription.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelDescription.Location = new System.Drawing.Point(12, 89);
            this.labelDescription.Name = "labelDescription";
            this.labelDescription.Size = new System.Drawing.Size(171, 25);
            this.labelDescription.TabIndex = 34;
            this.labelDescription.Text = "Описание:";
            // 
            // richTextBoxDescription
            // 
            this.richTextBoxDescription.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(70)))), ((int)(((byte)(209)))));
            this.richTextBoxDescription.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.richTextBoxDescription.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.richTextBoxDescription.ForeColor = System.Drawing.Color.White;
            this.richTextBoxDescription.Location = new System.Drawing.Point(189, 89);
            this.richTextBoxDescription.Name = "richTextBoxDescription";
            this.richTextBoxDescription.Size = new System.Drawing.Size(273, 60);
            this.richTextBoxDescription.TabIndex = 35;
            this.richTextBoxDescription.Text = "";
            // 
            // labelTime
            // 
            this.labelTime.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelTime.Location = new System.Drawing.Point(12, 159);
            this.labelTime.Name = "labelTime";
            this.labelTime.Size = new System.Drawing.Size(171, 25);
            this.labelTime.TabIndex = 36;
            this.labelTime.Text = "Время (часы):";
            // 
            // textBoxTime
            // 
            this.textBoxTime.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(70)))), ((int)(((byte)(209)))));
            this.textBoxTime.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxTime.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxTime.ForeColor = System.Drawing.Color.White;
            this.textBoxTime.Location = new System.Drawing.Point(189, 159);
            this.textBoxTime.Name = "textBoxTime";
            this.textBoxTime.Size = new System.Drawing.Size(273, 26);
            this.textBoxTime.TabIndex = 37;
            // 
            // labelMaterial
            // 
            this.labelMaterial.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelMaterial.Location = new System.Drawing.Point(11, 199);
            this.labelMaterial.Name = "labelMaterial";
            this.labelMaterial.Size = new System.Drawing.Size(167, 25);
            this.labelMaterial.TabIndex = 38;
            this.labelMaterial.Text = "Стоимость запчастей:";
            // 
            // textBoxMaterial
            // 
            this.textBoxMaterial.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(70)))), ((int)(((byte)(209)))));
            this.textBoxMaterial.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxMaterial.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxMaterial.ForeColor = System.Drawing.Color.White;
            this.textBoxMaterial.Location = new System.Drawing.Point(189, 199);
            this.textBoxMaterial.Name = "textBoxMaterial";
            this.textBoxMaterial.Size = new System.Drawing.Size(273, 26);
            this.textBoxMaterial.TabIndex = 39;
            // 
            // labelTotal
            // 
            this.labelTotal.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelTotal.Location = new System.Drawing.Point(12, 239);
            this.labelTotal.Name = "labelTotal";
            this.labelTotal.Size = new System.Drawing.Size(171, 25);
            this.labelTotal.TabIndex = 40;
            this.labelTotal.Text = "Стоимость:";
            // 
            // textBoxTotal
            // 
            this.textBoxTotal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(70)))), ((int)(((byte)(209)))));
            this.textBoxTotal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxTotal.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxTotal.ForeColor = System.Drawing.Color.White;
            this.textBoxTotal.Location = new System.Drawing.Point(189, 239);
            this.textBoxTotal.Name = "textBoxTotal";
            this.textBoxTotal.Size = new System.Drawing.Size(273, 26);
            this.textBoxTotal.TabIndex = 41;
            // 
            // labelDate
            // 
            this.labelDate.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelDate.Location = new System.Drawing.Point(12, 279);
            this.labelDate.Name = "labelDate";
            this.labelDate.Size = new System.Drawing.Size(166, 25);
            this.labelDate.TabIndex = 42;
            this.labelDate.Text = "Дата:";
            // 
            // maskedTextBoxDate
            // 
            this.maskedTextBoxDate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(70)))), ((int)(((byte)(209)))));
            this.maskedTextBoxDate.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.maskedTextBoxDate.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.maskedTextBoxDate.ForeColor = System.Drawing.Color.White;
            this.maskedTextBoxDate.Location = new System.Drawing.Point(189, 279);
            this.maskedTextBoxDate.Mask = "00.00.0000";
            this.maskedTextBoxDate.Name = "maskedTextBoxDate";
            this.maskedTextBoxDate.Size = new System.Drawing.Size(120, 26);
            this.maskedTextBoxDate.TabIndex = 43;
            // 
            // buttonAdd
            // 
            this.buttonAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(70)))), ((int)(((byte)(209)))));
            this.buttonAdd.FlatAppearance.BorderSize = 0;
            this.buttonAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAdd.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonAdd.ForeColor = System.Drawing.Color.White;
            this.buttonAdd.Location = new System.Drawing.Point(179, 321);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(120, 35);
            this.buttonAdd.TabIndex = 44;
            this.buttonAdd.Text = "Редактировать";
            this.buttonAdd.UseVisualStyleBackColor = false;
            // 
            // editReport
            // 
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(142)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(483, 368);
            this.Controls.Add(this.labelRequest);
            this.Controls.Add(this.comboBoxRequest);
            this.Controls.Add(this.labelSpecialist);
            this.Controls.Add(this.comboBoxSpecialist);
            this.Controls.Add(this.labelDescription);
            this.Controls.Add(this.richTextBoxDescription);
            this.Controls.Add(this.labelTime);
            this.Controls.Add(this.textBoxTime);
            this.Controls.Add(this.labelMaterial);
            this.Controls.Add(this.textBoxMaterial);
            this.Controls.Add(this.labelTotal);
            this.Controls.Add(this.textBoxTotal);
            this.Controls.Add(this.labelDate);
            this.Controls.Add(this.maskedTextBoxDate);
            this.Controls.Add(this.buttonAdd);
            this.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(499, 407);
            this.MinimumSize = new System.Drawing.Size(499, 407);
            this.Name = "editReport";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Редактирование отчета";
            this.Load += new System.EventHandler(this.editReport_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label labelRequest;
        private ComboBox comboBoxRequest;
        private Label labelSpecialist;
        private ComboBox comboBoxSpecialist;
        private Label labelDescription;
        private RichTextBox richTextBoxDescription;
        private Label labelTime;
        private TextBox textBoxTime;
        private Label labelMaterial;
        private TextBox textBoxMaterial;
        private Label labelTotal;
        private TextBox textBoxTotal;
        private Label labelDate;
        private MaskedTextBox maskedTextBoxDate;
        private Button buttonAdd;
    }
}
