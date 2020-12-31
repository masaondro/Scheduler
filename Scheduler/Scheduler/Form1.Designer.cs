namespace Scheduler
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.lb_allTasks = new System.Windows.Forms.Label();
            this.lb_doToday = new System.Windows.Forms.Label();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.bt_addTask = new System.Windows.Forms.Button();
            this.pn_allTasks = new System.Windows.Forms.Panel();
            this.bt_clearAll = new System.Windows.Forms.Button();
            this.bt_sortPriority = new System.Windows.Forms.Button();
            this.bt_sortDate = new System.Windows.Forms.Button();
            this.bt_cancelSort = new System.Windows.Forms.Button();
            this.pn_todayTasks = new System.Windows.Forms.Panel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.оПрограммеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lb_allTasks
            // 
            this.lb_allTasks.AutoSize = true;
            this.lb_allTasks.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lb_allTasks.Location = new System.Drawing.Point(173, 49);
            this.lb_allTasks.Name = "lb_allTasks";
            this.lb_allTasks.Size = new System.Drawing.Size(86, 17);
            this.lb_allTasks.TabIndex = 0;
            this.lb_allTasks.Text = "Мои задачи";
            // 
            // lb_doToday
            // 
            this.lb_doToday.AutoSize = true;
            this.lb_doToday.Location = new System.Drawing.Point(669, 49);
            this.lb_doToday.Name = "lb_doToday";
            this.lb_doToday.Size = new System.Drawing.Size(119, 17);
            this.lb_doToday.TabIndex = 1;
            this.lb_doToday.Text = "Сделать сегодня";
            // 
            // splitter1
            // 
            this.splitter1.Location = new System.Drawing.Point(0, 28);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(3, 535);
            this.splitter1.TabIndex = 2;
            this.splitter1.TabStop = false;
            // 
            // bt_addTask
            // 
            this.bt_addTask.Location = new System.Drawing.Point(41, 416);
            this.bt_addTask.Name = "bt_addTask";
            this.bt_addTask.Size = new System.Drawing.Size(160, 53);
            this.bt_addTask.TabIndex = 3;
            this.bt_addTask.Text = "Добавить задачу";
            this.bt_addTask.UseVisualStyleBackColor = true;
            this.bt_addTask.Click += new System.EventHandler(this.bt_addTask_Click);
            // 
            // pn_allTasks
            // 
            this.pn_allTasks.AutoScroll = true;
            this.pn_allTasks.Location = new System.Drawing.Point(12, 82);
            this.pn_allTasks.Name = "pn_allTasks";
            this.pn_allTasks.Size = new System.Drawing.Size(410, 279);
            this.pn_allTasks.TabIndex = 4;
            // 
            // bt_clearAll
            // 
            this.bt_clearAll.Location = new System.Drawing.Point(240, 416);
            this.bt_clearAll.Name = "bt_clearAll";
            this.bt_clearAll.Size = new System.Drawing.Size(160, 53);
            this.bt_clearAll.TabIndex = 5;
            this.bt_clearAll.Text = "Очистить все";
            this.bt_clearAll.UseVisualStyleBackColor = true;
            this.bt_clearAll.Click += new System.EventHandler(this.bt_clearAll_Click);
            // 
            // bt_sortPriority
            // 
            this.bt_sortPriority.Location = new System.Drawing.Point(154, 496);
            this.bt_sortPriority.Name = "bt_sortPriority";
            this.bt_sortPriority.Size = new System.Drawing.Size(125, 44);
            this.bt_sortPriority.TabIndex = 6;
            this.bt_sortPriority.Text = "Сортировать по приоритету";
            this.bt_sortPriority.UseVisualStyleBackColor = true;
            this.bt_sortPriority.Click += new System.EventHandler(this.bt_sortPriority_Click);
            // 
            // bt_sortDate
            // 
            this.bt_sortDate.Location = new System.Drawing.Point(12, 496);
            this.bt_sortDate.Name = "bt_sortDate";
            this.bt_sortDate.Size = new System.Drawing.Size(125, 44);
            this.bt_sortDate.TabIndex = 7;
            this.bt_sortDate.Text = "Сортировать по дате";
            this.bt_sortDate.UseVisualStyleBackColor = true;
            this.bt_sortDate.Click += new System.EventHandler(this.bt_sortDate_Click);
            // 
            // bt_cancelSort
            // 
            this.bt_cancelSort.Location = new System.Drawing.Point(297, 496);
            this.bt_cancelSort.Name = "bt_cancelSort";
            this.bt_cancelSort.Size = new System.Drawing.Size(125, 44);
            this.bt_cancelSort.TabIndex = 8;
            this.bt_cancelSort.Text = "В порядке добавления";
            this.bt_cancelSort.UseVisualStyleBackColor = true;
            this.bt_cancelSort.Click += new System.EventHandler(this.bt_cancelSort_Click);
            // 
            // pn_todayTasks
            // 
            this.pn_todayTasks.AutoScroll = true;
            this.pn_todayTasks.Location = new System.Drawing.Point(531, 82);
            this.pn_todayTasks.Name = "pn_todayTasks";
            this.pn_todayTasks.Size = new System.Drawing.Size(410, 279);
            this.pn_todayTasks.TabIndex = 5;
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.оПрограммеToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(953, 28);
            this.menuStrip1.TabIndex = 9;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // оПрограммеToolStripMenuItem
            // 
            this.оПрограммеToolStripMenuItem.Name = "оПрограммеToolStripMenuItem";
            this.оПрограммеToolStripMenuItem.Size = new System.Drawing.Size(118, 24);
            this.оПрограммеToolStripMenuItem.Text = "О программе";
            this.оПрограммеToolStripMenuItem.Click += new System.EventHandler(this.оПрограммеToolStripMenuItem_Click_1);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(953, 563);
            this.Controls.Add(this.pn_todayTasks);
            this.Controls.Add(this.bt_cancelSort);
            this.Controls.Add(this.bt_sortDate);
            this.Controls.Add(this.bt_sortPriority);
            this.Controls.Add(this.bt_clearAll);
            this.Controls.Add(this.pn_allTasks);
            this.Controls.Add(this.bt_addTask);
            this.Controls.Add(this.splitter1);
            this.Controls.Add(this.lb_doToday);
            this.Controls.Add(this.lb_allTasks);
            this.Controls.Add(this.menuStrip1);
            this.Name = "MainForm";
            this.Text = "Мой планировщик";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lb_allTasks;
        private System.Windows.Forms.Label lb_doToday;
        private System.Windows.Forms.Splitter splitter1;
        private System.Windows.Forms.Button bt_addTask;
        private System.Windows.Forms.Panel pn_allTasks;
        private System.Windows.Forms.Button bt_clearAll;
        private System.Windows.Forms.Button bt_sortPriority;
        private System.Windows.Forms.Button bt_sortDate;
        private System.Windows.Forms.Button bt_cancelSort;
        private System.Windows.Forms.Panel pn_todayTasks;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem оПрограммеToolStripMenuItem;
    }
}

