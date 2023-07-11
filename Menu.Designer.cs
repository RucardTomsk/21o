namespace Soliter
{
    partial class Menu
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
            bStart = new Button();
            bStat = new Button();
            buttonExit = new Button();
            SuspendLayout();
            // 
            // bStart
            // 
            bStart.Location = new Point(12, 12);
            bStart.Name = "bStart";
            bStart.Size = new Size(220, 51);
            bStart.TabIndex = 0;
            bStart.Text = "Начать";
            bStart.UseVisualStyleBackColor = true;
            bStart.Click += bStart_Click;
            // 
            // bStat
            // 
            bStat.Location = new Point(12, 69);
            bStat.Name = "bStat";
            bStat.Size = new Size(220, 51);
            bStat.TabIndex = 1;
            bStat.Text = "Рекорды";
            bStat.UseVisualStyleBackColor = true;
            bStat.Click += bStat_Click;
            // 
            // buttonExit
            // 
            buttonExit.Location = new Point(12, 126);
            buttonExit.Name = "buttonExit";
            buttonExit.Size = new Size(220, 51);
            buttonExit.TabIndex = 2;
            buttonExit.Text = "Выход";
            buttonExit.UseVisualStyleBackColor = true;
            buttonExit.Click += buttonExit_Click;
            // 
            // Menu
            // 
            AutoScaleDimensions = new SizeF(6F, 13F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(244, 184);
            Controls.Add(buttonExit);
            Controls.Add(bStat);
            Controls.Add(bStart);
            Name = "Menu";
            Text = "Косынка";
            Load += Form1_Load;
            ResumeLayout(false);
        }

        #endregion

        private Button bStart;
        private Button bStat;
        private Button buttonExit;
    }
}