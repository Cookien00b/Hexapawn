using System.Windows;

namespace Hexapawn
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        string wbTurn = "White";
        string pawnID = "None";
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
            blackPwnBottomLeft.Visibility = Visibility.Hidden;
            blackPwnMiddleLeft.Visibility = Visibility.Hidden;
            blackPwnBottomCenter.Visibility = Visibility.Hidden;
            blackPwnMiddleCenter.Visibility = Visibility.Hidden;
            blackPwnBottomRight.Visibility = Visibility.Hidden;
            blackPwnMiddleRight.Visibility = Visibility.Hidden;
            whitePwnTopLeft.Visibility = Visibility.Hidden;
            whitePwnTopCenter.Visibility = Visibility.Hidden;
            whitePwnTopRight.Visibility = Visibility.Hidden;
            whitePwnMiddleLeft.Visibility = Visibility.Hidden;
            whitePwnMiddleCenter.Visibility = Visibility.Hidden;
            whitePwnMiddleRight.Visibility = Visibility.Hidden;
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
            btnMoveMiddleLeft.Visibility = Visibility.Hidden;
            btnMoveMiddleCenter.Visibility = Visibility.Hidden;
            btnMoveMiddleRight.Visibility = Visibility.Hidden;
            btnMoveTopLeft.Visibility = Visibility.Hidden;
            btnMoveTopCenter.Visibility = Visibility.Hidden;
            btnMoveTopRight.Visibility = Visibility.Hidden;
            btnMoveBottomLeft.Visibility = Visibility.Hidden;
            btnMoveBottomCenter.Visibility = Visibility.Hidden;
            btnMoveBottomRight.Visibility = Visibility.Hidden;
        }

        private void BtnBottomLeft_Click(object sender, RoutedEventArgs e)
        {
            if (wbTurn == "White")
            {
                if (whiteBottomLeft == true)
                {
                    if (blackMiddleLeft == false)
                    {
                        moveDotMiddleLeft.Visibility = Visibility.Visible;
                        btnMiddleLeft.Visibility = Visibility.Visible;
                        btnMoveMiddleLeft.Visibility = Visibility.Visible;
                        pawnID = "WBL";
                    }
                }
            }
            else if (wbTurn == "Black")
            {

            }
            else
            {
                return;
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


        private void BtnMoveBottomLeft_Click(object sender, RoutedEventArgs e)
        {

        }

        private void BtnMoveMiddleLeft_Click(object sender, RoutedEventArgs e)
        {
            if (wbTurn == "White")
            {
                if (pawnID == "WBL")
                {
                    moveDotMiddleLeft.Visibility = Visibility.Hidden;
                    moveDotMiddleCenter.Visibility = Visibility.Hidden;
                    whitePwnBottomLeft.Visibility = Visibility.Hidden;
                    whitePwnMiddleLeft.Visibility = Visibility.Visible;
                    whiteBottomLeft = false;
                    whiteMiddleLeft = true;
                    wbTurn = "Black";
                }
            }
        }

        private void BtnMoveTopLeft_Click(object sender, RoutedEventArgs e)
        {

        }

        private void BtnMoveBottomCenter_Click(object sender, RoutedEventArgs e)
        {

        }

        private void BtnMoveMiddleCenter_Click(object sender, RoutedEventArgs e)
        {

        }

        private void BtnMoveTopCenter_Click(object sender, RoutedEventArgs e)
        {

        }

        private void BtnMoveTopRight_Click(object sender, RoutedEventArgs e)
        {

        }

        private void BtnMoveMiddleRight_Click(object sender, RoutedEventArgs e)
        {

        }

        private void BtnMoveBottomRight_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}

