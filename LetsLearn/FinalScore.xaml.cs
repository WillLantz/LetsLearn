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

namespace LetsLearn
{

    /// <summary>
    /// Interaction logic for FinalScore.xaml
    /// </summary>
    public partial class FinalScore : Window
    {

        public User userCLS;
        public Game gameCLS;

        public FinalScore(User currUser, Game currGame)
        {
            InitializeComponent();

            //Constructing the user class that was created in main window
            userCLS = currUser;

            //Constructing the game class that was created in the main window
            gameCLS = currGame;

            fUserLbl.Content = userCLS.userName;
            fUserAgeLbl.Content = userCLS.userAge;
            fCAnsLbl.Content = gameCLS.correctCount;
            fIncAnsLbl.Content = gameCLS.incorrectCount;
            fCompTimeLbl.Content = gameCLS.finalTime;
            fSImage.Opacity = 100;

            
            if (gameCLS.correctCount >= 8)
            {
                fSImage.Source = new BitmapImage(new Uri(@"Images/greatjob.jpg", UriKind.Relative));
            }
            else if(gameCLS.correctCount <= 7 && gameCLS.correctCount >= 5)
            {
                fSImage.Source = new BitmapImage(new Uri(@"Images/doit.jpg", UriKind.Relative));
            }
            else
            {
                fSImage.Source = new BitmapImage(new Uri(@"Images/nicetry.png", UriKind.Relative));
            }

        }

        private void updateImg(BitmapImage bmpImg)
        {
            fSImage.Source = bmpImg;
        }

        /// <summary>
        /// Back to home page to play again
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
