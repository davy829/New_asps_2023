namespace WinFormsAppASPS
{
    partial class Form3
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form3));
            buttonWinner = new Button();
            radioButtonRedWin = new RadioButton();
            radioButtonBlueWin = new RadioButton();
            panel1 = new Panel();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // buttonWinner
            // 
            buttonWinner.FlatStyle = FlatStyle.Popup;
            buttonWinner.Location = new Point(3, 95);
            buttonWinner.Name = "buttonWinner";
            buttonWinner.Size = new Size(348, 42);
            buttonWinner.TabIndex = 0;
            buttonWinner.Text = "Winner";
            buttonWinner.UseVisualStyleBackColor = true;
            buttonWinner.Click += buttonWinner_Click;
            // 
            // radioButtonRedWin
            // 
            radioButtonRedWin.BackColor = Color.IndianRed;
            radioButtonRedWin.FlatStyle = FlatStyle.Popup;
            radioButtonRedWin.Font = new Font("Arial", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            radioButtonRedWin.Location = new Point(3, 3);
            radioButtonRedWin.Name = "radioButtonRedWin";
            radioButtonRedWin.Size = new Size(348, 41);
            radioButtonRedWin.TabIndex = 1;
            radioButtonRedWin.TabStop = true;
            radioButtonRedWin.TextAlign = ContentAlignment.MiddleCenter;
            radioButtonRedWin.UseVisualStyleBackColor = false;
            // 
            // radioButtonBlueWin
            // 
            radioButtonBlueWin.BackColor = SystemColors.ActiveCaption;
            radioButtonBlueWin.FlatStyle = FlatStyle.Popup;
            radioButtonBlueWin.Font = new Font("Arial", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            radioButtonBlueWin.Location = new Point(3, 50);
            radioButtonBlueWin.Name = "radioButtonBlueWin";
            radioButtonBlueWin.Size = new Size(348, 39);
            radioButtonBlueWin.TabIndex = 2;
            radioButtonBlueWin.TabStop = true;
            radioButtonBlueWin.TextAlign = ContentAlignment.MiddleCenter;
            radioButtonBlueWin.UseVisualStyleBackColor = false;
            // 
            // panel1
            // 
            panel1.Controls.Add(radioButtonRedWin);
            panel1.Controls.Add(buttonWinner);
            panel1.Controls.Add(radioButtonBlueWin);
            panel1.Location = new Point(12, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(354, 140);
            panel1.TabIndex = 3;
            // 
            // Form3
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.AppWorkspace;
            ClientSize = new Size(378, 164);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form3";
            Text = "Winner";
            panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Button buttonWinner;
        public RadioButton radioButtonBlueWin;
        private Panel panel1;
        public RadioButton radioButtonRedWin;
    }
}