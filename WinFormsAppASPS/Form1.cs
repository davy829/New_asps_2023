using System.Windows.Forms;

namespace WinFormsAppASPS
{
    public partial class Form1 : Form
    {
        Form2 fr2 = new Form2();
        Form3 fr3 = new Form3();
        String fullPath = Application.StartupPath.ToString();
        bool dis_red = false; // дисквалификация крас
        bool dis_blue = false; // дисквалификация синему
        bool vpause = false; // надпись на кнопке старт / стоп
                             // bool advantecRed = false; // адвантеч красному подщет
                             //  bool advantecBlue = false; // адвантеч синему подщет
        int advRed = 0;
        int advBlue = 0;
        int min_1 = 4;
        int sec_1 = 60;
        int secInContest = 0;  //секунд в поединке
        string weightFromFile = string.Empty; // вес из имени файла


        public static Form1 SelfRef { get; set; } // ссылка для управления из формы 3

        public Form1()
        {
            SelfRef = this;   // инициализация ссылки для управления 
            InitializeComponent();
        }


        public void AddToFileProtokol(string a_1 = "", string a_2 = "")
        {
            string path = fullPath + "protokol/protokol_" + weightFromFile + ".log";
            string timeSport = fr2.label_timer_min.Text + ":" + fr2.label_timer_sec.Text;
            string redSport = timeSport + " " + fr2.label_red_name.Text + " red score_: " + fr2.label_red_score.Text + " (" + a_1 + ")" + "\n";
            string blueSport = timeSport + " " + fr2.label_blue_name.Text + " blue score_: " + fr2.label_blue_score.Text + " (" + a_2 + ")" + "\n";
            string createText = redSport + blueSport;
            File.AppendAllText(path, createText);
        }
        public void AddToFileWinner(string w_1 = "", string w_2 = "")
        {
            string path = fullPath + "winner/winner_" + weightFromFile + ".log";
            string winSport = w_1 + w_2 + "\n";
            File.AppendAllText(path, winSport);
        }

        //public void endOffContest(string winnerWho)
        //{
        //    timer1.Enabled = false;
        //    string path = fullPath + "/winners.txt";
        //    File.AppendAllText(path, winnerWho + "\n");
        //}

        public void ResetTimer()
        {
            timer1.Enabled = false;
            fr2.label_timer_min.Text = textBox1.Text;
            fr2.label_timer_sec.Text = textBox2.Text;
            // min_1 = int.Parse(textBox1.Text);
            // sec_1 = int.Parse(textBox2.Text);
            secInContest = int.Parse(textBox1.Text) * 60 + int.Parse(textBox2.Text);
        }
        public void showForm2()
        {
            //Screen[] sc;
            //sc = Screen.AllScreens;
            //if (sc.Length > 1)
            //{
            //    fr2.FormBorderStyle = FormBorderStyle.Sizable;
            //    fr2.Left = sc[1].Bounds.Width;
            //    fr2.Top = sc[1].Bounds.Height;
            //    fr2.StartPosition = FormStartPosition.Manual;
            //    fr2.Location = sc[1].Bounds.Location;
            //    Point p = new Point(sc[1].Bounds.Location.X, sc[1].Bounds.Location.Y);
            //    fr2.Location = p;
            //    fr2.WindowState = FormWindowState.Maximized;
            fr2.Show();
            //}
            //else
            //{
            //    MessageBox.Show("Не подсоеденен второй монитор !!!", "Пиздец", MessageBoxButtons.OK);

            //}
        }
        public void show_panel_win(string winner = "Deniska")
        {

            fr2.label_winner.Text = winner;
            fr2.panel_winner.Visible = true;
            fr2.timer2.Enabled = true;
        }
        public void AddBals(int red_add, int blue_add)
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
            int r = listBox_red_names.SelectedIndex;
            int b = listBox_blue_names.SelectedIndex;
            listBox_red_names.Items[r] = "redy_" + b.ToString() + " " + listBox_red_names.Items[r];
            listBox_blue_names.Items[b] = "redy_" + b.ToString() + " " + listBox_blue_names.Items[b];
            listBox_red_names.Items[b] = "redy_" + r.ToString() + " " + listBox_red_names.Items[b];
            listBox_blue_names.Items[r] = "redy_" + r.ToString() + " " + listBox_blue_names.Items[r];
            //listBox_red_names.Items.RemoveAt(r);
            // listBox_blue_names.Items.RemoveAt(b);
            showForm2();
            ResetTimer();


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

                weightFromFile = listBox_files_weit.Text.Substring((listBox_files_weit.Text.Length - 6), 2);
                fr2.label_weight.Text = "Вес " + weightFromFile + "кг";
                // MessageBox.Show(weit.Substring(4, weit.Length - 4), "Веро", MessageBoxButtons.OK);

            }
        }

        private void button_start_timer_Click(object sender, EventArgs e)
        {

            if (vpause == false)
            {
                this.timer1.Enabled = true;
                button_start_timer.Text = "ПАУЗА";
                vpause = true;
            }
            else
            {

                this.timer1.Enabled = false;
                button_start_timer.Text = "СТАРТ";
                vpause = false;
            }
        }



        private void button_one_bal_red_Click(object sender, EventArgs e)
        {
            AddBals(1, 0);
            AddToFileProtokol("+1", "");
        }

        private void button_two_bal_red_Click(object sender, EventArgs e)
        {
            AddBals(2, 0);
            AddToFileProtokol("+2", "");
        }

        private void button_three_bal_red_Click(object sender, EventArgs e)
        {
            AddBals(3, 0);
            AddToFileProtokol("+3", "");
        }

        private void button_four_bal_red_Click(object sender, EventArgs e)
        {
            AddBals(4, 0);
            AddToFileProtokol("+4", "");
        }

        private void button_one_bal_red_min_Click(object sender, EventArgs e)
        {
            AddBals(-1, 0);
            AddToFileProtokol("-1", "");
        }

        private void button_two_bal_red_min_Click(object sender, EventArgs e)
        {
            AddBals(-2, 0);
            AddToFileProtokol("-2", "");
        }

        private void button_othree_bal_red_min_Click(object sender, EventArgs e)
        {
            AddBals(-3, 0);
            AddToFileProtokol("-3", "");
        }

        private void button_four_bal_red_min_Click(object sender, EventArgs e)
        {
            AddBals(-4, 0);
            AddToFileProtokol("-4", "");
        }

        private void button_one_bal_blue_Click(object sender, EventArgs e)
        {
            AddBals(0, 1);
            AddToFileProtokol("", "+1");
        }

        private void button_two_bal_blue_Click(object sender, EventArgs e)
        {
            AddBals(0, 2);
            AddToFileProtokol("", "+2");
        }

        private void button_three_bal_blue_Click(object sender, EventArgs e)
        {
            AddBals(0, 3);
            AddToFileProtokol("", "+3");
        }

        private void button_four_bal_blue_Click(object sender, EventArgs e)
        {
            AddBals(0, 4);
            AddToFileProtokol("", "+4");
        }

        private void button_one_bal_blue_min_Click(object sender, EventArgs e)
        {
            AddBals(0, -1);
            AddToFileProtokol("", "-1");
        }

        private void button_two_bal_blue_min_Click(object sender, EventArgs e)
        {
            AddBals(0, -2);
            AddToFileProtokol("", "-2");
        }

        private void button_three_bal_blue_min_Click(object sender, EventArgs e)
        {
            AddBals(0, -3);
            AddToFileProtokol("", "-3");
        }

        private void button_four_bal_blue_min_Click(object sender, EventArgs e)
        {
            AddBals(0, -4);
            AddToFileProtokol("", "-4");
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
            AddToFileProtokol("dis1", "");

        }

        private void button_red_d2_Click(object sender, EventArgs e)
        {
            if (dis_red)
            {
                fr2.panel5.Visible = true;
                dis_red = true;
                button_red_d3.Enabled = true;
            }
            else
            {
                fr2.panel5.Visible = false;
                dis_red = false;

            }
            AddToFileProtokol("dis2", "");
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
            show_panel_win(fr2.label_blue_name.Text);
            AddToFileWinner("", fr2.label_blue_name.Text);
            AddToFileProtokol("dis3", "winner");
            button_red_d3.Enabled = false;
        }

        private void button_blue_d1_Click(object sender, EventArgs e)
        {
            if (dis_blue)
            {
                fr2.panel10.Visible = false;
                dis_blue = false;
            }
            else
            {
                fr2.panel10.Visible = true;
                dis_blue = true;
                button_blue_d2.Enabled = true;
            }
            AddToFileProtokol("", "dis1");
        }

        private void button_blue_d2_Click(object sender, EventArgs e)
        {
            if (dis_blue)
            {
                fr2.panel9.Visible = true;
                dis_blue = true;
                button_blue_d3.Enabled = true;

            }
            else
            {
                fr2.panel9.Visible = false;
                dis_blue = false;
            }
            AddToFileProtokol("", "dis2");
        }

        private void button_blue_d3_Click(object sender, EventArgs e)
        {
            if (dis_blue)
            {
                fr2.panel8.Visible = false;
                dis_blue = false;
            }
            else
            {
                fr2.panel8.Visible = true;
                dis_blue = true;

            }
            show_panel_win(fr2.label_red_name.Text);
            AddToFileWinner(fr2.label_red_name.Text, "");
            AddToFileProtokol("winner", "dis3");
            button_blue_d3.Enabled = false;
        }

        private void button_winner_Click(object sender, EventArgs e)
        {
            fr3.Show();
            fr3.radioButtonBlueWin.Text = fr2.label_blue_name.Text;
            fr3.radioButtonRedWin.Text = fr2.label_red_name.Text;

        }

        private void button_winner_blue_Click(object sender, EventArgs e)
        {

        }

        private void buttonTimerReset_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
   "Вы хотите сбросить таймер ?",
   "Сообщение",
   MessageBoxButtons.YesNo,
   MessageBoxIcon.Information,
   MessageBoxDefaultButton.Button1,
   MessageBoxOptions.DefaultDesktopOnly);

            if (result == DialogResult.Yes)
            {
                ResetTimer();
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

            label1.Text = min_1.ToString();
            label3.Text = sec_1.ToString();
            if (secInContest < 1)
            {
                int win_1 = int.Parse(fr2.label_red_score.Text);
                int win_2 = int.Parse(fr2.label_blue_score.Text);

                if (win_1 > win_2)
                {
                    AddToFileProtokol("winner red", "luser blue ");
                    show_panel_win(fr2.label_red_name.Text);
                    AddToFileWinner(fr2.label_red_name.Text, "");
                }
                else
                {
                    AddToFileProtokol("luser red ", "winner blue");
                    show_panel_win(fr2.label_blue_name.Text);
                    AddToFileWinner("", fr2.label_blue_name.Text);
                }
                timer1.Enabled = false;
            }

            min_1 = secInContest / 60;
            sec_1 = secInContest % 60;
            secInContest--;
            fr2.label_timer_sec.Text = sec_1.ToString();
            fr2.label_timer_min.Text = min_1.ToString();
            /* sec_1 = sec_1 - 1;
             fr2.label_timer_sec.Text = sec_1.ToString();
             label3.Text = sec_1.ToString();
             label1.Text = min_1.ToString();
             if (sec_1 == 0)
             {
                 sec_1 = 60;
                 int min_1 = int.Parse(fr2.label_timer_min.Text) - 1;
                 if (min_1 == 0)
                 { timer1.Enabled = false; }
                 fr2.label_timer_min.Text = min_1.ToString();

             }*/
        }


        private void buttonAdvantecRed_Click(object sender, EventArgs e)
        {
            advRed += 1;
            fr2.panelAdvantecRed.Visible = true;
            fr2.labelAdvanRed.Text = advRed.ToString();
            AddToFileProtokol("Adantec " + advRed.ToString(), "");


        }


        private void listBox_red_names_SelectedIndexChanged(object sender, EventArgs e)
        {
            button_add_sportsmen.Enabled = true;
        }

        private void buttonAdvantecBlue_Click(object sender, EventArgs e)
        {
            advBlue += 1;
            fr2.panelAdvantecBlue.Visible = true;
            fr2.labelAdvanBlue.Text = advBlue.ToString();
            AddToFileProtokol("", "Adantec " + advBlue.ToString());
        }

        private void buttonEndOfContest_Click(object sender, EventArgs e)
        {

            DialogResult result = MessageBox.Show(
        "Вы хотите закончить поединок ?",
        "Сообщение",
        MessageBoxButtons.YesNo,
        MessageBoxIcon.Information,
        MessageBoxDefaultButton.Button1,
        MessageBoxOptions.DefaultDesktopOnly);

            if (result == DialogResult.Yes)
            {
                fr2.label_blue_score.Text = "0";
                fr2.label_red_score.Text = "0";
                fr2.panel4.Visible = false;
                fr2.panel5.Visible = false;
                fr2.panel6.Visible = false;
                fr2.panel8.Visible = false;
                fr2.panel9.Visible = false;
                fr2.panel10.Visible = false;
                fr2.label_blue_name.Text = "blue";
                fr2.label_red_name.Text = "red";
                //   endOffContest("Null");
                ResetTimer();
                button_start_timer.Text = "СТАРТ";
                vpause = false;
                fr2.labelAdvanRed.Text = "0";
                fr2.labelAdvanBlue.Text = "0";
                fr2.panelAdvantecBlue.Visible = false;
                fr2.panelAdvantecRed.Visible = false;
                advBlue = 0;
                advRed = 0;
                button_blue_d2.Enabled = false;
                button_blue_d3.Enabled = false;
                button_red_d2.Enabled = false;
                button_red_d3.Enabled = false;
            }
        }

        private void Form1_Activated(object sender, EventArgs e)
        {
            string dateOnlyString = DateTime.Now.ToString("dd");
            int dt = int.Parse(dateOnlyString);
            if (dt > 10 & dt < 5) {
                DialogResult result = MessageBox.Show(
      "Время использования технической версии программы закончилось",
      "Всё",
      MessageBoxButtons.OK,
      MessageBoxIcon.Error);
                Application.Exit();
            }
        }
    }


}
