using System;
using System.Collections.Generic;
using System.Collections;
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

    public partial class EndGame : Form
    {
        public Form1 parent;
        public int Score { get; set; }
        public DataGridView dataGrid;
        public int scoreCount;

        public EndGame()
        {
            InitializeComponent();
            this.Shown += EndGame_Shown;
            textBox1.TextChanged += TextBox1_TextChanged;
            button1.Click += Button1_Click;
        }

        public class MyComparer : IComparer
        {
            int IComparer.Compare(object x, object y)
            {
                DataGridViewRow first = (DataGridViewRow)x;
                DataGridViewRow second = (DataGridViewRow)y;
                int f = Int32.Parse((string)first.Cells[1].Value);
                int s = Int32.Parse((string)second.Cells[1].Value);
                // Comparer<int> comp = new Com
                if (f > s)
                    return -1;
                if (f == s)
                    return 0;
                return 1;
            }
        }
        private void Button1_Click(object sender, EventArgs e)
        {
            DataTable table = new DataTable();
            string[] data = new string[2];
            data[0] = textBox1.Text;
            data[1] = Score.ToString();
            scoreCount++;
            dataGrid.Rows.Add(data);
            MyComparer comp = new MyComparer();
            dataGrid.Sort(comp);
            this.Close();
        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {

            for (int i = 0; i < textBox1.Text.Length; i++)
            {
                if (Char.IsWhiteSpace(textBox1.Text, i) || textBox1.Text[i] == ';')
                {
                    button1.Enabled = false;
                    return;
                }
            }
            if (textBox1.Text.Length != 0)
                button1.Enabled = true;

            else
                button1.Enabled = false;
        }

        private void EndGame_Shown(object sender, EventArgs e)
        {
            label2.Text = Score.ToString();
        }
    }
}
