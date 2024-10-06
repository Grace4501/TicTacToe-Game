namespace TicTacToe_Game
{
    public partial class Form1 : Form
    {

        public enum Player
        {
            X, O
        }
        Player currentPlayer;
        Random random = new Random();
        int playerWinCount = 0;
        int computerWinCount = 0;
        List<Button> buttons;
        public Form1()
        {
            InitializeComponent();
            RestartGame();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void CPUMove(object sender, EventArgs e)
        {
            if(buttons.Count > 0)
            {
                int index = random.Next(buttons.Count);
                buttons[index].Enabled = false;
                currentPlayer = Player.O;
                buttons[index].Text = currentPlayer.ToString();
                buttons[index].BackColor = Color.DarkSalmon;
                buttons.RemoveAt(index);
                CheckGame();
                EnableButtons();
                CPUTimer.Stop();
            }
        }

        private void PlayerClickButton(object sender, EventArgs e)
        {
            var button = (Button)sender;

            currentPlayer = Player.X;
            button.Text = currentPlayer.ToString();
            button.Enabled = false;
            button.BackColor = Color.Cyan;
            buttons.Remove(button);
            CheckGame();
            DisableButtons();
            CPUTimer.Start();
        }

        private void DisableButtons()
        {
            foreach (var button in buttons)
            {
                button.Enabled = false;
            }
        }

        private void EnableButtons()
        {
            foreach (var button in buttons)
            {
                button.Enabled = true;
            }
        }

        private void RestartGame(object sender, EventArgs e)
        {
            playerWinCount = 0;
            PlayerWinCount.Text = "Player Wins: " + playerWinCount;
            computerWinCount = 0;
            CPUWinCount.Text = "CPU Wins: " + computerWinCount;
            RestartGame();
        }

        private void CheckGame()
        {
            if ((button1.Text == "X" && button2.Text == "X" && button3.Text == "X") ||
                (button4.Text == "X" && button5.Text == "X" && button6.Text == "X") ||
                (button7.Text == "X" && button8.Text == "X" && button9.Text == "X") ||
                (button1.Text == "X" && button4.Text == "X" && button7.Text == "X") ||
                (button2.Text == "X" && button5.Text == "X" && button8.Text == "X") ||
                (button3.Text == "X" && button6.Text == "X" && button9.Text == "X") ||
                (button1.Text == "X" && button5.Text == "X" && button9.Text == "X") ||
                (button3.Text == "X" && button5.Text == "X" && button7.Text == "X"))
            {
                CPUTimer.Stop();
                MessageBox.Show("Player Wins");
                playerWinCount++;
                PlayerWinCount.Text = "Player Wins: " + playerWinCount;
                RestartGame();
                return;
            }
            else if ((button1.Text == "O" && button2.Text == "O" && button3.Text == "O") ||
                     (button4.Text == "O" && button5.Text == "O" && button6.Text == "O") ||
                     (button7.Text == "O" && button8.Text == "O" && button9.Text == "O") ||
                     (button1.Text == "O" && button4.Text == "O" && button7.Text == "O") ||
                     (button2.Text == "O" && button5.Text == "O" && button8.Text == "O") ||
                     (button3.Text == "O" && button6.Text == "O" && button9.Text == "O") |
                     (button1.Text == "O" && button5.Text == "O" && button9.Text == "O") ||
                     (button3.Text == "O" && button5.Text == "O" && button7.Text == "O"))
            {
                CPUTimer.Stop();
                MessageBox.Show("Computer Wins");
                computerWinCount++;
                CPUWinCount.Text = "CPU Wins: " + computerWinCount;
                RestartGame();
                return;
            }

            if (buttons.Count == 0)
            {
                MessageBox.Show("It's a draw!");
                RestartGame();
            }
        }


        private void RestartGame()
        {
            buttons = new List<Button> { button1, button2, button3, button6, button5, button4, button9, button8, button7 };

            foreach (Button x in buttons)
            {
                x.Enabled = true;
                x.Text = "?";
                x.BackColor = DefaultBackColor;
            }
        }
    }
}
