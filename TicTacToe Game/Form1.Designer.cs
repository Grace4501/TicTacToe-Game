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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            PlayerWinCount = new Label();
            CPUWinCount = new Label();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button6 = new Button();
            button5 = new Button();
            button4 = new Button();
            button9 = new Button();
            button8 = new Button();
            button7 = new Button();
            button10 = new Button();
            button11 = new Button();
            RestartGameBtn = new Button();
            CPUTimer = new System.Windows.Forms.Timer(components);
            SuspendLayout();
            // 
            // PlayerWinCount
            // 
            PlayerWinCount.AutoSize = true;
            PlayerWinCount.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Italic, GraphicsUnit.Point, 0);
            PlayerWinCount.ForeColor = Color.LimeGreen;
            PlayerWinCount.Location = new Point(69, 148);
            PlayerWinCount.Name = "PlayerWinCount";
            PlayerWinCount.Size = new Size(104, 20);
            PlayerWinCount.TabIndex = 0;
            PlayerWinCount.Text = "Player Wins:";
            // 
            // CPUWinCount
            // 
            CPUWinCount.AutoSize = true;
            CPUWinCount.Font = new Font("Microsoft Sans Serif", 10.8F, FontStyle.Italic, GraphicsUnit.Point, 0);
            CPUWinCount.ForeColor = Color.Red;
            CPUWinCount.Location = new Point(507, 147);
            CPUWinCount.Name = "CPUWinCount";
            CPUWinCount.Size = new Size(98, 22);
            CPUWinCount.TabIndex = 1;
            CPUWinCount.Text = "CPU Wins:";
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.Location = new Point(130, 189);
            button1.Name = "button1";
            button1.Size = new Size(139, 132);
            button1.TabIndex = 2;
            button1.Text = "?";
            button1.UseVisualStyleBackColor = true;
            button1.Click += PlayerClickButton;
            // 
            // button2
            // 
            button2.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.Location = new Point(275, 189);
            button2.Name = "button2";
            button2.Size = new Size(139, 132);
            button2.TabIndex = 3;
            button2.Text = "?";
            button2.UseVisualStyleBackColor = true;
            button2.Click += PlayerClickButton;
            // 
            // button3
            // 
            button3.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button3.Location = new Point(420, 189);
            button3.Name = "button3";
            button3.Size = new Size(139, 132);
            button3.TabIndex = 4;
            button3.Text = "?";
            button3.UseVisualStyleBackColor = true;
            button3.Click += PlayerClickButton;
            // 
            // button6
            // 
            button6.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button6.Location = new Point(420, 327);
            button6.Name = "button6";
            button6.Size = new Size(139, 132);
            button6.TabIndex = 7;
            button6.Text = "?";
            button6.UseVisualStyleBackColor = true;
            button6.Click += PlayerClickButton;
            // 
            // button5
            // 
            button5.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button5.Location = new Point(275, 327);
            button5.Name = "button5";
            button5.Size = new Size(139, 132);
            button5.TabIndex = 6;
            button5.Text = "?";
            button5.UseVisualStyleBackColor = true;
            button5.Click += PlayerClickButton;
            // 
            // button4
            // 
            button4.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button4.Location = new Point(130, 327);
            button4.Name = "button4";
            button4.Size = new Size(139, 132);
            button4.TabIndex = 5;
            button4.Text = "?";
            button4.UseVisualStyleBackColor = true;
            button4.Click += PlayerClickButton;
            // 
            // button9
            // 
            button9.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button9.Location = new Point(419, 465);
            button9.Name = "button9";
            button9.Size = new Size(139, 132);
            button9.TabIndex = 10;
            button9.Text = "?";
            button9.UseVisualStyleBackColor = true;
            button9.Click += PlayerClickButton;
            // 
            // button8
            // 
            button8.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button8.Location = new Point(275, 465);
            button8.Name = "button8";
            button8.Size = new Size(139, 132);
            button8.TabIndex = 9;
            button8.Text = "?";
            button8.UseVisualStyleBackColor = true;
            button8.Click += PlayerClickButton;
            // 
            // button7
            // 
            button7.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button7.Location = new Point(130, 465);
            button7.Name = "button7";
            button7.Size = new Size(139, 132);
            button7.TabIndex = 8;
            button7.Text = "?";
            button7.UseVisualStyleBackColor = true;
            button7.Click += PlayerClickButton;
            // 
            // button10
            // 
            button10.BackgroundImage = (Image)resources.GetObject("button10.BackgroundImage");
            button10.BackgroundImageLayout = ImageLayout.Stretch;
            button10.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button10.Location = new Point(484, 12);
            button10.Name = "button10";
            button10.Size = new Size(139, 132);
            button10.TabIndex = 11;
            button10.UseVisualStyleBackColor = true;
            // 
            // button11
            // 
            button11.BackgroundImage = (Image)resources.GetObject("button11.BackgroundImage");
            button11.BackgroundImageLayout = ImageLayout.Stretch;
            button11.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button11.Location = new Point(69, 13);
            button11.Name = "button11";
            button11.Size = new Size(139, 132);
            button11.TabIndex = 12;
            button11.UseVisualStyleBackColor = true;
            // 
            // RestartGameBtn
            // 
            RestartGameBtn.BackColor = Color.Blue;
            RestartGameBtn.FlatStyle = FlatStyle.System;
            RestartGameBtn.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            RestartGameBtn.ForeColor = SystemColors.ControlText;
            RestartGameBtn.Location = new Point(275, 612);
            RestartGameBtn.Name = "RestartGameBtn";
            RestartGameBtn.Size = new Size(139, 53);
            RestartGameBtn.TabIndex = 13;
            RestartGameBtn.Text = "Restart Game";
            RestartGameBtn.UseVisualStyleBackColor = false;
            RestartGameBtn.Click += RestartGame;
            // 
            // CPUTimer
            // 
            CPUTimer.Interval = 1000;
            CPUTimer.Tick += CPUMove;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(675, 732);
            Controls.Add(RestartGameBtn);
            Controls.Add(button11);
            Controls.Add(button10);
            Controls.Add(button9);
            Controls.Add(button8);
            Controls.Add(button7);
            Controls.Add(button6);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(CPUWinCount);
            Controls.Add(PlayerWinCount);
            Name = "Form1";
            Text = "Tic Tac Toe";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label PlayerWinCount;
        private Label CPUWinCount;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button6;
        private Button button5;
        private Button button4;
        private Button button9;
        private Button button8;
        private Button button7;
        private Button button10;
        private Button button11;
        private Button RestartGameBtn;
        private System.Windows.Forms.Timer CPUTimer;
    }
}
