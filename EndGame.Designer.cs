namespace Soliter
{
    partial class EndGame
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
            buttonOK = new Button();
            label1 = new Label();
            labelName = new Label();
            SuspendLayout();
            // 
            // buttonOK
            // 
            buttonOK.Font = new Font("Times New Roman", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            buttonOK.Location = new Point(190, 8);
            buttonOK.Name = "buttonOK";
            buttonOK.Size = new Size(68, 38);
            buttonOK.TabIndex = 0;
            buttonOK.Text = "OK";
            buttonOK.UseVisualStyleBackColor = true;
            buttonOK.Click += buttonOK_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(86, 13);
            label1.TabIndex = 1;
            label1.Text = "Поздравляем!!!";
            // 
            // labelName
            // 
            labelName.AutoSize = true;
            labelName.Location = new Point(12, 33);
            labelName.Name = "labelName";
            labelName.Size = new Size(35, 13);
            labelName.TabIndex = 2;
            labelName.Text = "NAME";
            // 
            // EndGame
            // 
            AutoScaleDimensions = new SizeF(6F, 13F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(270, 53);
            Controls.Add(labelName);
            Controls.Add(label1);
            Controls.Add(buttonOK);
            Name = "EndGame";
            Text = "EndGame";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonOK;
        private Label label1;
        private Label labelName;
    }
}