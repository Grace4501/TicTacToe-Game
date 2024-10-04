namespace TicTacToe_Game
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
            PlayerWinCount = new Label();
            CPUWinCount = new Label();
            SuspendLayout();
            // 
            // PlayerWinCount
            // 
            PlayerWinCount.AutoSize = true;
            PlayerWinCount.Font = new Font("Summer Dream Sans Demo", 10.2F, FontStyle.Italic, GraphicsUnit.Point, 0);
            PlayerWinCount.ForeColor = Color.LimeGreen;
            PlayerWinCount.Location = new Point(54, 138);
            PlayerWinCount.Name = "PlayerWinCount";
            PlayerWinCount.Size = new Size(138, 26);
            PlayerWinCount.TabIndex = 0;
            PlayerWinCount.Text = "Player Win:";
            // 
            // CPUWinCount
            // 
            CPUWinCount.AutoSize = true;
            CPUWinCount.Font = new Font("Summer Dream Sans Demo", 10.8F, FontStyle.Italic, GraphicsUnit.Point, 0);
            CPUWinCount.ForeColor = Color.Red;
            CPUWinCount.Location = new Point(492, 137);
            CPUWinCount.Name = "CPUWinCount";
            CPUWinCount.Size = new Size(104, 27);
            CPUWinCount.TabIndex = 1;
            CPUWinCount.Text = "CPU Win:";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(675, 732);
            Controls.Add(CPUWinCount);
            Controls.Add(PlayerWinCount);
            Name = "Form1";
            Text = "Tic Tac Toe";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label PlayerWinCount;
        private Label CPUWinCount;
    }
}
