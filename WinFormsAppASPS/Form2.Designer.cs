﻿namespace WinFormsAppASPS
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            panel1 = new Panel();
            panelAdvantecRed = new Panel();
            labelAdvanRed = new Label();
            panel_winner = new Panel();
            label2 = new Label();
            label_winner = new Label();
            panel3 = new Panel();
            panel6 = new Panel();
            panel5 = new Panel();
            panel4 = new Panel();
            label_weight = new Label();
            label_red_name = new Label();
            label_red_score = new Label();
            panel2 = new Panel();
            panelAdvantecBlue = new Panel();
            panel7 = new Panel();
            panel8 = new Panel();
            panel9 = new Panel();
            panel10 = new Panel();
            label_blue_name = new Label();
            label_blue_score = new Label();
            panel_timer = new Panel();
            label_timer_sec = new Label();
            label_timer_separator = new Label();
            label_timer_min = new Label();
            timer2 = new System.Windows.Forms.Timer(components);
            labelAdvanBlue = new Label();
            panel1.SuspendLayout();
            panelAdvantecRed.SuspendLayout();
            panel_winner.SuspendLayout();
            panel3.SuspendLayout();
            panel2.SuspendLayout();
            panelAdvantecBlue.SuspendLayout();
            panel7.SuspendLayout();
            panel_timer.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ActiveCaptionText;
            panel1.Controls.Add(panelAdvantecRed);
            panel1.Controls.Add(panel_winner);
            panel1.Controls.Add(panel3);
            panel1.Controls.Add(label_weight);
            panel1.Controls.Add(label_red_name);
            panel1.Controls.Add(label_red_score);
            panel1.Location = new Point(12, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(776, 226);
            panel1.TabIndex = 0;
            // 
            // panelAdvantecRed
            // 
            panelAdvantecRed.BackColor = Color.Red;
            panelAdvantecRed.BackgroundImage = Properties.Resources.ottopyr_mizinec54;
            panelAdvantecRed.BackgroundImageLayout = ImageLayout.Stretch;
            panelAdvantecRed.Controls.Add(labelAdvanRed);
            panelAdvantecRed.Location = new Point(229, 139);
            panelAdvantecRed.Name = "panelAdvantecRed";
            panelAdvantecRed.Size = new Size(50, 48);
            panelAdvantecRed.TabIndex = 4;
            panelAdvantecRed.Visible = false;
            // 
            // labelAdvanRed
            // 
            labelAdvanRed.AutoSize = true;
            labelAdvanRed.ForeColor = SystemColors.ControlLightLight;
            labelAdvanRed.Location = new Point(35, 3);
            labelAdvanRed.Name = "labelAdvanRed";
            labelAdvanRed.Size = new Size(13, 15);
            labelAdvanRed.TabIndex = 0;
            labelAdvanRed.Text = "0";
            // 
            // panel_winner
            // 
            panel_winner.BackColor = SystemColors.ActiveCaptionText;
            panel_winner.BackgroundImage = Properties.Resources.win;
            panel_winner.BackgroundImageLayout = ImageLayout.Center;
            panel_winner.Controls.Add(label2);
            panel_winner.Controls.Add(label_winner);
            panel_winner.Location = new Point(648, 115);
            panel_winner.Name = "panel_winner";
            panel_winner.Size = new Size(612, 406);
            panel_winner.TabIndex = 3;
            panel_winner.Visible = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI Semibold", 72F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = SystemColors.ControlLightLight;
            label2.Location = new Point(226, 320);
            label2.Name = "label2";
            label2.Size = new Size(433, 128);
            label2.TabIndex = 1;
            label2.Text = "WINNER";
            // 
            // label_winner
            // 
            label_winner.AutoSize = true;
            label_winner.BackColor = Color.Transparent;
            label_winner.Font = new Font("Segoe UI Semibold", 72F, FontStyle.Bold, GraphicsUnit.Point);
            label_winner.ForeColor = SystemColors.ButtonHighlight;
            label_winner.Location = new Point(107, 0);
            label_winner.Name = "label_winner";
            label_winner.Size = new Size(302, 128);
            label_winner.TabIndex = 0;
            label_winner.Text = "label1";
            // 
            // panel3
            // 
            panel3.BackColor = Color.Transparent;
            panel3.Controls.Add(panel6);
            panel3.Controls.Add(panel5);
            panel3.Controls.Add(panel4);
            panel3.Location = new Point(306, 13);
            panel3.Name = "panel3";
            panel3.Size = new Size(87, 99);
            panel3.TabIndex = 3;
            // 
            // panel6
            // 
            panel6.BackColor = Color.Yellow;
            panel6.BorderStyle = BorderStyle.Fixed3D;
            panel6.Location = new Point(37, 25);
            panel6.Name = "panel6";
            panel6.Size = new Size(46, 62);
            panel6.TabIndex = 2;
            panel6.Visible = false;
            // 
            // panel5
            // 
            panel5.BackColor = Color.Yellow;
            panel5.BorderStyle = BorderStyle.Fixed3D;
            panel5.Location = new Point(18, 14);
            panel5.Name = "panel5";
            panel5.Size = new Size(46, 62);
            panel5.TabIndex = 1;
            panel5.Visible = false;
            // 
            // panel4
            // 
            panel4.BackColor = Color.Yellow;
            panel4.BorderStyle = BorderStyle.Fixed3D;
            panel4.Location = new Point(3, 3);
            panel4.Name = "panel4";
            panel4.Size = new Size(46, 62);
            panel4.TabIndex = 0;
            panel4.Visible = false;
            // 
            // label_weight
            // 
            label_weight.AutoSize = true;
            label_weight.Font = new Font("Segoe UI", 48F, FontStyle.Regular, GraphicsUnit.Point);
            label_weight.ForeColor = SystemColors.ButtonFace;
            label_weight.Location = new Point(521, 13);
            label_weight.Name = "label_weight";
            label_weight.Size = new Size(107, 86);
            label_weight.TabIndex = 2;
            label_weight.Text = "52";
            // 
            // label_red_name
            // 
            label_red_name.AutoSize = true;
            label_red_name.Font = new Font("Arial", 48F, FontStyle.Regular, GraphicsUnit.Point);
            label_red_name.ForeColor = Color.Red;
            label_red_name.Location = new Point(307, 115);
            label_red_name.Name = "label_red_name";
            label_red_name.Size = new Size(123, 72);
            label_red_name.TabIndex = 1;
            label_red_name.Text = "red";
            // 
            // label_red_score
            // 
            label_red_score.BackColor = Color.Red;
            label_red_score.BorderStyle = BorderStyle.FixedSingle;
            label_red_score.FlatStyle = FlatStyle.Popup;
            label_red_score.Font = new Font("Arial", 120F, FontStyle.Bold, GraphicsUnit.Point);
            label_red_score.LiveSetting = System.Windows.Forms.Automation.AutomationLiveSetting.Assertive;
            label_red_score.Location = new Point(16, 13);
            label_red_score.Margin = new Padding(0);
            label_red_score.MaximumSize = new Size(275, 174);
            label_red_score.Name = "label_red_score";
            label_red_score.Size = new Size(263, 174);
            label_red_score.TabIndex = 0;
            label_red_score.Text = "0";
            label_red_score.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.ActiveCaptionText;
            panel2.Controls.Add(panelAdvantecBlue);
            panel2.Controls.Add(panel7);
            panel2.Controls.Add(label_blue_name);
            panel2.Controls.Add(label_blue_score);
            panel2.Location = new Point(12, 282);
            panel2.Name = "panel2";
            panel2.Size = new Size(776, 207);
            panel2.TabIndex = 1;
            // 
            // panelAdvantecBlue
            // 
            panelAdvantecBlue.BackColor = Color.Blue;
            panelAdvantecBlue.BackgroundImage = Properties.Resources.ottopyr_mizinec54;
            panelAdvantecBlue.BackgroundImageLayout = ImageLayout.Stretch;
            panelAdvantecBlue.Controls.Add(labelAdvanBlue);
            panelAdvantecBlue.Location = new Point(229, 149);
            panelAdvantecBlue.Name = "panelAdvantecBlue";
            panelAdvantecBlue.Size = new Size(50, 48);
            panelAdvantecBlue.TabIndex = 5;
            panelAdvantecBlue.Visible = false;
            // 
            // panel7
            // 
            panel7.BackColor = Color.Transparent;
            panel7.Controls.Add(panel8);
            panel7.Controls.Add(panel9);
            panel7.Controls.Add(panel10);
            panel7.Location = new Point(309, 14);
            panel7.Name = "panel7";
            panel7.Size = new Size(87, 99);
            panel7.TabIndex = 4;
            // 
            // panel8
            // 
            panel8.BackColor = Color.Yellow;
            panel8.BorderStyle = BorderStyle.Fixed3D;
            panel8.Location = new Point(37, 25);
            panel8.Name = "panel8";
            panel8.Size = new Size(46, 62);
            panel8.TabIndex = 2;
            panel8.Visible = false;
            // 
            // panel9
            // 
            panel9.BackColor = Color.Yellow;
            panel9.BorderStyle = BorderStyle.Fixed3D;
            panel9.Location = new Point(18, 14);
            panel9.Name = "panel9";
            panel9.Size = new Size(46, 62);
            panel9.TabIndex = 1;
            panel9.Visible = false;
            // 
            // panel10
            // 
            panel10.BackColor = Color.Yellow;
            panel10.BorderStyle = BorderStyle.Fixed3D;
            panel10.Location = new Point(3, 3);
            panel10.Name = "panel10";
            panel10.Size = new Size(46, 62);
            panel10.TabIndex = 0;
            panel10.Visible = false;
            // 
            // label_blue_name
            // 
            label_blue_name.AutoSize = true;
            label_blue_name.Font = new Font("Arial", 48F, FontStyle.Regular, GraphicsUnit.Point);
            label_blue_name.ForeColor = Color.Blue;
            label_blue_name.Location = new Point(307, 125);
            label_blue_name.Name = "label_blue_name";
            label_blue_name.Size = new Size(152, 72);
            label_blue_name.TabIndex = 2;
            label_blue_name.Text = "blue";
            // 
            // label_blue_score
            // 
            label_blue_score.BackColor = Color.Blue;
            label_blue_score.BorderStyle = BorderStyle.FixedSingle;
            label_blue_score.FlatStyle = FlatStyle.Popup;
            label_blue_score.Font = new Font("Arial", 120F, FontStyle.Bold, GraphicsUnit.Point);
            label_blue_score.Location = new Point(16, 14);
            label_blue_score.Name = "label_blue_score";
            label_blue_score.Size = new Size(263, 183);
            label_blue_score.TabIndex = 1;
            label_blue_score.Text = "0";
            label_blue_score.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panel_timer
            // 
            panel_timer.BackColor = SystemColors.ActiveCaptionText;
            panel_timer.Controls.Add(label_timer_sec);
            panel_timer.Controls.Add(label_timer_separator);
            panel_timer.Controls.Add(label_timer_min);
            panel_timer.ForeColor = SystemColors.ButtonHighlight;
            panel_timer.Location = new Point(485, 253);
            panel_timer.Name = "panel_timer";
            panel_timer.Size = new Size(409, 151);
            panel_timer.TabIndex = 2;
            // 
            // label_timer_sec
            // 
            label_timer_sec.AutoSize = true;
            label_timer_sec.Font = new Font("Arial", 125.25F, FontStyle.Bold, GraphicsUnit.Point);
            label_timer_sec.ForeColor = SystemColors.ButtonHighlight;
            label_timer_sec.Location = new Point(175, -23);
            label_timer_sec.Name = "label_timer_sec";
            label_timer_sec.Size = new Size(266, 190);
            label_timer_sec.TabIndex = 2;
            label_timer_sec.Text = "59";
            // 
            // label_timer_separator
            // 
            label_timer_separator.AutoSize = true;
            label_timer_separator.Font = new Font("Arial", 125.25F, FontStyle.Bold, GraphicsUnit.Point);
            label_timer_separator.ForeColor = SystemColors.ButtonHighlight;
            label_timer_separator.Location = new Point(102, -38);
            label_timer_separator.Name = "label_timer_separator";
            label_timer_separator.Size = new Size(136, 190);
            label_timer_separator.TabIndex = 1;
            label_timer_separator.Text = ":";
            // 
            // label_timer_min
            // 
            label_timer_min.AutoSize = true;
            label_timer_min.Font = new Font("Arial", 125.25F, FontStyle.Bold, GraphicsUnit.Point);
            label_timer_min.ForeColor = SystemColors.ButtonHighlight;
            label_timer_min.Location = new Point(-19, -21);
            label_timer_min.Name = "label_timer_min";
            label_timer_min.Size = new Size(173, 190);
            label_timer_min.TabIndex = 0;
            label_timer_min.Text = "4";
            // 
            // timer2
            // 
            timer2.Interval = 1000;
            timer2.Tick += timer2_Tick;
            // 
            // labelAdvanBlue
            // 
            labelAdvanBlue.AutoSize = true;
            labelAdvanBlue.ForeColor = SystemColors.ControlLightLight;
            labelAdvanBlue.Location = new Point(35, 1);
            labelAdvanBlue.Name = "labelAdvanBlue";
            labelAdvanBlue.Size = new Size(13, 15);
            labelAdvanBlue.TabIndex = 1;
            labelAdvanBlue.Text = "0";
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 482);
            Controls.Add(panel_timer);
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Form2";
            Text = "Form2";
            Load += Form2_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panelAdvantecRed.ResumeLayout(false);
            panelAdvantecRed.PerformLayout();
            panel_winner.ResumeLayout(false);
            panel_winner.PerformLayout();
            panel3.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panelAdvantecBlue.ResumeLayout(false);
            panelAdvantecBlue.PerformLayout();
            panel7.ResumeLayout(false);
            panel_timer.ResumeLayout(false);
            panel_timer.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Panel panel_timer;
        private Label label_timer_separator;
        public Label label_red_name;
        public Label label_red_score;
        public Label label_blue_score;
        public Label label_blue_name;
        public Label label_timer_sec;
        public Label label_timer_min;
        public Label label_weight;
        private Panel panel3;
        public Panel panel4;
        public Panel panel6;
        public Panel panel5;
        private Panel panel7;
        public Panel panel8;
        public Panel panel9;
        public Panel panel10;
        public Panel panel_winner;
        private Label label2;
        public Label label_winner;
        public System.Windows.Forms.Timer timer2;
        public Panel panelAdvantecRed;
        public Panel panelAdvantecBlue;
        public Label labelAdvanRed;
        public Label labelAdvanBlue;
    }
}