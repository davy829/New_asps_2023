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
    public partial class Form3 : Form
    {
           public Form3()
        {
            InitializeComponent();
        }

        private void buttonWinner_Click(object sender, EventArgs e)
        {

            if (Form1.SelfRef != null)
            {
            if (radioButtonRedWin.Checked)
                {
                    Form1.SelfRef.show_panel_win(Form2.SelfRef2.label_red_name.Text);
                    Form1.SelfRef.AddToFileWinner(Form2.SelfRef2.label_red_name.Text, "");
                    Form1.SelfRef.AddToFileProtokol(Form2.SelfRef2.label_red_name.Text + "red winner","");
                }
                if (radioButtonBlueWin.Checked)
                {
                    Form1.SelfRef.show_panel_win(Form2.SelfRef2.label_blue_name.Text);
                    Form1.SelfRef.AddToFileWinner("", Form2.SelfRef2.label_blue_name.Text);
                    Form1.SelfRef.AddToFileProtokol("", Form2.SelfRef2.label_blue_name.Text + "blue winner");
                }
            }
            Form1.SelfRef.timer1.Enabled = false;
            this.Visible = false;
        }
    }
}
