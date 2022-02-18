using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace my_app
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttondashboard_Click(object sender, EventArgs e)
        {
            panelleft.Height = buttondashboard.Height;
            panelleft.Top = buttondashboard.Top;
        }

        private void buttonSeller_Click(object sender, EventArgs e)
        {
            panelleft.Height = buttonSeller.Height;
            panelleft.Top = buttonSeller.Top;
        }

        private void buttonCalender_Click(object sender, EventArgs e)
        {
            panelleft.Height = buttonCalender.Height;
            panelleft.Top = buttonCalender.Top;
        }

        private void buttonTasks_Click(object sender, EventArgs e)
        {
            panelleft.Height = buttonTasks.Height;
            panelleft.Top = buttonTasks.Top;
        }
    }
}
