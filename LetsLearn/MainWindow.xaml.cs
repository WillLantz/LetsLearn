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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace LetsLearn
{
    
    
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        /// <summary>
        /// User class constructor
        /// </summary>
        User userCLS;

        /// <summary>
        /// Game clase constructor
        /// </summary>
        Game gameCLS;

        public MainWindow()
        {
            InitializeComponent();

            Application.Current.ShutdownMode = ShutdownMode.OnMainWindowClose; // Closes program when main window is closed

            mathErrorBG.Visibility = Visibility.Hidden;

            userCLS = new User();
            gameCLS = new Game();
        }

        #region var Init

        /// <summary>
        /// Keeps track of what operation the user wants
        /// 1 = addition, 2 = subtraction, 3 = mult, 4 = div
        /// </summary>
        public int opChoice;
        
        /// <summary>
        /// uName stores user name
        /// </summary>
        public string uName;

        /// <summary>
        /// uAge stores user age
        /// </summary>
        public int uAge;

        #endregion var Init

        /// <summary>
        /// Takes all of the data that the user submits and sends it to
        /// the correct classes to be evaluated
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void launchBtn_Click(object sender, RoutedEventArgs e)
        {
            #region userVal
            if (nameTextBox.Text == "") // if user didn't input a name, ask them to do it
            {
                nameErrorLbl.Content = "Please enter your name";
                return;
            }
            else // assing the submitted name to uName and send it to user class
            {
                uName = nameTextBox.Text;
            }

            nameErrorLbl.Content = ""; 

            try
            {
                uAge = (Int32.Parse(ageTextBox.Text));
            }
            catch (Exception)
            {
                ageErrorLbl.Content = "Must enter a number (3-10)";
                return;
            }

            if(uAge < 3 || uAge > 10)
            {
                ageErrorLbl.Content = "Must enter a number (3-10)";
                return; 
            }

            ageErrorLbl.Content = "";
            #endregion userVal

            #region math Choices 
            if(additionBtn.IsChecked == true)
            {
                opChoice = 1;
            }
            else if(subtractBtn.IsChecked == true)
            {
                opChoice = 2;
            }
            else if(multiplicationBtn.IsChecked == true)
            {
                opChoice = 3;
            }
            else if(divisionBtn.IsChecked == true)
            {
                opChoice = 4;
            }
            else
            {

                mathErrorLbl.Content = "Must choose one math operation.";
                mathErrorBG.Visibility = Visibility.Visible;
                return;
            }

            #endregion mathChoices


            // send all bool values in an array to the Game class
            // clear the math error label, math error BG

            mathErrorLbl.Content = "";
            mathErrorBG.Visibility = Visibility.Hidden;

            gameWindow gW = new gameWindow(userCLS, gameCLS);
           
            userCLS.userName = uName; // Sending the name to be stored. 

            userCLS.userAge = uAge; // Sending the age to be stored

            //userCLS.age(uAge); // Sending the age to be stored
            gameCLS.gameType = opChoice;

            this.Hide();
            gW.ShowDialog();
            userCLS = new User();
            gameCLS = new Game();
            this.Show();
            
        } // end launchBtn


    }
    
}
