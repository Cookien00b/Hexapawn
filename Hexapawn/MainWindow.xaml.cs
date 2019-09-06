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
        bool moveAvailable = false;
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
            hideAllMoves();
        }

        private void hideAllMoves()
        {
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

        //hideAllMoves();
        //    if (pawnID == "WCURRENT")
        //    {
        //        pawnID = "None";
        //    }
        //    else if (pawnID == "BCURRENT") 
        //    {
        //    
        //    }
        //    else if (pawnID == "None")
        //    {

        //        if (wbTurn == "White")
        //        {
        //            pawnID = "WCURRENT";
        //            if (whiteCURRENT == true)
        //            {
        //                if (blackINFRONT == false)
        //                {
        //                    moveDotINFRONT.Visibility = Visibility.Visible;
        //                    btnMoveINFRONT.Visibility = Visibility.Visible;
        //                    moveAvailable = true;
        //                }
        //                if (blackDIAGNALLEFT == true)
        //                {
        //                    moveDotDIAGNALLEFT.Visibility = Visibility.Visible;
        //                    btnMoveDIAGNALLEFT.Visibility = Visibility.Visible;
        //                    moveAvailable = true;
        //                }
        //                if (blackDIAGNALRIGHT == true)
        //                {
        //                    moveDotDIAGNALRIGHT.Visibility = Visibility.Visible;
        //                    btnMoveDIAGNALRIGHT.Visibility = Visibility.Visible;
        //                    moveAvailable = true;
        //                }
        //            }
        //        }
        //        else if (wbTurn == "Black")
        //        {
        //            pawnID = "BCURRENT";
        //            if (blackCURRENT == true)
        //            {
        //                if (whiteINFRONT == false)
        //                {
        //                    moveDotINFRONT.Visibility = Visibility.Visible;
        //                    btnMoveINFRONT.Visibility = Visibility.Visible;
        //                    moveAvailable = true;
        //                }
        //                if (whiteDIAGNALLEFT == true)
        //                {
        //                    moveDotDIAGNALLEFT.Visibility = Visibility.Visible;
        //                    btnMoveDIAGNALLEFT.Visibility = Visibility.Visible;
        //                    moveAvailable = true;
        //                }
        //                if (whiteDIAGNALRIGHT == true)
        //                {
        //                    moveDotDIAGNALRIGHT.Visibility = Visibility.Visible;
        //                    btnMoveDIAGNALRIGHT.Visibility = Visibility.Visible;
        //                    moveAvailable = true;
        //                }
        //            }
        //        }
        //        else
        //        {
        //            return;
        //        }
        //    }
        //    else
        //    {

        //    }

        private void BtnBottomLeft_Click(object sender, RoutedEventArgs e)
        {
            hideAllMoves();
            if (pawnID == "WBL")
            {
                pawnID = "None";
            }
            else if (pawnID == "BBL")
            {
                pawnID = "None";
            }
            else if (pawnID == "None")
            {
                
                if (wbTurn == "White" && whiteBottomLeft == true)
                {
                    pawnID = "WBL";
                    if (blackMiddleLeft == false)
                    {
                            moveDotMiddleLeft.Visibility = Visibility.Visible;
                            btnMoveMiddleLeft.Visibility = Visibility.Visible;
                        moveAvailable = true;
                    }
                    if (blackMiddleCenter == true)
                    {
                            moveDotMiddleCenter.Visibility = Visibility.Visible;
                            btnMoveMiddleCenter.Visibility = Visibility.Visible;
                            moveAvailable = true;
                    }
                }
                else if (wbTurn == "Black" && blackBottomLeft == true)
                {
                    pawnID = "BBL";
                }
                else
                {
                    return;
                }
            }
            else
            {

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
            hideAllMoves();
            if (pawnID == "WTC")
            {
                pawnID = "None";
            }
            else if (pawnID == "BTC")
            {
                pawnID = "None";
            }
            else if (pawnID == "None")
            {

                if (wbTurn == "White" && whiteTopCenter == true)
                {
                    pawnID = "WTC";
                }
                else if (wbTurn == "Black")
                {
                    pawnID = "BTC";
                    if (blackTopCenter == true)
                    {
                        if (whiteMiddleCenter == false)
                        {
                            moveDotMiddleCenter.Visibility = Visibility.Visible;
                            btnMoveMiddleCenter.Visibility = Visibility.Visible;
                            moveAvailable = true;
                        }
                        if (whiteMiddleLeft == true)
                        {
                            moveDotMiddleLeft.Visibility = Visibility.Visible;
                            btnMoveMiddleLeft.Visibility = Visibility.Visible;
                            moveAvailable = true;
                        }
                        if (whiteMiddleRight == true)
                        {
                            moveDotMiddleRight.Visibility = Visibility.Visible;
                            btnMoveMiddleRight.Visibility = Visibility.Visible;
                            moveAvailable = true;
                        }
                    }
                }
                else
                {
                    return;
                }
            }
            else
            {

            }

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
                    hideAllMoves();
                    whitePwnBottomLeft.Visibility = Visibility.Hidden;
                    whitePwnMiddleLeft.Visibility = Visibility.Visible;
                    whiteBottomLeft = false;
                    whiteMiddleLeft = true;
                    wbTurn = "Black";
                    pawnID = "None";
                }
                else if (pawnID == "WBC")
                {
                    hideAllMoves();
                    whitePwnBottomCenter.Visibility = Visibility.Hidden;
                    blackPwnMiddleLeft.Visibility = Visibility.Hidden;
                    whitePwnMiddleLeft.Visibility = Visibility.Visible;
                    whiteBottomCenter = false;
                    whiteMiddleLeft = true;
                    blackMiddleLeft = false;
                    wbTurn = "Black";
                    pawnID = "None";
                }
            }
            else if (wbTurn == "Black")
            {
                if (pawnID == "BTC")
                {
                    hideAllMoves();
                    blackPwnTopCenter.Visibility = Visibility.Hidden;
                    blackPwnMiddleLeft.Visibility = Visibility.Visible;
                    whitePwnMiddleLeft.Visibility = Visibility.Hidden;
                    blackTopCenter = false;
                    whiteMiddleLeft = false;
                    blackMiddleLeft = true;
                    wbTurn = "White";
                    pawnID = "None";
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
            hideAllMoves();
            if (wbTurn == "White")
            {
                if (pawnID == "WBL")
                {
                    whitePwnBottomLeft.Visibility = Visibility.Hidden;
                    whitePwnMiddleCenter.Visibility = Visibility.Visible;
                    blackPwnMiddleCenter.Visibility = Visibility.Hidden;
                    whiteMiddleCenter = true;
                    whiteBottomRight = false;
                    blackMiddleCenter = false;
                    wbTurn = "Black";
                    pawnID = "None";
                }
                else if (pawnID == "WBC")
                {
                    whitePwnBottomCenter.Visibility = Visibility.Hidden;
                    whitePwnMiddleCenter.Visibility = Visibility.Visible;
                    whiteBottomCenter = false;
                    whiteMiddleCenter = true;
                    wbTurn = "Black";
                    pawnID = "None";
                }
                else if (pawnID == "WBR")
                {
                    whitePwnBottomRight.Visibility = Visibility.Hidden;
                    whitePwnMiddleCenter.Visibility = Visibility.Visible;
                    blackPwnMiddleCenter.Visibility = Visibility.Hidden;
                    blackMiddleCenter = false;
                    whiteMiddleCenter = true;
                    whiteBottomRight = false;
                }
            }
            else if (wbTurn == "Black")
            {
                if (pawnID == "BTL")
                {
                    blackPwnTopRight.Visibility = Visibility.Hidden;
                    blackPwnMiddleCenter.Visibility = Visibility.Visible;
                    whitePwnMiddleCenter.Visibility = Visibility.Hidden;
                    whiteMiddleCenter = false;
                    blackMiddleCenter = true;
                    blackTopLeft = false;
                    wbTurn = "White";
                    pawnID = "None";
                }
                else if (pawnID == "BTC")
                {
                    blackPwnTopCenter.Visibility = Visibility.Hidden;
                    blackPwnMiddleCenter.Visibility = Visibility.Visible;
                    blackTopCenter = false;
                    blackMiddleCenter = true;
                    wbTurn = "White";
                    pawnID = "None";
                }
                else if (pawnID == "BTR")
                {
                    blackPwnTopRight.Visibility = Visibility.Hidden;
                    blackPwnMiddleCenter.Visibility = Visibility.Visible;
                    whitePwnMiddleCenter.Visibility = Visibility.Hidden;
                    whiteMiddleCenter = false;
                    blackMiddleCenter = true;
                    blackTopRight = false;
                    wbTurn = "White";
                    pawnID = "None";
                }
            }
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

