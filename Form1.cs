using System;
using System.Windows.Forms;

namespace Prodigy_SD_02
{
    public partial class Form1 : Form
    {
        private int guessNumber;
        private int attemptsCounter;

        public Form1()
        {
            InitializeComponent();
            InitializeGame();

            // Subscribe to KeyDown event for numbersTextBox
            numbersTextBox.KeyDown += numbersTextBox_KeyDown;
        }

        private void InitializeGame()
        {
            // Initialize random seed
            Random rand = new Random();

            // Generates the random number between 1 and 100
            guessNumber = rand.Next(1, 101);
            attemptsCounter = 0;

            titleLabel.Text = "Guess the number (1 to 100):";
            counterLabel.Text = "0";
            helperLabel.Text = "";
            attemptsLabel.Text = "Attempts";

            confirmButton.Enabled = true;  // Ensure confirm button is enabled when the game is initialized
            numbersTextBox.Text = "";      // Clear the input box
        }

        private void confirmButton_Click(object sender, EventArgs e)
        {
            if (int.TryParse(numbersTextBox.Text, out int userGuess))
            {
                if (userGuess < 1 || userGuess > 100)//it locks to user's not entering a wrong number out of <1 or >100
                {
                    MessageBox.Show("Please enter a number between 1 and 100.");
                    return;
                }

                attemptsCounter++;

                if (userGuess == guessNumber) //function if the user's number matches the random number, user wins.
                {
                    helperLabel.Text = "Congratulations! You guessed the number!";
                    confirmButton.Enabled = false;
                }
                else if (userGuess > guessNumber)
                {
                    helperLabel.Text = "Number is too high";
                }
                else
                {
                    helperLabel.Text = "Number is too low";
                }

                counterLabel.Text = attemptsCounter.ToString();
                numbersTextBox.Text = ""; // Clear the input for the next guess
            }
            else
            {
                MessageBox.Show("Please enter a valid number.");
            }
        }

        private void numbersTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true; // Prevents the 'ding' sound once enter is pressed
                confirmButton_Click(sender, e);
            }
        }

        private void resetButton_Click(object sender, EventArgs e)//to reset the game whenever needed by clicking the reset button
        {
            InitializeGame();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Initialize the game when the form loads
            InitializeGame();
        }
    }
}

