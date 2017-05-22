using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace hamsterAAA
{
    public partial class Form2 : Form
    {
        public Form1 parent;
        public Form2()
        {
            InitializeComponent();
            OKbutton.Click += OKbutton_Click;
            cancelButton.Click += CancelButton_Click;
            this.Shown += Form2_Shown;
            
            
        }

        private void Form2_Shown(object sender, EventArgs e)
        {
            string txt = parent.tableSize + " x " + parent.tableSize;
            sizeBox.Text = txt;
            activeUpDown.Value = parent.activeCount;
            clicksUpDown.Value = parent.clicksToEnd;
           // this.ShowDialog();
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {

            this.Close();
        }

        private void OKbutton_Click(object sender, EventArgs e)
        {
            //Form1 parent = (Form1)this.Parent;
            parent.clicksToEnd = (int)clicksUpDown.Value;
            parent.activeCount = (int)activeUpDown.Value;
            parent.changed = true;
            parent.score = 0;
            parent.scoreLabel.Text = "Score: " + parent.score.ToString();
            string selected = (string)sizeBox.SelectedItem;
            switch (selected)
            {
                case "4 x 4":
                    parent.tableSize = 4;
                    break;
                case "6 x 6":
                    parent.tableSize = 6;
                    break;
                case "8 x 8":
                    parent.tableSize = 8;
                    break;
                default:
                    break;
            }
            this.Close();
        }
        
    }
}
