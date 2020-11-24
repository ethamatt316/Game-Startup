using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace Game_Startup
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
    
        private void Button2_Click_1(object sender, EventArgs e)
        {
            button2.BackColor = Color.Green;
            Refresh();Thread.Sleep(200);
            button2.BackColor = Color.White;
        }
    }
}
