namespace Soliter
{
    partial class StartGame
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
            textBoxUserName = new TextBox();
            buttonStartGame = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 7);
            label1.Name = "label1";
            label1.Size = new Size(119, 13);
            label1.TabIndex = 0;
            label1.Text = "Введите своё имя/ник";
            // 
            // textBoxUserName
            // 
            textBoxUserName.Location = new Point(15, 26);
            textBoxUserName.Name = "textBoxUserName";
            textBoxUserName.Size = new Size(116, 21);
            textBoxUserName.TabIndex = 1;
            // 
            // buttonStartGame
            // 
            buttonStartGame.Location = new Point(24, 53);
            buttonStartGame.Name = "buttonStartGame";
            buttonStartGame.Size = new Size(98, 23);
            buttonStartGame.TabIndex = 2;
            buttonStartGame.Text = "Начать игру";
            buttonStartGame.UseVisualStyleBackColor = true;
            buttonStartGame.Click += buttonStartGame_Click;
            // 
            // StartGame
            // 
            AutoScaleDimensions = new SizeF(6F, 13F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(147, 83);
            Controls.Add(buttonStartGame);
            Controls.Add(textBoxUserName);
            Controls.Add(label1);
            Name = "StartGame";
            Text = "StartGame";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox textBoxUserName;
        private Button buttonStartGame;
    }
}