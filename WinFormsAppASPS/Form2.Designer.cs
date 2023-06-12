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
            panel1 = new Panel();
            panel2 = new Panel();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ActiveCaptionText;
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(12, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(776, 226);
            panel1.TabIndex = 0;
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.ActiveCaptionText;
            panel2.Controls.Add(label4);
            panel2.Controls.Add(label2);
            panel2.Location = new Point(12, 244);
            panel2.Name = "panel2";
            panel2.Size = new Size(776, 207);
            panel2.TabIndex = 1;
            // 
            // label1
            // 
            label1.BackColor = Color.Red;
            label1.BorderStyle = BorderStyle.FixedSingle;
            label1.FlatStyle = FlatStyle.Popup;
            label1.Font = new Font("Arial", 120F, FontStyle.Bold, GraphicsUnit.Point);
            label1.LiveSetting = System.Windows.Forms.Automation.AutomationLiveSetting.Assertive;
            label1.Location = new Point(16, 13);
            label1.Margin = new Padding(0);
            label1.MaximumSize = new Size(275, 174);
            label1.Name = "label1";
            label1.Size = new Size(263, 174);
            label1.TabIndex = 0;
            label1.Text = "01";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            label2.BackColor = Color.Blue;
            label2.BorderStyle = BorderStyle.FixedSingle;
            label2.FlatStyle = FlatStyle.Popup;
            label2.Font = new Font("Arial", 120F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(16, 14);
            label2.Name = "label2";
            label2.Size = new Size(263, 183);
            label2.TabIndex = 1;
            label2.Text = "01";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial", 48F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = SystemColors.ButtonHighlight;
            label3.Location = new Point(345, 127);
            label3.Name = "label3";
            label3.Size = new Size(123, 72);
            label3.TabIndex = 1;
            label3.Text = "red";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Arial", 48F, FontStyle.Regular, GraphicsUnit.Point);
            label4.ForeColor = SystemColors.ButtonHighlight;
            label4.Location = new Point(326, 125);
            label4.Name = "label4";
            label4.Size = new Size(152, 72);
            label4.TabIndex = 2;
            label4.Text = "blue";
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 482);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "Form2";
            Text = "Form2";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label3;
        private Label label1;
        private Panel panel2;
        private Label label2;
        private Label label4;
    }
}