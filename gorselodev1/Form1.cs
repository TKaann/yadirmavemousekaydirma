using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace gorselodev1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            buttoncursor.Cursor = Cursors.Hand;

        }

        private void button1_Click(object sender, EventArgs e)
        {

            Point konum = new Point();

            konum.X = 350;
            konum.Y = 175;

            Button btn = new Button();

            btn.Location = konum;
            btn.BackColor = Color.Red;
            btn.Height = 50;

            this.Controls.Add(btn);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            label1.Font = new Font("Snap ITC" , 25 , FontStyle.Bold);
            label1.ForeColor = Color.Red;
        }
    }
}
