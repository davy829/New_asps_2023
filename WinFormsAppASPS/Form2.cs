using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsAppASPS
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            panel1.Width = this.Width;
            panel2.Width = this.Width;
            panel1.Height = this.Height / 2;
            panel2.Height = this.Height / 2;
            panel1.Top = 0;
            panel2.Top = panel1.Height + 1;
            panel_timer.Left = this.Width / 2 - panel_timer.Width / 2;
            panel_timer.Top = this.Height / 2 - panel_timer.Height / 2;
            label_red_score.Top = panel1.Height / 2 - label_red_score.Height / 2;
            label_blue_score.Top = panel2.Height / 2 - label_blue_score.Height / 2;
            label_red_name.Top = panel1.Height / 2 - label_red_name.Height / 2;
            label_blue_name.Top = panel2.Height / 2 - label_blue_name.Height / 2;
            label_weight.Left = this.Width - label_weight.Width - 50;

        }
    }
}
