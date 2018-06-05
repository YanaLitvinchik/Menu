using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GameButton
{
    public partial class Form1 : Form
    {
        public int X { get; set; }
        public int Y { get; set; }
        public Form1()
        {
            InitializeComponent();
            X = 10;
            Y = 10;
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            HelloButton.Location = new Point(
                HelloButton.Location.X + X,
                HelloButton.Location.Y 
                );
            if (HelloButton.Location.X >= this.ClientSize.Width - 50)
                X = -X;
            if (HelloButton.Location.X <= 0)
                X = Math.Abs(X);
        }
        private void HelloButton_Click(object sender, EventArgs e)
        {
            if (timer1.Enabled == false)
                timer1.Enabled = true;
            else
                timer1.Enabled = false;
        }
        #region     

        private void button1_MouseMove(object sender, MouseEventArgs e)
        {
            
        }

        private void startToolStripMenuItem_Click(object sender, EventArgs e)
        {
            HelloButton_Click(sender, e);
        }
        #endregion
        #region 
        private void SpeedTwo_Click(object sender, EventArgs e)
        {
            Un();
            SpeedTwo.Checked = true;
            X = 30;
            Y = 30;
        }
        private void SpeedThree_Click(object sender, EventArgs e)
        {

            Un();
            SpeedThree.Checked = true;
            X = 40;
            Y = 40;
        }
        private void SpeedOne_Click(object sender, EventArgs e)
        {
            Un();
            SpeedOne.Checked = true;
            X = 20;
            Y = 20;
        }
        #endregion

        private void stopToolStripMenuItem_Click(object sender, EventArgs e)
        {
            timer1.Enabled = false;
        }
        private void Un()
        {
            SpeedOne.Checked = SpeedTwo.Checked = SpeedThree.Checked = false;
        }
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void Pluh()
        {
            HelloButton.Size = new Size(10, 10);
        }
    }
}
