namespace Soliter
{
    partial class Game
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
            reset_timer = new System.Windows.Forms.Timer(components);
            sec_timer = new System.Windows.Forms.Timer(components);
            label2 = new Label();
            labelEX = new Label();
            buttonPlus = new Button();
            buttonMinus = new Button();
            labelST2 = new Label();
            labelST = new Label();
            buttonPass = new Button();
            buttonNext = new Button();
            panel1 = new Panel();
            panel2 = new Panel();
            panel3 = new Panel();
            labelName = new Label();
            labelNameBot = new Label();
            buttonExit = new Button();
            buttonSTA = new Button();
            label1 = new Label();
            labelEX2 = new Label();
            labelLose = new Label();
            labelWin = new Label();
            buttonRaund = new Button();
            SuspendLayout();
            // 
            // reset_timer
            // 
            reset_timer.Enabled = true;
            reset_timer.Tick += reset_timer_Tick;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Tahoma", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(20, 556);
            label2.Name = "label2";
            label2.Size = new Size(130, 23);
            label2.TabIndex = 16;
            label2.Text = "Ваши фишки:";
            // 
            // labelEX
            // 
            labelEX.AutoSize = true;
            labelEX.Font = new Font("Tahoma", 26.25F, FontStyle.Regular, GraphicsUnit.Point);
            labelEX.Location = new Point(161, 548);
            labelEX.Name = "labelEX";
            labelEX.Size = new Size(37, 42);
            labelEX.TabIndex = 15;
            labelEX.Text = "0";
            // 
            // buttonPlus
            // 
            buttonPlus.Font = new Font("Tahoma", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            buttonPlus.Location = new Point(511, 294);
            buttonPlus.Name = "buttonPlus";
            buttonPlus.Size = new Size(37, 39);
            buttonPlus.TabIndex = 14;
            buttonPlus.Text = "+";
            buttonPlus.UseVisualStyleBackColor = true;
            buttonPlus.Click += buttonPlus_Click;
            // 
            // buttonMinus
            // 
            buttonMinus.Font = new Font("Tahoma", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            buttonMinus.Location = new Point(372, 297);
            buttonMinus.Name = "buttonMinus";
            buttonMinus.Size = new Size(37, 39);
            buttonMinus.TabIndex = 13;
            buttonMinus.Text = "-";
            buttonMinus.UseVisualStyleBackColor = true;
            buttonMinus.Click += buttonMinus_Click;
            // 
            // labelST2
            // 
            labelST2.AutoSize = true;
            labelST2.Font = new Font("Tahoma", 26.25F, FontStyle.Regular, GraphicsUnit.Point);
            labelST2.Location = new Point(438, 294);
            labelST2.Name = "labelST2";
            labelST2.Size = new Size(37, 42);
            labelST2.TabIndex = 12;
            labelST2.Text = "0";
            // 
            // labelST
            // 
            labelST.AutoSize = true;
            labelST.Font = new Font("Tahoma", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            labelST.Location = new Point(402, 258);
            labelST.Name = "labelST";
            labelST.Size = new Size(119, 23);
            labelST.TabIndex = 11;
            labelST.Text = "Ваша ставка";
            // 
            // buttonPass
            // 
            buttonPass.Enabled = false;
            buttonPass.Font = new Font("Tahoma", 18F, FontStyle.Regular, GraphicsUnit.Point);
            buttonPass.Location = new Point(481, 294);
            buttonPass.Name = "buttonPass";
            buttonPass.Size = new Size(93, 49);
            buttonPass.TabIndex = 10;
            buttonPass.Text = "Пасс";
            buttonPass.UseVisualStyleBackColor = true;
            buttonPass.Visible = false;
            buttonPass.Click += buttonPass_Click;
            // 
            // buttonNext
            // 
            buttonNext.Enabled = false;
            buttonNext.Font = new Font("Tahoma", 18F, FontStyle.Regular, GraphicsUnit.Point);
            buttonNext.Location = new Point(339, 295);
            buttonNext.Name = "buttonNext";
            buttonNext.Size = new Size(93, 49);
            buttonNext.TabIndex = 9;
            buttonNext.Text = "Еще";
            buttonNext.UseVisualStyleBackColor = true;
            buttonNext.Visible = false;
            buttonNext.Click += buttonNext_Click;
            // 
            // panel1
            // 
            panel1.Location = new Point(49, 229);
            panel1.Name = "panel1";
            panel1.Size = new Size(120, 180);
            panel1.TabIndex = 18;
            panel1.Paint += panel_Paint;
            // 
            // panel2
            // 
            panel2.Location = new Point(302, 72);
            panel2.Name = "panel2";
            panel2.Size = new Size(322, 180);
            panel2.TabIndex = 19;
            panel2.Paint += panel2_Paint;
            // 
            // panel3
            // 
            panel3.Location = new Point(302, 417);
            panel3.Name = "panel3";
            panel3.Size = new Size(322, 180);
            panel3.TabIndex = 20;
            panel3.Paint += panel3_Paint;
            // 
            // labelName
            // 
            labelName.AutoSize = true;
            labelName.Font = new Font("Tahoma", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            labelName.Location = new Point(302, 390);
            labelName.Name = "labelName";
            labelName.Size = new Size(111, 23);
            labelName.TabIndex = 21;
            labelName.Text = "userName 0";
            // 
            // labelNameBot
            // 
            labelNameBot.AutoSize = true;
            labelNameBot.Font = new Font("Tahoma", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            labelNameBot.Location = new Point(302, 46);
            labelNameBot.Name = "labelNameBot";
            labelNameBot.Size = new Size(98, 23);
            labelNameBot.TabIndex = 22;
            labelNameBot.Text = "Машина 0";
            // 
            // buttonExit
            // 
            buttonExit.Font = new Font("Tahoma", 18F, FontStyle.Regular, GraphicsUnit.Point);
            buttonExit.Location = new Point(637, 3);
            buttonExit.Name = "buttonExit";
            buttonExit.Size = new Size(167, 49);
            buttonExit.TabIndex = 23;
            buttonExit.Text = "Закончить";
            buttonExit.UseVisualStyleBackColor = true;
            buttonExit.Visible = false;
            buttonExit.Click += buttonExit_Click;
            // 
            // buttonSTA
            // 
            buttonSTA.Font = new Font("Tahoma", 18F, FontStyle.Regular, GraphicsUnit.Point);
            buttonSTA.Location = new Point(398, 342);
            buttonSTA.Name = "buttonSTA";
            buttonSTA.Size = new Size(136, 49);
            buttonSTA.TabIndex = 25;
            buttonSTA.Text = "Готово";
            buttonSTA.UseVisualStyleBackColor = true;
            buttonSTA.Click += buttonSTA_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Tahoma", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(20, 509);
            label1.Name = "label1";
            label1.Size = new Size(76, 23);
            label1.TabIndex = 26;
            label1.Text = "Ставка:";
            label1.Visible = false;
            // 
            // labelEX2
            // 
            labelEX2.AutoSize = true;
            labelEX2.Font = new Font("Tahoma", 26.25F, FontStyle.Regular, GraphicsUnit.Point);
            labelEX2.Location = new Point(102, 493);
            labelEX2.Name = "labelEX2";
            labelEX2.Size = new Size(37, 42);
            labelEX2.TabIndex = 27;
            labelEX2.Text = "0";
            labelEX2.Visible = false;
            // 
            // labelLose
            // 
            labelLose.AutoSize = true;
            labelLose.Font = new Font("Tahoma", 27.75F, FontStyle.Regular, GraphicsUnit.Point);
            labelLose.ForeColor = Color.Red;
            labelLose.Location = new Point(20, 9);
            labelLose.Name = "labelLose";
            labelLose.Size = new Size(270, 45);
            labelLose.TabIndex = 28;
            labelLose.Text = "Вы проиграли!";
            labelLose.Visible = false;
            // 
            // labelWin
            // 
            labelWin.AutoSize = true;
            labelWin.Font = new Font("Tahoma", 27.75F, FontStyle.Regular, GraphicsUnit.Point);
            labelWin.ForeColor = Color.Lime;
            labelWin.Location = new Point(34, 9);
            labelWin.Name = "labelWin";
            labelWin.Size = new Size(256, 45);
            labelWin.TabIndex = 29;
            labelWin.Text = "Вы победили!";
            labelWin.Visible = false;
            // 
            // buttonRaund
            // 
            buttonRaund.Font = new Font("Tahoma", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            buttonRaund.Location = new Point(112, 57);
            buttonRaund.Name = "buttonRaund";
            buttonRaund.Size = new Size(75, 37);
            buttonRaund.TabIndex = 30;
            buttonRaund.Text = "OK";
            buttonRaund.UseVisualStyleBackColor = true;
            buttonRaund.Visible = false;
            buttonRaund.Click += buttonRaund_Click;
            // 
            // Game
            // 
            AutoScaleMode = AutoScaleMode.None;
            AutoSize = true;
            ClientSize = new Size(807, 604);
            Controls.Add(buttonRaund);
            Controls.Add(labelWin);
            Controls.Add(labelLose);
            Controls.Add(labelEX2);
            Controls.Add(label1);
            Controls.Add(buttonSTA);
            Controls.Add(buttonExit);
            Controls.Add(labelNameBot);
            Controls.Add(labelName);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(label2);
            Controls.Add(labelEX);
            Controls.Add(buttonPlus);
            Controls.Add(buttonMinus);
            Controls.Add(labelST2);
            Controls.Add(labelST);
            Controls.Add(buttonPass);
            Controls.Add(buttonNext);
            Name = "Game";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "21 очко";
            Load += Game_Load;
            Paint += Game_Paint;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private System.Windows.Forms.Timer reset_timer;
        private System.Windows.Forms.Timer sec_timer;
        private Label label2;
        private Label labelEX;
        private Button buttonPlus;
        private Button buttonMinus;
        private Label labelST2;
        private Label labelST;
        private Button button1;
        private Button buttonNext;
        private Panel panel1;
        private Panel panel2;
        private Panel panel3;
        private Label labelName;
        private Label labelNameBot;
        private Button buttonExit;
        private Button button2;
        private Button buttonSTA;
        private Label label1;
        private Label labelEX2;
        private Button buttonPass;
        private Label labelLose;
        private Label labelWin;
        private Button buttonRaund;
    }
}