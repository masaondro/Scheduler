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
    public partial class RedTaskForm : Form
    {
        MainForm mf = null;
        public RedTaskForm(MainForm _mf)
        {
            mf = _mf;
            InitializeComponent();
        }

 

        private void bt_update_Click(object sender, EventArgs e)
        {
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
            mf.updateTask(mf.currenrKey, newTask);
            if (doToday)
            {
                mf.myTodayTasks.Add(mf.currenrKey, newTask);
                mf.printTodayTasks();
            }
            if (!doToday)
            {
                mf.myTodayTasks.Remove(mf.currenrKey);
                mf.printTodayTasks();
            }
            this.Close();
        }

        private void bt_remove_Click(object sender, EventArgs e)
        {
            if (mf.myTasks[mf.currenrKey].getDoToday())
            {
                mf.myTodayTasks.Remove(mf.currenrKey);
            }
            mf.myTasks.Remove(mf.currenrKey);
            mf.printAllTasks();
            mf.printTodayTasks();
            this.Close();
        }

        private void bt_removToday_Click(object sender, EventArgs e)
        {
            mf.myTodayTasks.Remove(mf.currenrKey);
            mf.myTasks[mf.currenrKey].setDoToday(false);
            mf.printTodayTasks();
            this.Close();
        }
    }
}
