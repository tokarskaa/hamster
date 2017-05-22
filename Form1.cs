using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace hamsterAAA
{
    public partial class Form1 : Form
    {
        private Timer timer;
        private List<Button> buttonList;
        private Random rand;
        private List<int> activeIndexes;
        private bool paused;
        private int clicks;
        public int clicksToEnd;
        public int tableSize;
        public int activeCount;
        public int score;
        public int lastScore;
        public bool changed;
        public int scoreCount;

        public Form1()
        {
            InitializeComponent();
            splitContainer1.SplitterWidth = 10;
            splitContainer1.BackColor = Color.Green;
            splitContainer1.Panel1.BackColor = Color.White;
            splitContainer1.Panel2.BackColor = Color.White;
            splitContainer1.Panel1MinSize = 100;
            splitContainer1.FixedPanel = FixedPanel.Panel1;
            splitContainer1.BorderStyle = BorderStyle.Fixed3D;

            score = 0;
            clicks = 0;
            activeCount = 5;
            clicksToEnd = 20;
            tableSize = 4;
            paused = true;
            scoreCount = 0;
            activeIndexes = new List<int>();
            rand = new Random();
            setTableLayout(tableLayoutPanel1, tableSize);
            timer = new Timer();
            timer.Interval = 1010 - trackBar1.Value;

            trackBar1.ValueChanged += TrackBar1_ValueChanged;
            timer.Tick += Timer_Tick;
            startBtn.Click += StartBtn_Click;
            settingsBtn.Click += settingsBtn_Click;
            this.FormClosing += Form1_FormClosing;
            fillData();
            dataGridView1.Click += DataGridView1_Click;
            ContextMenu cm = new ContextMenu();
            dataGridView1.ContextMenu = new ContextMenu();
            dataGridView1.ContextMenuStrip = new ContextMenuStrip();
           // dataGridView1.ContextMenuStrip.
            dataGridView1.ContextMenu.MenuItems.Add("Clear");
            dataGridView1.ContextMenu.MenuItems[0].Click += Form1_Click;
           // dataGridView1.DataSource = Helper.DataTableFromTextFile("data.txt", ';');
           //dataGridView1.so
        }

        private void Form1_Click(object sender, EventArgs e)
        {
            string path = Environment.CommandLine + @"\data.txt";
            if (File.Exists(path))
             File.Delete(path);
            dataGridView1.Rows.Clear();
            scoreCount = 0;
        }

        private void DataGridView1_Click(object sender, EventArgs e)
        {
            MouseEventArgs ms = (MouseEventArgs)e;
            if (ms.Button == MouseButtons.Left)
            {
               // DataGridView btnSender = (DataGridView)sender;
                //Point ptLowerLeft = new Point(0, btnSender.Height /2);
                //ptLowerLeft = btnSender.PointToScreen(ptLowerLeft);
                dataGridView1.ContextMenu.Show(dataGridView1, new Point(MousePosition.X-450, MousePosition.Y -300));
            }
        }

        private void fillData()
        {
            string myPath = Environment.CurrentDirectory;
            if (File.Exists(myPath + @"\data.txt"))
            {
                StreamReader sr = new StreamReader(myPath + @"\data.txt");
                string line;
                while ((line = sr.ReadLine()) != null)
                {
                    string[] data = line.Split(';');
                    dataGridView1.Rows.Add(data);                
                }
                sr.Close();
            }
        }
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            string docPath = Environment.CurrentDirectory;
            StreamWriter sw = new StreamWriter(docPath + @"\data.txt");
            int count = dataGridView1.RowCount;
            for (int i = 0; i < count; i++)
            {
                string s = dataGridView1.Rows[i].Cells[0].Value + ";" + dataGridView1.Rows[i].Cells[1].Value;
                sw.Write(s);
                sw.WriteLine();
            }
            sw.Close();
        }

        private void StartBtn_Click(object sender, EventArgs e)
        {
            if (paused)
            {
                startBtn.Text = "Pause";
                if (activeIndexes.Count == 0)
                    initializeActive();
                timer.Start();
                paused = false;
            }
            else
            {
                startBtn.Text = "Start";
                timer.Stop();
                paused = true;
            }
        }

        private int randomNonActive()
        {
            int ind = rand.Next(buttonList.Count);
            while (activeIndexes.Contains(ind))
                ind = rand.Next(buttonList.Count);
            return ind;
        }

        void initializeActive()
        {
            for (int i = 0; i < activeCount; i++)
            {
                int ind = randomNonActive();
                buttonList[ind].BackColor = Color.Blue;
                activeIndexes.Add(ind);
            }
        }

        
        private void Timer_Tick(object sender, EventArgs e)
        {
            if (activeIndexes.Count == 0)
                initializeActive();
            buttonList[activeIndexes[0]].BackColor = SystemColors.Control;
            activeIndexes.RemoveAt(0);
            int ind = randomNonActive();
            buttonList[ind].BackColor = Color.Blue;
            activeIndexes.Add(ind);
            while (activeIndexes.Count < activeCount)
            {
                ind = randomNonActive();
                buttonList[ind].BackColor = Color.Blue;
                activeIndexes.Add(ind);
            }
        }

        private void TrackBar1_ValueChanged(object sender, EventArgs e)
        {
            timer.Stop();
            timer.Interval = 1010 - trackBar1.Value;
            timer.Start();          
        }

        private void setTableLayout(TableLayoutPanel panel, int size)
        {
            buttonList = new List<Button>();
            panel.ColumnCount = size;
            panel.RowCount = size;
            panel.ColumnStyles.Clear();
            panel.RowStyles.Clear();
            for (int i = 0; i < size; i++)
            {
                panel.RowStyles.Add(new RowStyle(SizeType.Percent, 100 / size));
                panel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100 / size));
            }
            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    Button btn = new Button();
                    buttonList.Add(btn);
                    btn.Click += Btn_Click;
                    btn.BackColor = SystemColors.Control;
                    btn.Dock = DockStyle.Fill;
                    panel.Controls.Add(btn, i, j);
                }
            }
        }

        private void Btn_Click(object sender, EventArgs e)
        {
            if (!paused)
            {
                Button button = (Button)sender;
                int ind = buttonList.FindIndex(b1 => button == b1);
                if (activeIndexes.Contains(ind))
                {
                    activeIndexes.Remove(ind);
                    buttonList[ind].BackColor = SystemColors.Control;
                    score += 50;
                    scoreLabel.Text = "Score: " + score;
                    scoreLabel.BackColor = SystemColors.Control;
                }
                else
                {
                    score -= 100;
                    scoreLabel.Text = "Score: " + score;
                    scoreLabel.BackColor = Color.Red;
                }
                ++clicks;
                if (clicks >= clicksToEnd)
                {
                    FinishGame();
                    score = 0;
                    scoreLabel.Text = "Score: " + score;
                }
            }
            
        }

        private void FinishGame()
        {
            EndGame endWindow = new hamsterAAA.EndGame();
            endWindow.Score = score;
            endWindow.dataGrid = dataGridView1;
            endWindow.scoreCount = scoreCount;
            //endWindow.parent = this;
            endWindow.ShowDialog();
            clicks = 0;
           // score = 0;
            startBtn.Text = "Start";
            timer.Stop();
            paused = true;
            for (int i = 0; i < activeIndexes.Count; i++)
                buttonList[activeIndexes[i]].BackColor = SystemColors.Control;
            activeIndexes.Clear();

        }

        private void settingsBtn_Click(object sender, EventArgs e)
        {
            Form2 settingsWindow = new Form2();
            settingsWindow.parent = this;
            settingsWindow.FormClosed += SettingsWindow_FormClosed;
            settingsWindow.ShowDialog();
        }

        private void SettingsWindow_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (changed)
            {
                timer.Stop();
                tableLayoutPanel1.Controls.Clear();
                setTableLayout(tableLayoutPanel1, tableSize);
                activeIndexes.Clear();
                timer.Start();
                changed = false;
                startBtn.Text = "Start";
                timer.Stop();
                paused = true;
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
