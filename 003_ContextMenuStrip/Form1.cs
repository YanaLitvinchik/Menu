using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using frm= System.Windows.Forms;

namespace _003_ContextMenuStrip
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            //create button
            var b = new Button();
            b.Text = "Dynamic \n\rbutton";
            b.Size = buttonDesigner.Size;
            b.Location = buttonDesigner.Location;
            b.Left += (int)(b.Width * 1.25);
            this.Controls.Add(b);

            //create context menu
            frm.ContextMenuStrip menu = new frm.ContextMenuStrip();
            var tmp = new ToolStripMenuItem("First");
            tmp.Click += delegate (Object sender, EventArgs e) {
                dynamic ob1 = sender;
                MessageBox.Show(ob1.Text);
            };
            menu.Items.Add( tmp);

            //Associate button with context menu
            b.ContextMenuStrip = menu;
        }

        private void туцToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dynamic ob1 = sender;

            MessageBox.Show(ob1.Text);
        }

        private void туцтуцToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dynamic ob1 = sender;

            MessageBox.Show(ob1.Text);
        }
    }
}
