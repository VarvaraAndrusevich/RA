namespace RA
{
    partial class Main
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
            this.newData = new System.Windows.Forms.Button();
            this.editData = new System.Windows.Forms.Button();
            this.searchData = new System.Windows.Forms.Button();
            this.reportData = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.inputLogin = new System.Windows.Forms.TextBox();
            this.inputPass = new System.Windows.Forms.TextBox();
            this.authorization = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // newData
            // 
            this.newData.Location = new System.Drawing.Point(13, 13);
            this.newData.Name = "newData";
            this.newData.Size = new System.Drawing.Size(172, 41);
            this.newData.TabIndex = 0;
            this.newData.Text = "Новая запись";
            this.newData.UseVisualStyleBackColor = true;
            // 
            // editData
            // 
            this.editData.Location = new System.Drawing.Point(13, 70);
            this.editData.Name = "editData";
            this.editData.Size = new System.Drawing.Size(172, 41);
            this.editData.TabIndex = 1;
            this.editData.Text = "Редактирование";
            this.editData.UseVisualStyleBackColor = true;
            // 
            // searchData
            // 
            this.searchData.Location = new System.Drawing.Point(13, 127);
            this.searchData.Name = "searchData";
            this.searchData.Size = new System.Drawing.Size(172, 41);
            this.searchData.TabIndex = 2;
            this.searchData.Text = "Поиск";
            this.searchData.UseVisualStyleBackColor = true;
            // 
            // reportData
            // 
            this.reportData.Location = new System.Drawing.Point(13, 184);
            this.reportData.Name = "reportData";
            this.reportData.Size = new System.Drawing.Size(172, 41);
            this.reportData.TabIndex = 3;
            this.reportData.Text = "Отчетность";
            this.reportData.UseVisualStyleBackColor = true;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(201, 13);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(378, 238);
            this.listBox1.TabIndex = 4;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(463, 261);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(116, 20);
            this.dateTimePicker1.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(312, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(185, 26);
            this.label1.TabIndex = 6;
            this.label1.Text = "АВТОРИЗАЦИЯ:";
            // 
            // inputLogin
            // 
            this.inputLogin.Location = new System.Drawing.Point(317, 81);
            this.inputLogin.Name = "inputLogin";
            this.inputLogin.Size = new System.Drawing.Size(168, 20);
            this.inputLogin.TabIndex = 7;
            // 
            // inputPass
            // 
            this.inputPass.Location = new System.Drawing.Point(317, 127);
            this.inputPass.Name = "inputPass";
            this.inputPass.Size = new System.Drawing.Size(168, 20);
            this.inputPass.TabIndex = 8;
            // 
            // authorization
            // 
            this.authorization.Location = new System.Drawing.Point(362, 170);
            this.authorization.Name = "authorization";
            this.authorization.Size = new System.Drawing.Size(75, 23);
            this.authorization.TabIndex = 9;
            this.authorization.Text = "Вход";
            this.authorization.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 267);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(170, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Разработали РА, г. Минск, 2017";
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(591, 293);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.authorization);
            this.Controls.Add(this.inputPass);
            this.Controls.Add(this.inputLogin);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.reportData);
            this.Controls.Add(this.searchData);
            this.Controls.Add(this.editData);
            this.Controls.Add(this.newData);
            this.Name = "Main";
            this.Text = "ПО для работы с данными по РЩЖ";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button newData;
        private System.Windows.Forms.Button editData;
        private System.Windows.Forms.Button searchData;
        private System.Windows.Forms.Button reportData;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox inputLogin;
        private System.Windows.Forms.TextBox inputPass;
        private System.Windows.Forms.Button authorization;
        private System.Windows.Forms.Label label2;
    }
}

