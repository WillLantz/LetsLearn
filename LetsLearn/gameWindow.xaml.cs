using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using System.Windows.Threading;
using System.Threading;
using System.Diagnostics;

namespace LetsLearn
{
    /// <summary>
    /// Interaction logic for gameWindow.xaml
    /// </summary>
    public partial class gameWindow : Window
    {
        User userCLS;
        Game gameCLS;

        DispatcherTimer MyTimer;


        public gameWindow(User currUser, Game currGame)
        {
            InitializeComponent();

            //Constructing the user class that was created in main window
            userCLS = currUser;

            //Constructing the game class that was created in the main window
            gameCLS = currGame;

            //Instantiate the DispatcherTimer
            MyTimer = new DispatcherTimer();
            //Make the timer go off every second
            MyTimer.Interval = new TimeSpan(0, 0, 0);
            //Tell it which method will handle the click event
            MyTimer.Tick += new EventHandler(MyTimer_Tick);


            // Hiding the game input options
            gameQAnsBox.Visibility = Visibility.Hidden;
            gameQBG.Visibility = Visibility.Hidden;
            gameQLbl.Visibility = Visibility.Hidden;
            gameQSubmitBtn.Visibility = Visibility.Hidden;
            alertBG.Visibility = Visibility.Hidden;
            alertLbl.Visibility = Visibility.Hidden;

        }

        /// <summary>
        /// Restrict user input
        /// They can press enter or submit to submit their answers
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtInput_PreviewKeyDown(object sender, KeyEventArgs e)
        {
            //Only allow numbers to be entered
            if (!((e.Key >= Key.D0 && e.Key <= Key.D9) ||
                  e.Key >= Key.NumPad0 && e.Key <= Key.NumPad9))
            {
                //Allow the user to use the backspace and delete keys
                if (!(e.Key == Key.Back || e.Key == Key.Delete))
                {
                    //No other keys allowed besides numbers, backspace, and delete
                    e.Handled = true;
                    infoDump(); // calling info dump function
                } // end enter btn nest
            }
        }

        #region var Init

        /// <summary>
        /// The number the user enters
        /// </summary>
        public int userAns;

        /// <summary>
        /// Keep track of times played
        /// </summary>
        public int playCount = 0;

        /// <summary>
        /// Keeping track of when the time starts
        /// </summary>
        private DateTime startT;

        /// <summary>
        /// Keeping track of how much time has elapsed
        /// </summary>
        public string elapsedT;


        #endregion var Init

        /// <summary>
        /// This method closed the game window and goes back to the main window
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        /// <summary>
        /// Begins the game generation
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void strtGameBtn_Click(object sender, RoutedEventArgs e)
        {
            // Hiding the start game options
            startGameLbl.Visibility = Visibility.Hidden;
            startGameBG.Visibility = Visibility.Hidden;
            strtGameBtn.Visibility = Visibility.Hidden;

            // Enabling the game input options
            gameQAnsBox.Visibility = Visibility.Visible;
            gameQBG.Visibility = Visibility.Visible;
            gameQLbl.Visibility = Visibility.Visible;
            gameQSubmitBtn.Visibility = Visibility.Visible;
            alertBG.Visibility = Visibility.Visible;
            alertLbl.Visibility = Visibility.Visible;


            startT = DateTime.Now;
            MyTimer.Start();

            gameGen();
        }

        /// <summary>
        /// Calls to the game class for game generation
        /// </summary>
        private void gameGen()
        {

            if(gameCLS.gameType == 1)
            {
                gameCLS.mathAdd();
                gameQLbl.Content = $"{gameCLS.oper1} + {gameCLS.oper2} = "; // calling to mathAdd in Game class
            }
            else if (gameCLS.gameType == 2)
            {
                gameCLS.mathSubtract();
                gameQLbl.Content = $"{gameCLS.oper1} - {gameCLS.oper2} = "; 

            }
            else if (gameCLS.gameType == 3)
            {
                gameCLS.mathMultiply();
                gameQLbl.Content = $"{gameCLS.oper1} * {gameCLS.oper2} = ";

            }
            else if (gameCLS.gameType == 4)
            {
                gameCLS.mathDivide();
                gameQLbl.Content = $"{gameCLS.oper1} / {gameCLS.oper2} = ";

            }

            // (r1 * r2) / r1 == r2

        }

        /// <summary>
        /// Handles the submit button click
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void gameQSubmitBtn_Click(object sender, RoutedEventArgs e)
        {
            infoDump();
        } // end gameQSubmintBtn_click



        /// <summary>
        /// Timer tick
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void MyTimer_Tick(object sender, EventArgs e)
        {
            alertLbl.Content = (DateTime.Now - startT).ToString(@"hh\:mm\:ss");
        }

        /// <summary>
        /// Sets the elapsed time for the game
        /// </summary>
        void setT()
        {
            elapsedT = (DateTime.Now - startT).ToString(@"hh\:mm\:ss");
            gameCLS.setTime(elapsedT);
        }

        /// <summary>
        /// All of the information that is submitted on submit click / enter is sent here
        /// </summary>
        public void infoDump()
        {
            if (playCount == 9)
            {
                try
                {
                    userAns = (Int32.Parse(gameQAnsBox.Text));
                }
                catch (Exception)
                {
                    ansErrorLbl.Content = "Must enter a number";
                    return;
                }

                ansErrorLbl.Content = "";



                gameCLS.checkMath(userAns);
                setT();
                FinalScore fs = new FinalScore(userCLS, gameCLS);
                MyTimer.Stop();





                this.Hide();
                fs.ShowDialog();
                this.Close();
            }
            else
            {

                try
                {
                    userAns = (Int32.Parse(gameQAnsBox.Text));
                }
                catch (Exception)
                {
                    ansErrorLbl.Content = "Must enter a number";
                    return;
                }

                ansErrorLbl.Content = "";



                gameCLS.checkMath(userAns);

                if (gameCLS.correctAnswer)
                {
                    ansLbl.Content = "CORRECT";
                }
                else
                {
                    ansLbl.Content = "INCORRECT";
                }


                gameQAnsBox.Text = "";

                playCount++;
                gameGen();
            }

        }


    }
}

