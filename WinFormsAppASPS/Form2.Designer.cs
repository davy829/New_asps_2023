namespace WinFormsAppASPS
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
            label_weight = new Label();
            label_red_name = new Label();
            label_red_score = new Label();
            panel2 = new Panel();
            label_blue_name = new Label();
            label_blue_score = new Label();
            panel_timer = new Panel();
            label_timer_sec = new Label();
            label_timer_separator = new Label();
            label_timer_min = new Label();
            timer1 = new System.Windows.Forms.Timer(components);
            panel3 = new Panel();
            panel4 = new Panel();
            panel5 = new Panel();
            panel6 = new Panel();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel_timer.SuspendLayout();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ActiveCaptionText;
            panel1.Controls.Add(panel3);
            panel1.Controls.Add(label_weight);
            panel1.Controls.Add(label_red_name);
            panel1.Controls.Add(label_red_score);
            panel1.Location = new Point(12, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(776, 226);
            panel1.TabIndex = 0;
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
            panel2.Controls.Add(label_blue_name);
            panel2.Controls.Add(label_blue_score);
            panel2.Location = new Point(12, 282);
            panel2.Name = "panel2";
            panel2.Size = new Size(776, 207);
            panel2.TabIndex = 1;
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
            panel_timer.Location = new Point(319, 253);
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
            // timer1
            // 
            timer1.Interval = 1000;
            timer1.Tick += timer1_Tick;
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
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel_timer.ResumeLayout(false);
            panel_timer.PerformLayout();
            panel3.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Panel panel_timer;
        private Label label_timer_separator;
        public System.Windows.Forms.Timer timer1;
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
    }
}