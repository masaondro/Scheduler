namespace Scheduler
{
    partial class AddTaskForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.tb_name = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tb_description = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.rb_1 = new System.Windows.Forms.RadioButton();
            this.rb_2 = new System.Windows.Forms.RadioButton();
            this.rb_3 = new System.Windows.Forms.RadioButton();
            this.rb_4 = new System.Windows.Forms.RadioButton();
            this.rb_5 = new System.Windows.Forms.RadioButton();
            this.label4 = new System.Windows.Forms.Label();
            this.dtp_date = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.cb_today = new System.Windows.Forms.CheckBox();
            this.bt_add = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(52, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Название";
            // 
            // tb_name
            // 
            this.tb_name.Location = new System.Drawing.Point(55, 85);
            this.tb_name.MaxLength = 50;
            this.tb_name.Name = "tb_name";
            this.tb_name.Size = new System.Drawing.Size(128, 22);
            this.tb_name.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(55, 128);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Описание";
            // 
            // tb_description
            // 
            this.tb_description.Location = new System.Drawing.Point(55, 161);
            this.tb_description.Multiline = true;
            this.tb_description.Name = "tb_description";
            this.tb_description.Size = new System.Drawing.Size(495, 99);
            this.tb_description.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(55, 287);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "Приоритет";
            // 
            // rb_1
            // 
            this.rb_1.AutoSize = true;
            this.rb_1.Location = new System.Drawing.Point(58, 308);
            this.rb_1.Name = "rb_1";
            this.rb_1.Size = new System.Drawing.Size(37, 21);
            this.rb_1.TabIndex = 5;
            this.rb_1.TabStop = true;
            this.rb_1.Text = "1";
            this.rb_1.UseVisualStyleBackColor = true;
            // 
            // rb_2
            // 
            this.rb_2.AutoSize = true;
            this.rb_2.Location = new System.Drawing.Point(101, 308);
            this.rb_2.Name = "rb_2";
            this.rb_2.Size = new System.Drawing.Size(37, 21);
            this.rb_2.TabIndex = 6;
            this.rb_2.TabStop = true;
            this.rb_2.Text = "2";
            this.rb_2.UseVisualStyleBackColor = true;
            // 
            // rb_3
            // 
            this.rb_3.AutoSize = true;
            this.rb_3.Location = new System.Drawing.Point(144, 308);
            this.rb_3.Name = "rb_3";
            this.rb_3.Size = new System.Drawing.Size(37, 21);
            this.rb_3.TabIndex = 7;
            this.rb_3.TabStop = true;
            this.rb_3.Text = "3";
            this.rb_3.UseVisualStyleBackColor = true;
            // 
            // rb_4
            // 
            this.rb_4.AutoSize = true;
            this.rb_4.Location = new System.Drawing.Point(187, 308);
            this.rb_4.Name = "rb_4";
            this.rb_4.Size = new System.Drawing.Size(37, 21);
            this.rb_4.TabIndex = 8;
            this.rb_4.TabStop = true;
            this.rb_4.Text = "4";
            this.rb_4.UseVisualStyleBackColor = true;
            // 
            // rb_5
            // 
            this.rb_5.AutoSize = true;
            this.rb_5.Location = new System.Drawing.Point(230, 308);
            this.rb_5.Name = "rb_5";
            this.rb_5.Size = new System.Drawing.Size(37, 21);
            this.rb_5.TabIndex = 9;
            this.rb_5.TabStop = true;
            this.rb_5.Text = "5";
            this.rb_5.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(55, 360);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 17);
            this.label4.TabIndex = 10;
            this.label4.Text = "Крайняя дата";
            // 
            // dtp_date
            // 
            this.dtp_date.Location = new System.Drawing.Point(58, 392);
            this.dtp_date.Name = "dtp_date";
            this.dtp_date.Size = new System.Drawing.Size(200, 22);
            this.dtp_date.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(58, 444);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(119, 17);
            this.label5.TabIndex = 12;
            this.label5.Text = "Сделать сегодня";
            // 
            // cb_today
            // 
            this.cb_today.AutoSize = true;
            this.cb_today.Location = new System.Drawing.Point(187, 444);
            this.cb_today.Name = "cb_today";
            this.cb_today.Size = new System.Drawing.Size(18, 17);
            this.cb_today.TabIndex = 13;
            this.cb_today.UseVisualStyleBackColor = true;
            // 
            // bt_add
            // 
            this.bt_add.Location = new System.Drawing.Point(654, 478);
            this.bt_add.Name = "bt_add";
            this.bt_add.Size = new System.Drawing.Size(94, 32);
            this.bt_add.TabIndex = 14;
            this.bt_add.Text = "Добавить";
            this.bt_add.UseVisualStyleBackColor = true;
            this.bt_add.Click += new System.EventHandler(this.bt_add_Click);
            // 
            // AddTaskForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 538);
            this.Controls.Add(this.bt_add);
            this.Controls.Add(this.cb_today);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dtp_date);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.rb_5);
            this.Controls.Add(this.rb_4);
            this.Controls.Add(this.rb_3);
            this.Controls.Add(this.rb_2);
            this.Controls.Add(this.rb_1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tb_description);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tb_name);
            this.Controls.Add(this.label1);
            this.Name = "AddTaskForm";
            this.Text = "AddTaskForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button bt_add;
        public System.Windows.Forms.TextBox tb_name;
        public System.Windows.Forms.TextBox tb_description;
        public System.Windows.Forms.RadioButton rb_1;
        public System.Windows.Forms.RadioButton rb_2;
        public System.Windows.Forms.RadioButton rb_3;
        public System.Windows.Forms.RadioButton rb_4;
        public System.Windows.Forms.RadioButton rb_5;
        public System.Windows.Forms.DateTimePicker dtp_date;
        public System.Windows.Forms.CheckBox cb_today;
    }
}