namespace Soliter
{
    partial class Record
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
            label1 = new Label();
            buttonMenu = new Button();
            textBox1 = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 36F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(23, 9);
            label1.Name = "label1";
            label1.Size = new Size(211, 55);
            label1.TabIndex = 0;
            label1.Text = "Рекорды";
            // 
            // buttonMenu
            // 
            buttonMenu.Font = new Font("Times New Roman", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            buttonMenu.Location = new Point(80, 407);
            buttonMenu.Name = "buttonMenu";
            buttonMenu.Size = new Size(101, 31);
            buttonMenu.TabIndex = 2;
            buttonMenu.Text = "Назад";
            buttonMenu.UseVisualStyleBackColor = true;
            buttonMenu.Click += buttonMenu_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(36, 67);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.ReadOnly = true;
            textBox1.RightToLeft = RightToLeft.No;
            textBox1.ScrollBars = ScrollBars.Vertical;
            textBox1.Size = new Size(185, 325);
            textBox1.TabIndex = 3;
            // 
            // Record
            // 
            AutoScaleDimensions = new SizeF(6F, 13F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            ClientSize = new Size(258, 450);
            Controls.Add(textBox1);
            Controls.Add(buttonMenu);
            Controls.Add(label1);
            Name = "Record";
            Text = "Record";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button buttonMenu;
        private TextBox textBox1;
    }
}