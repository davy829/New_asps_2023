namespace WinFormsAppASPS
{
    public partial class Form1 : Form
    {
        Form2 fr2 = new Form2();
        String fullPath = Application.StartupPath.ToString();
        bool dis_red = false;
        bool dis_blue = false;
        public Form1()
        {
            InitializeComponent();
        }
        private void showForm2()
        {
            Screen[] sc;
            sc = Screen.AllScreens;
            if (sc.Length > 1)
            {
                fr2.FormBorderStyle = FormBorderStyle.Sizable;
                fr2.Left = sc[1].Bounds.Width;
                fr2.Top = sc[1].Bounds.Height;
                fr2.StartPosition = FormStartPosition.Manual;
                fr2.Location = sc[1].Bounds.Location;
                Point p = new Point(sc[1].Bounds.Location.X, sc[1].Bounds.Location.Y);
                fr2.Location = p;
                fr2.WindowState = FormWindowState.Maximized;
                fr2.Show();
            }
            else
            {
                MessageBox.Show("Не подсоеденен второй монитор !!!", "Пиздец", MessageBoxButtons.OK);

            }
        }

        public void add_bals(int red_add, int blue_add)
        {
            int bals_red = int.Parse(fr2.label_red_score.Text) + red_add;
            fr2.label_red_score.Text = bals_red.ToString();
            int bals_blue = int.Parse(fr2.label_blue_score.Text) + blue_add;
            fr2.label_blue_score.Text = bals_blue.ToString();

            //Add_to_file();
        }
        private void button_add_sportsmen_Click(object sender, EventArgs e)
        {
            fr2.label_red_name.Text = listBox_red_names.Text;
            fr2.label_blue_name.Text = listBox_blue_names.Text;
            showForm2();
        }

        private void button_add_files_Click(object sender, EventArgs e)
        {
            string[] files = new DirectoryInfo(fullPath).GetFiles("*.txt", SearchOption.AllDirectories)
            .Select(f => f.Name).ToArray();
            this.listBox_files_weit.Items.AddRange(files);
        }

        private void listBox_files_weit_Click(object sender, EventArgs e)
        {
            listBox_red_names.Items.Clear();
            listBox_blue_names.Items.Clear();
            string fNamne = listBox_files_weit.Text;
            if (fNamne != " ")
            {
                System.IO.StreamReader sr_red = new System.IO.StreamReader(fNamne);

                while (!sr_red.EndOfStream)
                {
                    listBox_red_names.Items.Add(sr_red.ReadLine());
                }
                sr_red.Close();
                System.IO.StreamReader sr_blue = new System.IO.StreamReader(fNamne);
                while (!sr_blue.EndOfStream)
                {
                    listBox_blue_names.Items.Add(sr_blue.ReadLine());
                }
                sr_blue.Close();
                string weit = listBox_files_weit.Text;
                fr2.label_weight.Text = "Вес " + weit.Substring((weit.Length - 6), 2) + "кг";
                MessageBox.Show(weit.Substring(4, weit.Length - 4), "Веро", MessageBoxButtons.OK);

            }
        }

        private void button_start_timer_Click(object sender, EventArgs e)
        {
            fr2.timer1.Enabled = true;
        }

        private void button_timer_pause_Click(object sender, EventArgs e)
        {
            fr2.timer1.Enabled = false;
        }

        private void button_one_bal_red_Click(object sender, EventArgs e)
        {
            add_bals(1, 0);
        }

        private void button_two_bal_red_Click(object sender, EventArgs e)
        {
            add_bals(2, 0);
        }

        private void button_three_bal_red_Click(object sender, EventArgs e)
        {
            add_bals(3, 0);
        }

        private void button_four_bal_red_Click(object sender, EventArgs e)
        {
            add_bals(4, 0);
        }

        private void button_one_bal_red_min_Click(object sender, EventArgs e)
        {
            add_bals(-1, 0);
        }

        private void button_two_bal_red_min_Click(object sender, EventArgs e)
        {
            add_bals(-2, 0);
        }

        private void button_othree_bal_red_min_Click(object sender, EventArgs e)
        {
            add_bals(-3, 0);
        }

        private void button_four_bal_red_min_Click(object sender, EventArgs e)
        {
            add_bals(-4, 0);
        }

        private void button_one_bal_blue_Click(object sender, EventArgs e)
        {
            add_bals(0, 1);
        }

        private void button_two_bal_blue_Click(object sender, EventArgs e)
        {
            add_bals(0, 2);
        }

        private void button_three_bal_blue_Click(object sender, EventArgs e)
        {
            add_bals(0, 3);
        }

        private void button_four_bal_blue_Click(object sender, EventArgs e)
        {
            add_bals(0, 4);
        }

        private void button_one_bal_blue_min_Click(object sender, EventArgs e)
        {
            add_bals(0, -1);
        }

        private void button_two_bal_blue_min_Click(object sender, EventArgs e)
        {
            add_bals(0, -2);
        }

        private void button_three_bal_blue_min_Click(object sender, EventArgs e)
        {
            add_bals(0, -3);
        }

        private void button_four_bal_blue_min_Click(object sender, EventArgs e)
        {
            add_bals(0, -4);
        }

        private void button_red_d1_Click(object sender, EventArgs e)
        {
            if (dis_red)
            {
                fr2.panel4.Visible = false;
                dis_red = false;
            }
            else
            {
                fr2.panel4.Visible = true;
                dis_red = true;
                button_red_d2.Enabled = true;
            }


        }

        private void button_red_d2_Click(object sender, EventArgs e)
        {
            if (dis_red)
            {
                fr2.panel5.Visible = false;
                dis_red = false;
            }
            else
            {
                fr2.panel5.Visible = true;
                dis_red = true;
                button_red_d3.Enabled = true;
            }
        }

        private void button_red_d3_Click(object sender, EventArgs e)
        {
            if (dis_red)
            {
                fr2.panel6.Visible = false;
                dis_red = false;
            }
            else
            {
                fr2.panel6.Visible = true;
                dis_red = true;
            }
        }
    }
}