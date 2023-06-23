namespace WinFormsAppASPS
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            panel1 = new Panel();
            button_add_files = new Button();
            button_add_sportsmen = new Button();
            listBox_files_weit = new ListBox();
            listBox_blue_names = new ListBox();
            listBox_red_names = new ListBox();
            panel2 = new Panel();
            panel5 = new Panel();
            panel6 = new Panel();
            button_blue_d3 = new Button();
            button_blue_d2 = new Button();
            button_blue_d1 = new Button();
            button13 = new Button();
            button_winner_blue = new Button();
            button_four_bal_blue_min = new Button();
            button_three_bal_blue_min = new Button();
            button_two_bal_blue_min = new Button();
            button_one_bal_blue_min = new Button();
            button_four_bal_blue = new Button();
            button_three_bal_blue = new Button();
            button_two_bal_blue = new Button();
            button_one_bal_blue = new Button();
            panel3 = new Panel();
            panel4 = new Panel();
            button_red_d3 = new Button();
            button_red_d2 = new Button();
            button_red_d1 = new Button();
            buttonAdvantecRed = new Button();
            button_winner = new Button();
            button_four_bal_red_min = new Button();
            button_othree_bal_red_min = new Button();
            button_two_bal_red_min = new Button();
            button_one_bal_red_min = new Button();
            button_four_bal_red = new Button();
            button_three_bal_red = new Button();
            button_two_bal_red = new Button();
            button_one_bal_red = new Button();
            panel7 = new Panel();
            button1 = new Button();
            panel9 = new Panel();
            label5 = new Label();
            label4 = new Label();
            buttonTimerReset = new Button();
            textBox2 = new TextBox();
            textBox1 = new TextBox();
            panel8 = new Panel();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            button_start_timer = new Button();
            timer1 = new System.Windows.Forms.Timer(components);
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel5.SuspendLayout();
            panel6.SuspendLayout();
            panel3.SuspendLayout();
            panel4.SuspendLayout();
            panel7.SuspendLayout();
            panel9.SuspendLayout();
            panel8.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(button_add_files);
            panel1.Controls.Add(button_add_sportsmen);
            panel1.Controls.Add(listBox_files_weit);
            panel1.Controls.Add(listBox_blue_names);
            panel1.Controls.Add(listBox_red_names);
            panel1.Location = new Point(12, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(546, 277);
            panel1.TabIndex = 0;
            // 
            // button_add_files
            // 
            button_add_files.Location = new Point(472, 223);
            button_add_files.Name = "button_add_files";
            button_add_files.Size = new Size(70, 42);
            button_add_files.TabIndex = 4;
            button_add_files.Text = "Добавить файлы весов";
            button_add_files.UseVisualStyleBackColor = true;
            button_add_files.Click += button_add_files_Click;
            // 
            // button_add_sportsmen
            // 
            button_add_sportsmen.Location = new Point(3, 223);
            button_add_sportsmen.Name = "button_add_sportsmen";
            button_add_sportsmen.Size = new Size(460, 42);
            button_add_sportsmen.TabIndex = 3;
            button_add_sportsmen.Text = "Добавить спорсменов и включить экран";
            button_add_sportsmen.UseVisualStyleBackColor = true;
            button_add_sportsmen.Click += button_add_sportsmen_Click;
            // 
            // listBox_files_weit
            // 
            listBox_files_weit.FormattingEnabled = true;
            listBox_files_weit.ItemHeight = 15;
            listBox_files_weit.Location = new Point(472, 3);
            listBox_files_weit.Name = "listBox_files_weit";
            listBox_files_weit.Size = new Size(70, 214);
            listBox_files_weit.TabIndex = 2;
            listBox_files_weit.Click += listBox_files_weit_Click;
            // 
            // listBox_blue_names
            // 
            listBox_blue_names.ForeColor = Color.Blue;
            listBox_blue_names.FormattingEnabled = true;
            listBox_blue_names.ItemHeight = 15;
            listBox_blue_names.Location = new Point(233, 3);
            listBox_blue_names.Name = "listBox_blue_names";
            listBox_blue_names.Size = new Size(230, 214);
            listBox_blue_names.Sorted = true;
            listBox_blue_names.TabIndex = 1;
            // 
            // listBox_red_names
            // 
            listBox_red_names.ForeColor = Color.Red;
            listBox_red_names.FormattingEnabled = true;
            listBox_red_names.ItemHeight = 15;
            listBox_red_names.Location = new Point(3, 3);
            listBox_red_names.Name = "listBox_red_names";
            listBox_red_names.Size = new Size(224, 214);
            listBox_red_names.Sorted = true;
            listBox_red_names.TabIndex = 0;
            // 
            // panel2
            // 
            panel2.BorderStyle = BorderStyle.Fixed3D;
            panel2.Controls.Add(panel5);
            panel2.Controls.Add(panel3);
            panel2.Location = new Point(12, 295);
            panel2.Name = "panel2";
            panel2.Size = new Size(416, 238);
            panel2.TabIndex = 1;
            // 
            // panel5
            // 
            panel5.BorderStyle = BorderStyle.FixedSingle;
            panel5.Controls.Add(panel6);
            panel5.Controls.Add(button13);
            panel5.Controls.Add(button_winner_blue);
            panel5.Controls.Add(button_four_bal_blue_min);
            panel5.Controls.Add(button_three_bal_blue_min);
            panel5.Controls.Add(button_two_bal_blue_min);
            panel5.Controls.Add(button_one_bal_blue_min);
            panel5.Controls.Add(button_four_bal_blue);
            panel5.Controls.Add(button_three_bal_blue);
            panel5.Controls.Add(button_two_bal_blue);
            panel5.Controls.Add(button_one_bal_blue);
            panel5.Location = new Point(220, 3);
            panel5.Name = "panel5";
            panel5.Size = new Size(186, 228);
            panel5.TabIndex = 1;
            // 
            // panel6
            // 
            panel6.BorderStyle = BorderStyle.FixedSingle;
            panel6.Controls.Add(button_blue_d3);
            panel6.Controls.Add(button_blue_d2);
            panel6.Controls.Add(button_blue_d1);
            panel6.Location = new Point(4, 89);
            panel6.Name = "panel6";
            panel6.Size = new Size(177, 31);
            panel6.TabIndex = 9;
            // 
            // button_blue_d3
            // 
            button_blue_d3.Enabled = false;
            button_blue_d3.Location = new Point(118, 2);
            button_blue_d3.Name = "button_blue_d3";
            button_blue_d3.Size = new Size(54, 23);
            button_blue_d3.TabIndex = 2;
            button_blue_d3.Text = "DIS 3";
            button_blue_d3.UseVisualStyleBackColor = true;
            button_blue_d3.Click += button_blue_d3_Click;
            // 
            // button_blue_d2
            // 
            button_blue_d2.Enabled = false;
            button_blue_d2.Location = new Point(60, 2);
            button_blue_d2.Name = "button_blue_d2";
            button_blue_d2.Size = new Size(54, 23);
            button_blue_d2.TabIndex = 1;
            button_blue_d2.Text = "DIS 2";
            button_blue_d2.UseVisualStyleBackColor = true;
            button_blue_d2.Click += button_blue_d2_Click;
            // 
            // button_blue_d1
            // 
            button_blue_d1.Location = new Point(2, 2);
            button_blue_d1.Name = "button_blue_d1";
            button_blue_d1.Size = new Size(54, 23);
            button_blue_d1.TabIndex = 0;
            button_blue_d1.Text = "DIS 1";
            button_blue_d1.UseVisualStyleBackColor = true;
            button_blue_d1.Click += button_blue_d1_Click;
            // 
            // button13
            // 
            button13.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            button13.Location = new Point(3, 131);
            button13.Name = "button13";
            button13.Size = new Size(177, 42);
            button13.TabIndex = 1;
            button13.Text = "ADVANTEC";
            button13.UseVisualStyleBackColor = true;
            // 
            // button_winner_blue
            // 
            button_winner_blue.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            button_winner_blue.Location = new Point(3, 177);
            button_winner_blue.Name = "button_winner_blue";
            button_winner_blue.Size = new Size(177, 42);
            button_winner_blue.TabIndex = 1;
            button_winner_blue.Text = "WINNER";
            button_winner_blue.UseVisualStyleBackColor = true;
            button_winner_blue.Click += button_winner_blue_Click;
            // 
            // button_four_bal_blue_min
            // 
            button_four_bal_blue_min.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button_four_bal_blue_min.Location = new Point(140, 43);
            button_four_bal_blue_min.Name = "button_four_bal_blue_min";
            button_four_bal_blue_min.Size = new Size(40, 35);
            button_four_bal_blue_min.TabIndex = 8;
            button_four_bal_blue_min.Text = "-4";
            button_four_bal_blue_min.UseVisualStyleBackColor = true;
            button_four_bal_blue_min.Click += button_four_bal_blue_min_Click;
            // 
            // button_three_bal_blue_min
            // 
            button_three_bal_blue_min.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button_three_bal_blue_min.Location = new Point(94, 43);
            button_three_bal_blue_min.Name = "button_three_bal_blue_min";
            button_three_bal_blue_min.Size = new Size(40, 35);
            button_three_bal_blue_min.TabIndex = 7;
            button_three_bal_blue_min.Text = "-3";
            button_three_bal_blue_min.UseVisualStyleBackColor = true;
            button_three_bal_blue_min.Click += button_three_bal_blue_min_Click;
            // 
            // button_two_bal_blue_min
            // 
            button_two_bal_blue_min.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button_two_bal_blue_min.Location = new Point(48, 43);
            button_two_bal_blue_min.Name = "button_two_bal_blue_min";
            button_two_bal_blue_min.Size = new Size(40, 35);
            button_two_bal_blue_min.TabIndex = 6;
            button_two_bal_blue_min.Text = "-2";
            button_two_bal_blue_min.UseVisualStyleBackColor = true;
            button_two_bal_blue_min.Click += button_two_bal_blue_min_Click;
            // 
            // button_one_bal_blue_min
            // 
            button_one_bal_blue_min.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button_one_bal_blue_min.Location = new Point(3, 43);
            button_one_bal_blue_min.Name = "button_one_bal_blue_min";
            button_one_bal_blue_min.Size = new Size(40, 35);
            button_one_bal_blue_min.TabIndex = 5;
            button_one_bal_blue_min.Text = "-1";
            button_one_bal_blue_min.UseVisualStyleBackColor = true;
            button_one_bal_blue_min.Click += button_one_bal_blue_min_Click;
            // 
            // button_four_bal_blue
            // 
            button_four_bal_blue.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button_four_bal_blue.Location = new Point(140, 2);
            button_four_bal_blue.Name = "button_four_bal_blue";
            button_four_bal_blue.Size = new Size(40, 35);
            button_four_bal_blue.TabIndex = 4;
            button_four_bal_blue.Text = "+4";
            button_four_bal_blue.UseVisualStyleBackColor = true;
            button_four_bal_blue.Click += button_four_bal_blue_Click;
            // 
            // button_three_bal_blue
            // 
            button_three_bal_blue.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button_three_bal_blue.Location = new Point(94, 2);
            button_three_bal_blue.Name = "button_three_bal_blue";
            button_three_bal_blue.Size = new Size(40, 35);
            button_three_bal_blue.TabIndex = 3;
            button_three_bal_blue.Text = "+3";
            button_three_bal_blue.UseVisualStyleBackColor = true;
            button_three_bal_blue.Click += button_three_bal_blue_Click;
            // 
            // button_two_bal_blue
            // 
            button_two_bal_blue.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button_two_bal_blue.Location = new Point(48, 2);
            button_two_bal_blue.Name = "button_two_bal_blue";
            button_two_bal_blue.Size = new Size(40, 35);
            button_two_bal_blue.TabIndex = 2;
            button_two_bal_blue.Text = "+2";
            button_two_bal_blue.UseVisualStyleBackColor = true;
            button_two_bal_blue.Click += button_two_bal_blue_Click;
            // 
            // button_one_bal_blue
            // 
            button_one_bal_blue.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button_one_bal_blue.Location = new Point(3, 2);
            button_one_bal_blue.Name = "button_one_bal_blue";
            button_one_bal_blue.Size = new Size(40, 35);
            button_one_bal_blue.TabIndex = 1;
            button_one_bal_blue.Text = "+1";
            button_one_bal_blue.UseVisualStyleBackColor = true;
            button_one_bal_blue.Click += button_one_bal_blue_Click;
            // 
            // panel3
            // 
            panel3.BorderStyle = BorderStyle.FixedSingle;
            panel3.Controls.Add(panel4);
            panel3.Controls.Add(buttonAdvantecRed);
            panel3.Controls.Add(button_winner);
            panel3.Controls.Add(button_four_bal_red_min);
            panel3.Controls.Add(button_othree_bal_red_min);
            panel3.Controls.Add(button_two_bal_red_min);
            panel3.Controls.Add(button_one_bal_red_min);
            panel3.Controls.Add(button_four_bal_red);
            panel3.Controls.Add(button_three_bal_red);
            panel3.Controls.Add(button_two_bal_red);
            panel3.Controls.Add(button_one_bal_red);
            panel3.Location = new Point(3, 3);
            panel3.Name = "panel3";
            panel3.Size = new Size(186, 228);
            panel3.TabIndex = 0;
            // 
            // panel4
            // 
            panel4.BorderStyle = BorderStyle.FixedSingle;
            panel4.Controls.Add(button_red_d3);
            panel4.Controls.Add(button_red_d2);
            panel4.Controls.Add(button_red_d1);
            panel4.Location = new Point(3, 89);
            panel4.Name = "panel4";
            panel4.Size = new Size(177, 31);
            panel4.TabIndex = 1;
            // 
            // button_red_d3
            // 
            button_red_d3.Enabled = false;
            button_red_d3.Location = new Point(118, 2);
            button_red_d3.Name = "button_red_d3";
            button_red_d3.Size = new Size(54, 23);
            button_red_d3.TabIndex = 2;
            button_red_d3.Text = "DIS 3";
            button_red_d3.UseVisualStyleBackColor = true;
            button_red_d3.Click += button_red_d3_Click;
            // 
            // button_red_d2
            // 
            button_red_d2.Enabled = false;
            button_red_d2.Location = new Point(60, 2);
            button_red_d2.Name = "button_red_d2";
            button_red_d2.Size = new Size(54, 23);
            button_red_d2.TabIndex = 1;
            button_red_d2.Text = "DIS 2";
            button_red_d2.UseVisualStyleBackColor = true;
            button_red_d2.Click += button_red_d2_Click;
            // 
            // button_red_d1
            // 
            button_red_d1.Location = new Point(2, 2);
            button_red_d1.Name = "button_red_d1";
            button_red_d1.Size = new Size(54, 23);
            button_red_d1.TabIndex = 0;
            button_red_d1.Text = "DIS 1";
            button_red_d1.UseVisualStyleBackColor = true;
            button_red_d1.Click += button_red_d1_Click;
            // 
            // buttonAdvantecRed
            // 
            buttonAdvantecRed.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            buttonAdvantecRed.Location = new Point(3, 131);
            buttonAdvantecRed.Name = "buttonAdvantecRed";
            buttonAdvantecRed.Size = new Size(177, 42);
            buttonAdvantecRed.TabIndex = 1;
            buttonAdvantecRed.Text = "ADVANTEC";
            buttonAdvantecRed.UseVisualStyleBackColor = true;
            // 
            // button_winner
            // 
            button_winner.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            button_winner.Location = new Point(3, 177);
            button_winner.Name = "button_winner";
            button_winner.Size = new Size(177, 42);
            button_winner.TabIndex = 1;
            button_winner.Text = "WINNER";
            button_winner.UseVisualStyleBackColor = true;
            button_winner.Click += button_winner_Click;
            // 
            // button_four_bal_red_min
            // 
            button_four_bal_red_min.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button_four_bal_red_min.Location = new Point(140, 43);
            button_four_bal_red_min.Name = "button_four_bal_red_min";
            button_four_bal_red_min.Size = new Size(40, 35);
            button_four_bal_red_min.TabIndex = 8;
            button_four_bal_red_min.Text = "-4";
            button_four_bal_red_min.UseVisualStyleBackColor = true;
            button_four_bal_red_min.Click += button_four_bal_red_min_Click;
            // 
            // button_othree_bal_red_min
            // 
            button_othree_bal_red_min.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button_othree_bal_red_min.Location = new Point(94, 43);
            button_othree_bal_red_min.Name = "button_othree_bal_red_min";
            button_othree_bal_red_min.Size = new Size(40, 35);
            button_othree_bal_red_min.TabIndex = 7;
            button_othree_bal_red_min.Text = "-3";
            button_othree_bal_red_min.UseVisualStyleBackColor = true;
            button_othree_bal_red_min.Click += button_othree_bal_red_min_Click;
            // 
            // button_two_bal_red_min
            // 
            button_two_bal_red_min.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button_two_bal_red_min.Location = new Point(48, 43);
            button_two_bal_red_min.Name = "button_two_bal_red_min";
            button_two_bal_red_min.Size = new Size(40, 35);
            button_two_bal_red_min.TabIndex = 6;
            button_two_bal_red_min.Text = "-2";
            button_two_bal_red_min.UseVisualStyleBackColor = true;
            button_two_bal_red_min.Click += button_two_bal_red_min_Click;
            // 
            // button_one_bal_red_min
            // 
            button_one_bal_red_min.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button_one_bal_red_min.Location = new Point(3, 43);
            button_one_bal_red_min.Name = "button_one_bal_red_min";
            button_one_bal_red_min.Size = new Size(40, 35);
            button_one_bal_red_min.TabIndex = 5;
            button_one_bal_red_min.Text = "-1";
            button_one_bal_red_min.UseVisualStyleBackColor = true;
            button_one_bal_red_min.Click += button_one_bal_red_min_Click;
            // 
            // button_four_bal_red
            // 
            button_four_bal_red.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button_four_bal_red.Location = new Point(140, 2);
            button_four_bal_red.Name = "button_four_bal_red";
            button_four_bal_red.Size = new Size(40, 35);
            button_four_bal_red.TabIndex = 4;
            button_four_bal_red.Text = "+4";
            button_four_bal_red.UseVisualStyleBackColor = true;
            button_four_bal_red.Click += button_four_bal_red_Click;
            // 
            // button_three_bal_red
            // 
            button_three_bal_red.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button_three_bal_red.Location = new Point(94, 2);
            button_three_bal_red.Name = "button_three_bal_red";
            button_three_bal_red.Size = new Size(40, 35);
            button_three_bal_red.TabIndex = 3;
            button_three_bal_red.Text = "+3";
            button_three_bal_red.UseVisualStyleBackColor = true;
            button_three_bal_red.Click += button_three_bal_red_Click;
            // 
            // button_two_bal_red
            // 
            button_two_bal_red.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button_two_bal_red.Location = new Point(48, 2);
            button_two_bal_red.Name = "button_two_bal_red";
            button_two_bal_red.Size = new Size(40, 35);
            button_two_bal_red.TabIndex = 2;
            button_two_bal_red.Text = "+2";
            button_two_bal_red.UseVisualStyleBackColor = true;
            button_two_bal_red.Click += button_two_bal_red_Click;
            // 
            // button_one_bal_red
            // 
            button_one_bal_red.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button_one_bal_red.Location = new Point(3, 2);
            button_one_bal_red.Name = "button_one_bal_red";
            button_one_bal_red.Size = new Size(40, 35);
            button_one_bal_red.TabIndex = 1;
            button_one_bal_red.Text = "+1";
            button_one_bal_red.UseVisualStyleBackColor = true;
            button_one_bal_red.Click += button_one_bal_red_Click;
            // 
            // panel7
            // 
            panel7.BorderStyle = BorderStyle.FixedSingle;
            panel7.Controls.Add(button1);
            panel7.Controls.Add(panel9);
            panel7.Controls.Add(panel8);
            panel7.Controls.Add(button_start_timer);
            panel7.Location = new Point(435, 296);
            panel7.Name = "panel7";
            panel7.Size = new Size(124, 232);
            panel7.TabIndex = 2;
            // 
            // button1
            // 
            button1.BackColor = Color.Firebrick;
            button1.ForeColor = SystemColors.ControlLightLight;
            button1.Location = new Point(3, 98);
            button1.Name = "button1";
            button1.Size = new Size(116, 45);
            button1.TabIndex = 4;
            button1.Text = "ЗАКОНЧИТЬ ПОЕДИНОК";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // panel9
            // 
            panel9.BorderStyle = BorderStyle.FixedSingle;
            panel9.Controls.Add(label5);
            panel9.Controls.Add(label4);
            panel9.Controls.Add(buttonTimerReset);
            panel9.Controls.Add(textBox2);
            panel9.Controls.Add(textBox1);
            panel9.Location = new Point(4, 146);
            panel9.Name = "panel9";
            panel9.Size = new Size(114, 80);
            panel9.TabIndex = 3;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 6.75F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(88, 64);
            label5.Name = "label5";
            label5.Size = new Size(18, 12);
            label5.TabIndex = 4;
            label5.Text = "сек";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 6.75F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(35, 65);
            label4.Name = "label4";
            label4.Size = new Size(21, 12);
            label4.TabIndex = 3;
            label4.Text = "мин";
            // 
            // buttonTimerReset
            // 
            buttonTimerReset.Location = new Point(3, 2);
            buttonTimerReset.Name = "buttonTimerReset";
            buttonTimerReset.Size = new Size(105, 49);
            buttonTimerReset.TabIndex = 2;
            buttonTimerReset.Text = "Сбросить таймер";
            buttonTimerReset.UseVisualStyleBackColor = true;
            buttonTimerReset.Click += buttonTimerReset_Click;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(57, 53);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(31, 23);
            textBox2.TabIndex = 1;
            textBox2.Text = "59";
            textBox2.TextAlign = HorizontalAlignment.Center;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(4, 53);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(31, 23);
            textBox1.TabIndex = 0;
            textBox1.Text = "4";
            textBox1.TextAlign = HorizontalAlignment.Center;
            // 
            // panel8
            // 
            panel8.BackColor = SystemColors.ButtonHighlight;
            panel8.Controls.Add(label3);
            panel8.Controls.Add(label2);
            panel8.Controls.Add(label1);
            panel8.Location = new Point(65, 8);
            panel8.Name = "panel8";
            panel8.Size = new Size(49, 23);
            panel8.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial Narrow", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(24, 2);
            label3.Name = "label3";
            label3.Size = new Size(19, 16);
            label3.TabIndex = 2;
            label3.Text = "60";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial Narrow", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(16, 2);
            label2.Name = "label2";
            label2.Size = new Size(10, 16);
            label2.TabIndex = 1;
            label2.Text = ":";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial Narrow", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(5, 2);
            label1.Name = "label1";
            label1.Size = new Size(13, 16);
            label1.TabIndex = 0;
            label1.Text = "5";
            // 
            // button_start_timer
            // 
            button_start_timer.BackColor = SystemColors.ButtonHighlight;
            button_start_timer.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            button_start_timer.ForeColor = Color.Red;
            button_start_timer.Location = new Point(3, 4);
            button_start_timer.Name = "button_start_timer";
            button_start_timer.Size = new Size(116, 90);
            button_start_timer.TabIndex = 0;
            button_start_timer.Text = "СТАРТ";
            button_start_timer.UseVisualStyleBackColor = false;
            button_start_timer.Click += button_start_timer_Click;
            // 
            // timer1
            // 
            timer1.Interval = 50;
            timer1.Tick += timer1_Tick;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(570, 536);
            Controls.Add(panel7);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Form1";
            Text = "ASPS ver 1.0";
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel5.ResumeLayout(false);
            panel6.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel4.ResumeLayout(false);
            panel7.ResumeLayout(false);
            panel9.ResumeLayout(false);
            panel9.PerformLayout();
            panel8.ResumeLayout(false);
            panel8.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button button_add_files;
        private Button button_add_sportsmen;
        private ListBox listBox_files_weit;
        private ListBox listBox_blue_names;
        private ListBox listBox_red_names;
        private Panel panel2;
        private Panel panel3;
        private Button button_three_bal_red;
        private Button button_two_bal_red;
        private Button button_one_bal_red;
        private Panel panel4;
        private Button buttonAdvantecRed;
        private Button button_winner;
        private Button button_four_bal_red_min;
        private Button button_othree_bal_red_min;
        private Button button_two_bal_red_min;
        private Button button_one_bal_red_min;
        private Button button_four_bal_red;
        private Panel panel5;
        private Button button13;
        private Button button_winner_blue;
        private Button button_four_bal_blue_min;
        private Button button_three_bal_blue_min;
        private Button button_two_bal_blue_min;
        private Button button_one_bal_blue_min;
        private Button button_four_bal_blue;
        private Button button_three_bal_blue;
        private Button button_two_bal_blue;
        private Button button_one_bal_blue;
        private Panel panel7;
        private Panel panel8;
        private Label label3;
        private Label label2;
        private Label label1;
        private Button button_start_timer;
        private Panel panel9;
        private Label label5;
        private Label label4;
        private Button buttonTimerReset;
        private Button button_red_d1;
        private Button button_red_d3;
        private Button button_red_d2;
        private Panel panel6;
        private Button button_blue_d3;
        private Button button_blue_d2;
        private Button button_blue_d1;
        public TextBox textBox2;
        public TextBox textBox1;
        private System.Windows.Forms.Timer timer1;
        private Button button1;
    }
}