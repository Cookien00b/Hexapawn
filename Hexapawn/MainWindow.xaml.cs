using System.Windows;

namespace Hexapawn
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        string wbTurn = "White";
        bool whiteBottomLeft = true;
        bool whiteBottomCenter = true;
        bool whiteBottomRight = true;
        bool whiteMiddleLeft = false;
        bool whiteMiddleCenter = false;
        bool whiteMiddleRight = false;
        bool whiteTopLeft = false;
        bool whiteTopCenter = false;
        bool whiteTopRight = false;

        bool blackBottomLeft = false;
        bool blackBottomCenter = false;
        bool blackBottomRight = false;
        bool blackMiddleLeft = false;
        bool blackMiddleCenter = false;
        bool blackMiddleRight = false;
        bool blackTopLeft = true;
        bool blackTopCenter = true;
        bool blackTopRight = true;
        public MainWindow()
        {
            InitializeComponent();
            hideBlackPawnBottomLeft();
            hideBlackPawnMiddleLeft();
            hideBlackPwnBottomCenter();
            hideBlackPwnBottomRight();
            hideBlackPwnMiddleCenter();
            hideBlackPwnMiddleRight();
            hideWhitePawnTopLeft();
            hideWhitePwnTopCenter();
            hideWhitePwnTopRight();
            hideWhitePawnMiddleLeft();
            hideWhitePwnMiddleCenter();
            hideWhitePwnMiddleRight();
            btnMiddleLeft.Visibility = Visibility.Hidden;
            btnMiddleCenter.Visibility = Visibility.Hidden;
            btnMiddleRight.Visibility = Visibility.Hidden;
            moveDotBottomLeft.Visibility = Visibility.Hidden;
            moveDotBottomCenter.Visibility = Visibility.Hidden;
            moveDotBottomRight.Visibility = Visibility.Hidden;
            moveDotMiddleLeft.Visibility = Visibility.Hidden;
            moveDotMiddleCenter.Visibility = Visibility.Hidden;
            moveDotMiddleRight.Visibility = Visibility.Hidden;
            moveDotTopLeft.Visibility = Visibility.Hidden;
            moveDotTopCenter.Visibility = Visibility.Hidden;
            moveDotTopRight.Visibility = Visibility.Hidden;
        }
        private void hideBlackPawnTopLeft()
        {
            blackPwnTopLeft.Visibility = Visibility.Hidden;
        }
        private void showBlackPawnTopLeft()
        {
            blackPwnTopLeft.Visibility = Visibility.Visible;
        }

        private void hideBlackPawnMiddleLeft()
        {
            blackPwnMiddleLeft.Visibility = Visibility.Hidden;
        }
        private void showBlackPawnMiddleLeft()
        {
            blackPwnMiddleLeft.Visibility = Visibility.Visible;
        }

        private void hideBlackPawnBottomLeft()
        {
            blackPwnBottomLeft.Visibility = Visibility.Hidden;
        }
        private void showBlackPawnBottomLeft()
        {
            blackPwnBottomLeft.Visibility = Visibility.Visible;
        }

        private void hideBlackPwnTopCenter()
        {
            blackPwnTopCenter.Visibility = Visibility.Hidden;
        }
        private void showBlackPwnTopCenter()
        {
            blackPwnTopCenter.Visibility = Visibility.Visible;
        }

        private void hideBlackPwnMiddleCenter()
        {
            blackPwnMiddleCenter.Visibility = Visibility.Hidden;
        }

        private void showBlackPwnMiddleCenter()
        {
            blackPwnMiddleCenter.Visibility = Visibility.Visible;
        }

        private void hideBlackPwnBottomCenter()
        {
            blackPwnBottomCenter.Visibility = Visibility.Hidden;
        }
        private void showBlackPwnBottomCenter()
        {
            blackPwnBottomCenter.Visibility = Visibility.Visible;
        }

        private void hideBlackPwnTopRight()
        {
            blackPwnTopRight.Visibility = Visibility.Hidden;
        }
        private void showBlackPwnTopRight()
        {
            blackPwnTopRight.Visibility = Visibility.Visible;
        }

        private void hideBlackPwnMiddleRight()
        {
            blackPwnMiddleRight.Visibility = Visibility.Hidden;
        }
        private void showBlackPwnMiddleRight()
        {
            blackPwnMiddleRight.Visibility = Visibility.Visible;
        }

        private void hideBlackPwnBottomRight()
        {
            blackPwnBottomRight.Visibility = Visibility.Hidden;
        }
        private void showBlackPwnBottomRight()
        {
            blackPwnBottomRight.Visibility = Visibility.Visible;
        }




        private void hideWhitePawnTopLeft()
        {
            whitePwnTopLeft.Visibility = Visibility.Hidden;
        }
        private void showWhitePawnTopLeft()
        {
            whitePwnTopLeft.Visibility = Visibility.Visible;
        }

        private void hideWhitePawnMiddleLeft()
        {
            whitePwnMiddleLeft.Visibility = Visibility.Hidden;
        }
        private void showWhitePawnMiddleLeft()
        {
            whitePwnMiddleLeft.Visibility = Visibility.Visible;
        }

        private void hideWhitePawnBottomLeft()
        {
            whitePwnBottomLeft.Visibility = Visibility.Hidden;
        }
        private void showWhitePawnBottomLeft()
        {
            whitePwnBottomLeft.Visibility = Visibility.Visible;
        }

        private void hideWhitePwnTopCenter()
        {
            whitePwnTopCenter.Visibility = Visibility.Hidden;
        }
        private void showWhitePwnTopCenter()
        {
            whitePwnTopCenter.Visibility = Visibility.Visible;
        }

        private void hideWhitePwnMiddleCenter()
        {
            whitePwnMiddleCenter.Visibility = Visibility.Hidden;
        }

        private void showWhitePwnMiddleCenter()
        {
            whitePwnMiddleCenter.Visibility = Visibility.Visible;
        }

        private void hideWhitePwnBottomCenter()
        {
            whitePwnBottomCenter.Visibility = Visibility.Hidden;
        }
        private void showWhitePwnBottomCenter()
        {
            whitePwnBottomCenter.Visibility = Visibility.Visible;
        }

        private void hideWhitePwnTopRight()
        {
            whitePwnTopRight.Visibility = Visibility.Hidden;
        }
        private void showWhitePwnTopRight()
        {
            whitePwnTopRight.Visibility = Visibility.Visible;
        }

        private void hideWhitePwnMiddleRight()
        {
            whitePwnMiddleRight.Visibility = Visibility.Hidden;
        }
        private void showWhitePwnMiddleRight()
        {
            whitePwnMiddleRight.Visibility = Visibility.Visible;
        }

        private void hideWhitePwnBottomRight()
        {
            whitePwnBottomRight.Visibility = Visibility.Hidden;
        }
        private void showWhitePwnBottomRight()
        {
            whitePwnBottomRight.Visibility = Visibility.Visible;
        }

        private void BtnBottomLeft_Click(object sender, RoutedEventArgs e)
        {
            if (whiteBottomLeft == true)
            {
                if (blackMiddleLeft == false)
                {
                    moveDotMiddleLeft.Visibility = Visibility.Visible;
                    btnMiddleLeft.Visibility = Visibility.Visible;
                }
            }
        }

        private void BtnMiddleLeft_Click(object sender, RoutedEventArgs e)
        {

        }

        private void BtnTopLeft_Click(object sender, RoutedEventArgs e)
        {

        }

        private void BtnBottomCenter_Click(object sender, RoutedEventArgs e)
        {

        }

        private void BtnMiddleCenter_Click(object sender, RoutedEventArgs e)
        {

        }

        private void BtnTopCenter_Click(object sender, RoutedEventArgs e)
        {

        }

        private void BtnTopRight_Click(object sender, RoutedEventArgs e)
        {

        }

        private void BtnMiddleRight_Click(object sender, RoutedEventArgs e)
        {

        }

        private void BtnBottomRight_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}