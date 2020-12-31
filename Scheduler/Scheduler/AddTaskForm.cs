using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Scheduler
{
    public partial class AddTaskForm : Form
    {
        MainForm mf = null;
        public AddTaskForm(MainForm _mf)
        {
            mf = _mf;
            InitializeComponent();
            dtp_date.MinDate = DateTime.Today;
        }

        private void bt_add_Click(object sender, EventArgs e)
        {
            if(tb_name.Text == "")
            {
                MessageBox.Show("Пожалуйста, введите название задачи");
                return;
            }
            string name = tb_name.Text;
            string description = tb_description.Text;
            DateTime lastDate = dtp_date.Value;
            bool doToday = cb_today.Checked;
            int priority = 0;
            if (rb_1.Checked) priority = 1;
            else if (rb_2.Checked) priority = 2;
            else if (rb_3.Checked) priority = 3;
            else if (rb_4.Checked) priority = 4;
            else if (rb_5.Checked) priority = 5;
            Scheduler.MainForm.Task newTask = new Scheduler.MainForm.Task(name, description, priority, lastDate, doToday);
            mf.myTasks.Add(mf.key, newTask);
            mf.printAllTasks();
            if(doToday)
            {
                mf.myTodayTasks.Add(mf.key, newTask);
                mf.printTodayTasks();
            }
            mf.key++;
            this.Close();
        }
    }
}
