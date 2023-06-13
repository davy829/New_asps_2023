namespace WinFormsAppASPS
{
    public partial class Form1 : Form
    {
        Form2 fr2 = new Form2();
        String fullPath = Application.StartupPath.ToString();
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
                MessageBox.Show("Не подсоеденен второй монитор !!!", "Пиздец", MessageBoxButtons.YesNo);

            }
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
                MessageBox.Show(weit.Substring(4, weit.Length - 4), "Question", MessageBoxButtons.YesNo);

            }
        }
    }
}