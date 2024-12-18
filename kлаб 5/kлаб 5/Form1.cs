using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace kлаб_5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Location.X < Width / 2)
            {
                Button b = new Button();
                b.Parent = this;
                b.Location = new Point(e.Location.X, e.Location.Y);
                b.Size = new Size(100, 30);
                b.Text = Convert.ToString(e.X) + ' ' + Convert.ToString(e.Y);
            }
            else
            {
                TextBox t = new TextBox();
                t.Parent = this;
                t.Location = new Point(e.Location.X, e.Y);
                t.Size = new Size(200, 50);
            }
        }
    }
}
