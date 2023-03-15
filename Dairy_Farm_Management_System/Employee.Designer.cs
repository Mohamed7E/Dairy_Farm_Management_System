
namespace Dairy_Farm_Management_System
{
    partial class Employee
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Employee));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle19 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle20 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle21 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label18 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.pictureBox8 = new System.Windows.Forms.PictureBox();
            this.data = new System.Windows.Forms.DateTimePicker();
            this.Healthlist = new Guna.UI2.WinForms.Guna2DataGridView();
            this.CowIdCb = new System.Windows.Forms.ComboBox();
            this.label19 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.CowNAmeTb = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.EventTb = new System.Windows.Forms.TextBox();
            this.E = new System.Windows.Forms.Label();
            this.DiagnosisTb = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Healthlist)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(117, 77);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(110, 46);
            this.label18.TabIndex = 30;
            this.label18.Text = "DFSM";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(708, 220);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(100, 46);
            this.label5.TabIndex = 101;
            this.label5.Text = "Date ";
            // 
            // pictureBox8
            // 
            this.pictureBox8.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox8.Image")));
            this.pictureBox8.Location = new System.Drawing.Point(13, 50);
            this.pictureBox8.Name = "pictureBox8";
            this.pictureBox8.Size = new System.Drawing.Size(98, 98);
            this.pictureBox8.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox8.TabIndex = 29;
            this.pictureBox8.TabStop = false;
            // 
            // data
            // 
            this.data.CalendarFont = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.data.CustomFormat = "yyyy-MM-dd";
            this.data.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.data.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.data.Location = new System.Drawing.Point(708, 279);
            this.data.Margin = new System.Windows.Forms.Padding(4);
            this.data.Name = "data";
            this.data.Size = new System.Drawing.Size(276, 40);
            this.data.TabIndex = 100;
            this.data.ValueChanged += new System.EventHandler(this.data_ValueChanged);
            // 
            // Healthlist
            // 
            dataGridViewCellStyle19.BackColor = System.Drawing.Color.White;
            this.Healthlist.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle19;
            dataGridViewCellStyle20.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle20.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle20.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle20.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle20.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle20.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle20.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Healthlist.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle20;
            this.Healthlist.ColumnHeadersHeight = 27;
            this.Healthlist.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle21.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle21.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle21.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle21.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle21.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle21.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle21.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.Healthlist.DefaultCellStyle = dataGridViewCellStyle21;
            this.Healthlist.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.Healthlist.Location = new System.Drawing.Point(274, 534);
            this.Healthlist.Name = "Healthlist";
            this.Healthlist.RowHeadersVisible = false;
            this.Healthlist.RowHeadersWidth = 51;
            this.Healthlist.Size = new System.Drawing.Size(1189, 254);
            this.Healthlist.TabIndex = 99;
            this.Healthlist.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.Healthlist.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.Healthlist.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.Healthlist.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.Healthlist.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.Healthlist.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.Healthlist.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.Healthlist.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.Healthlist.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.Healthlist.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Healthlist.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.Healthlist.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.Healthlist.ThemeStyle.HeaderStyle.Height = 27;
            this.Healthlist.ThemeStyle.ReadOnly = false;
            this.Healthlist.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.Healthlist.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.Healthlist.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Healthlist.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.Healthlist.ThemeStyle.RowsStyle.Height = 22;
            this.Healthlist.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.Healthlist.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // CowIdCb
            // 
            this.CowIdCb.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.CowIdCb.FormattingEnabled = true;
            this.CowIdCb.Items.AddRange(new object[] {
            "Male ",
            "Female"});
            this.CowIdCb.Location = new System.Drawing.Point(919, 150);
            this.CowIdCb.Name = "CowIdCb";
            this.CowIdCb.Size = new System.Drawing.Size(286, 39);
            this.CowIdCb.TabIndex = 97;
            this.CowIdCb.SelectedIndexChanged += new System.EventHandler(this.CowIdCb_SelectedIndexChanged);
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label19.Location = new System.Drawing.Point(735, 77);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(114, 31);
            this.label19.TabIndex = 96;
            this.label19.Text = "Employee";
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.Location = new System.Drawing.Point(869, 361);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(216, 55);
            this.button2.TabIndex = 95;
            this.button2.Text = "Delete";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.Location = new System.Drawing.Point(564, 361);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(216, 55);
            this.button1.TabIndex = 94;
            this.button1.Text = "Edit";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.button4.FlatAppearance.BorderSize = 0;
            this.button4.Location = new System.Drawing.Point(268, 361);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(216, 55);
            this.button4.TabIndex = 93;
            this.button4.Text = "Save";
            this.button4.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.Location = new System.Drawing.Point(1168, 361);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(216, 55);
            this.button3.TabIndex = 92;
            this.button3.Text = "Clear";
            this.button3.UseVisualStyleBackColor = false;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(759, 442);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(225, 46);
            this.label10.TabIndex = 79;
            this.label10.Text = "Employee List";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(564, 102);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(109, 46);
            this.label7.TabIndex = 89;
            this.label7.Text = "Name";
            // 
            // CowNAmeTb
            // 
            this.CowNAmeTb.Enabled = false;
            this.CowNAmeTb.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.CowNAmeTb.Location = new System.Drawing.Point(564, 151);
            this.CowNAmeTb.Name = "CowNAmeTb";
            this.CowNAmeTb.Size = new System.Drawing.Size(276, 38);
            this.CowNAmeTb.TabIndex = 90;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(1022, 220);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(140, 46);
            this.label6.TabIndex = 87;
            this.label6.Text = "Address";
            // 
            // EventTb
            // 
            this.EventTb.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.EventTb.Location = new System.Drawing.Point(383, 281);
            this.EventTb.Name = "EventTb";
            this.EventTb.Size = new System.Drawing.Size(276, 38);
            this.EventTb.TabIndex = 88;
            this.EventTb.TextChanged += new System.EventHandler(this.EventTb_TextChanged);
            // 
            // E
            // 
            this.E.AutoSize = true;
            this.E.Location = new System.Drawing.Point(383, 220);
            this.E.Name = "E";
            this.E.Size = new System.Drawing.Size(115, 46);
            this.E.TabIndex = 85;
            this.E.Text = "Phone";
            // 
            // DiagnosisTb
            // 
            this.DiagnosisTb.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.DiagnosisTb.Location = new System.Drawing.Point(1022, 278);
            this.DiagnosisTb.Name = "DiagnosisTb";
            this.DiagnosisTb.Size = new System.Drawing.Size(276, 38);
            this.DiagnosisTb.TabIndex = 86;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(946, 102);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(139, 46);
            this.label2.TabIndex = 78;
            this.label2.Text = "Gender ";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(232, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1245, 50);
            this.panel2.TabIndex = 80;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(605, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 46);
            this.label1.TabIndex = 0;
            this.label1.Text = "DFSM";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.panel1.Controls.Add(this.label18);
            this.panel1.Controls.Add(this.pictureBox8);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(250, 840);
            this.panel1.TabIndex = 77;
            // 
            // Employee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(18F, 45F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1476, 840);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.data);
            this.Controls.Add(this.Healthlist);
            this.Controls.Add(this.CowIdCb);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.CowNAmeTb);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.EventTb);
            this.Controls.Add(this.E);
            this.Controls.Add(this.DiagnosisTb);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(7, 7, 7, 7);
            this.Name = "Employee";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Employee";
            this.Load += new System.EventHandler(this.Employee_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Healthlist)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox pictureBox8;
        private System.Windows.Forms.DateTimePicker data;
        private Guna.UI2.WinForms.Guna2DataGridView Healthlist;
        private System.Windows.Forms.ComboBox CowIdCb;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox CowNAmeTb;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox EventTb;
        private System.Windows.Forms.Label E;
        private System.Windows.Forms.TextBox DiagnosisTb;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
    }
}