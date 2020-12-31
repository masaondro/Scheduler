using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using System.Linq;


namespace Scheduler
{
    public partial class MainForm : Form
    {
        public Dictionary<int, Task> myTasks; //Список задач
        public Dictionary<int, Task> myTodayTasks; //Список задач на сегодня
        public int key = 0; //Ключ для myTasks
        public int currenrKey;
        int xAllTasks;//Координаты для печати всего списка
        int yAllTasks;
        int xTodayTasks;//
        int yTodayTasks;
        public MainForm()
        {
            InitializeComponent();
            myTasks = new Dictionary<int, Task>();
            myTodayTasks = new Dictionary<int, Task>();
            setCoordinates();
            try
            {
                string path = "binaryFile.dat";
                using (BinaryReader reader = new BinaryReader(File.Open(path, FileMode.Open)))
                {
                    // пока не достигнут конец файла
                    // считываем каждое значение из файла
                    while (reader.PeekChar() > -1)
                    {
                        string name = reader.ReadString();
                        string description = reader.ReadString();
                        int priority = reader.ReadInt32();
                        DateTime lastDate = Convert.ToDateTime(reader.ReadString());
                        bool doToday = reader.ReadBoolean();

                        
                        myTasks.Add(key, new Task(name, description, priority, lastDate, doToday));
                        if (doToday)
                        {
                            myTodayTasks.Add(key, new Task(name, description, priority, lastDate, doToday));
                        }
                        key++;
                    }
                }
            }
            catch (Exception exp)
            {

            }
            printAllTasks();
            printTodayTasks();
        }

        private void bt_addTask_Click(object sender, EventArgs e)
        {
            AddTaskForm addNewTask = new AddTaskForm(this);
            addNewTask.Show();
        }
        private void task_Click(object sender, EventArgs e)
        {
            RedTaskForm addNewTask = new RedTaskForm(this);
            addNewTask.Show();
            int taskIndex = Convert.ToInt32(sender.ToString().Split(':')[1]);
            addNewTask.tb_description.Text = sender.ToString();
            Task currentTask;
            myTasks.TryGetValue(taskIndex, out (currentTask));
            addNewTask.tb_name.Text = currentTask.getName();
            addNewTask.tb_description.Text = currentTask.getDescription();
            addNewTask.dtp_date.Value = currentTask.getlastDate();
            addNewTask.cb_today.Checked = currentTask.getDoToday();
            int priority = currentTask.getpriority();
            if (priority == 1) addNewTask.rb_1.Checked = true;
            else if (priority == 2) addNewTask.rb_2.Checked = true;
            else if (priority == 3) addNewTask.rb_3.Checked = true;
            else if (priority == 4) addNewTask.rb_4.Checked = true;
            else if (priority == 5) addNewTask.rb_5.Checked = true;
            currenrKey = taskIndex;
            addNewTask.bt_removToday.Visible = false;
        }

        private void today_task_Click(object sender, EventArgs e)
        {
            RedTaskForm addNewTask = new RedTaskForm(this);
            addNewTask.Show();
            int taskIndex = Convert.ToInt32(sender.ToString().Split(':')[1]);
            addNewTask.tb_description.Text = sender.ToString();
            Task currentTask;
            myTasks.TryGetValue(taskIndex, out (currentTask));
            addNewTask.tb_name.Text = currentTask.getName();
            addNewTask.tb_description.Text = currentTask.getDescription();
            addNewTask.dtp_date.Value = currentTask.getlastDate();
            addNewTask.cb_today.Checked = currentTask.getDoToday();
            int priority = currentTask.getpriority();
            if (priority == 1) addNewTask.rb_1.Checked = true;
            else if (priority == 2) addNewTask.rb_2.Checked = true;
            else if (priority == 3) addNewTask.rb_3.Checked = true;
            else if (priority == 4) addNewTask.rb_4.Checked = true;
            else if (priority == 5) addNewTask.rb_5.Checked = true;
            currenrKey = taskIndex;
            addNewTask.bt_remove.Visible = false;
            addNewTask.bt_update.Visible = false;
        }

        public void printAllTasks()
        {
            setCoordinates();
            pn_allTasks.Controls.Clear();
            foreach (KeyValuePair<int, Task> element in myTasks)
            {
                addTask(element.Value, element.Key);
            }
        }
        public void printTodayTasks()
        {
            setCoordinatesToday();
            pn_todayTasks.Controls.Clear();
            foreach (KeyValuePair<int, Task> element in myTodayTasks)
            {
                addTodayTask(element.Value, element.Key);
            }
        }

        public void addTodayTask(Task newTask, int taskKey)
        {
            Panel panel2 = new Panel();
            Label label1 = new Label();
            panel2.Location = new Point(xTodayTasks, yTodayTasks + 20);
            label1.Location = new Point(0, 0);
            label1.Width = pn_todayTasks.Width;
            label1.Text = newTask.getName();
            //
            panel2.Controls.Add(label1);
            Label label2 = new Label();
            label2.Location = new Point(0, 20);
            label2.Text = taskKey.ToString();
            label2.Width = pn_todayTasks.Width;
            label2.ForeColor = System.Drawing.Color.FromArgb(240, 240, 240);
            panel2.Controls.Add(label2);

            //
            Label label3 = new Label();
            label3.Location = new Point(0, 45);
            label3.Width = pn_todayTasks.Width;
            label3.Text = "Крайняя дата: " + newTask.getlastDate().ToLongDateString();
            panel2.Controls.Add(label3);
            //

            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Height = 65;
            panel2.Width = pn_allTasks.Width - 20;
            switch (newTask.getpriority())
            {
                case 1:
                    panel2.BackColor = System.Drawing.Color.FromArgb(0, 250, 0);
                    label2.ForeColor = System.Drawing.Color.FromArgb(0, 250, 0);
                    break;
                case 2:
                    panel2.BackColor = System.Drawing.Color.FromArgb(174, 242, 16);
                    label2.ForeColor = System.Drawing.Color.FromArgb(174, 242, 16);
                    break;
                case 3:
                    panel2.BackColor = System.Drawing.Color.FromArgb(250, 250, 0);
                    label2.ForeColor = System.Drawing.Color.FromArgb(250, 250, 0);
                    break;
                case 4:
                    panel2.BackColor = System.Drawing.Color.FromArgb(250, 150, 0);
                    label2.ForeColor = System.Drawing.Color.FromArgb(250, 150, 0);
                    break;
                case 5:
                    panel2.BackColor = System.Drawing.Color.FromArgb(250, 0, 0);
                    label2.ForeColor = System.Drawing.Color.FromArgb(250, 0, 0);
                    break;

            }
            pn_todayTasks.Controls.Add(panel2);
            xTodayTasks = panel2.Location.X;
            yTodayTasks = panel2.Location.Y;
            yTodayTasks += panel2.Height - 20;
            label2.Click += today_task_Click;

        }
        public void addTask(Task newTask, int taskKey)
        {
            Panel panel2 = new Panel();
            Label label1 = new Label();
            panel2.Location = new Point(xAllTasks, yAllTasks + 20);
            label1.Location = new Point(0, 0);
            label1.Width = pn_allTasks.Width;
            label1.Text = newTask.getName();
            //
            panel2.Controls.Add(label1);
            Label label2 = new Label();
            label2.Location = new Point(0, 20);
            label2.Text = taskKey.ToString();
            label2.Width = pn_allTasks.Width;
            label2.ForeColor = System.Drawing.Color.FromArgb(240, 240, 240);
            panel2.Controls.Add(label2);

            //
            Label label3 = new Label();
            label3.Location = new Point(0, 45);
            label3.Width = pn_allTasks.Width;
            label3.Text = "Крайняя дата: " + newTask.getlastDate().ToLongDateString();
            panel2.Controls.Add(label3);
            //

            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Height = 65;
            panel2.Width = pn_allTasks.Width - 20;
            switch (newTask.getpriority())
            {
                case 1:
                    panel2.BackColor = System.Drawing.Color.FromArgb(0, 250, 0);
                    label2.ForeColor = System.Drawing.Color.FromArgb(0, 250, 0);
                    break;
                case 2:
                    panel2.BackColor = System.Drawing.Color.FromArgb(174, 242, 16);
                    label2.ForeColor = System.Drawing.Color.FromArgb(174, 242, 16);
                    break;
                case 3:
                    panel2.BackColor = System.Drawing.Color.FromArgb(250, 250, 0);
                    label2.ForeColor = System.Drawing.Color.FromArgb(250, 250, 0);
                    break;
                case 4:
                    panel2.BackColor = System.Drawing.Color.FromArgb(250, 150, 0);
                    label2.ForeColor = System.Drawing.Color.FromArgb(250, 150, 0);
                    break;
                case 5:
                    panel2.BackColor = System.Drawing.Color.FromArgb(250, 0, 0);
                    label2.ForeColor = System.Drawing.Color.FromArgb(250, 0, 0);
                    break;

            }
            pn_allTasks.Controls.Add(panel2);
            xAllTasks = panel2.Location.X;
            yAllTasks = panel2.Location.Y;
            yAllTasks += panel2.Height - 20;
            label2.Click += task_Click;
        }

        public void setCoordinates()
        {
            xAllTasks = 0;
            yAllTasks = 0;
        }

        public void setCoordinatesToday()
        {
            xTodayTasks = 0;
            yTodayTasks = 0;
        }
        public void updateTask(int taskIndex, Task newTask)
        {
            myTasks[taskIndex] = newTask;
            printAllTasks();
        }

        private void bt_clearAll_Click(object sender, EventArgs e)
        {
            myTasks.Clear();
            myTodayTasks.Clear();
            printTodayTasks();
            printAllTasks();
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                string path = "binaryFile.dat";
                // создаем объект BinaryWriter
                using (BinaryWriter writer = new BinaryWriter(File.Open(path, FileMode.Create)))
                {
                    
                    // записываем в файл значение каждого поля структуры
                    foreach (KeyValuePair<int, Task> element in myTasks)
                    {
                        writer.Write(element.Value.getName());
                        writer.Write(element.Value.getDescription());
                        writer.Write(element.Value.getpriority());
                        writer.Write(element.Value.getlastDate().ToString());
                        writer.Write(element.Value.getDoToday());
                    }
                }
            }
            catch (Exception exp)
            {
                MessageBox.Show("Упс, что то пошло не так");
            }
        }


        public class Task
        {
            private string name; //имя задания
            private string description;//описание задания
            private int priority; //приоритет
            private DateTime lastDate; //Дедлайн
            private bool doToday; //сделать сегодня


            public Task(string _name, string _description, int _priority, DateTime _lastDate, bool _doToday)
            {
                name = _name;
                description = _description;
                priority = _priority;
                lastDate = _lastDate;
                doToday = _doToday;
            }
            public void setName(string _name)
            {
                name = _name;
            }
            public void setDescription(string _description)
            {
                description = _description;
            }

            public void setpriority(int _priority)
            {
                priority = _priority;
            }
            public void setlastDate(DateTime _lastDate)
            {
                lastDate = _lastDate;
            }

            public void setDoToday(bool _doToday)
            {
                doToday = _doToday;
            }

            public string getName()
            {
                return name;
            }
            public string getDescription()
            {
                return description;
            }

            public int getpriority()
            {
                return priority;
            }
            public DateTime getlastDate()
            {
                return lastDate;
            }

            public bool getDoToday()
            {
                return doToday;
            }

        }

        private void bt_sortDate_Click(object sender, EventArgs e)
        {
            myTasks = myTasks.OrderBy(pair => pair.Value.getlastDate()).ToDictionary(pair => pair.Key, pair => pair.Value);
            printAllTasks();
        }

        private void bt_sortPriority_Click(object sender, EventArgs e)
        {
            myTasks = myTasks.OrderBy(pair => pair.Value.getpriority()).ToDictionary(pair => pair.Key, pair => pair.Value);
            printAllTasks();
        }

        private void bt_cancelSort_Click(object sender, EventArgs e)
        {
            myTasks = myTasks.OrderBy(pair => pair.Key).ToDictionary(pair => pair.Key, pair => pair.Value);
            printAllTasks();
        }


        private void оПрограммеToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            MessageBox.Show("   Это приложение, которое помогает планировать свои дела. \n\n   " +
                            "Есть две секции: общий список дел и дела, которые вы хотите сделать сегодня.\n\n    " +
                            "Для того, чтобы добавить дело в список дел на сегодня необхолимо пиставить галочку в поле Сделать сегодня\n\n    " +
                            "Делу можно назначить приоритет. Это позволяет вам видеть самые важные дела\n\n    " +
                            "Дела можно упорядочить по дате их завершения и по их приоритету, а также показывать их в том порядке, в котором они были добавлены\n\n    " +
                            "Для того, чтобы удалить или отредактировать задачу необхолимо по ней нажать. \n\n    " +
                            "Есть возможность удалить сразу все задачи. \n\n   " +
                            "После завершения работы данные сохраняются и при следующем запуске будут вновь доступны", "О программе");
        }
    }
}
