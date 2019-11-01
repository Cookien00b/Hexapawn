using System;
using System.Windows;


namespace Hexapawn
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        int whiteWins = 0;
        int blackWins = 0;
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

        private void resetGame()
        {
            wbTurn = "White";
            pawnID = "None";

            moveAvailable = false;
            whiteBottomLeft = true;
            whiteBottomCenter = true;
            whiteBottomRight = true;
            whiteMiddleLeft = false;
            whiteMiddleCenter = false;
            whiteMiddleRight = false;
            whiteTopLeft = false;
            whiteTopCenter = false;
            whiteTopRight = false;

            blackBottomLeft = false;
            blackBottomCenter = false;
            blackBottomRight = false;
            blackMiddleLeft = false;
            blackMiddleCenter = false;
            blackMiddleRight = false;
            blackTopLeft = true;
            blackTopCenter = true;
            blackTopRight = true;

            AI2.turn = "White";

            AI2.W7 = true;
            AI2.W8 = true;
            AI2.W9 = true;
            AI2.W4 = false;
            AI2.W5 = false;
            AI2.W6 = false;
            AI2.W1 = false;
            AI2.W2 = false;
            AI2.W3 = false;

            AI2.B7 = false;
            AI2.B8 = false;
            AI2.B9 = false;
            AI2.B4 = false;
            AI2.B5 = false;
            AI2.B6 = false;
            AI2.B1 = true;
            AI2.B2 = true;
            AI2.B3 = true;

            AI2.moveSucces = false;

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
            whitePwnBottomLeft.Visibility = Visibility.Visible;
            whitePwnBottomCenter.Visibility = Visibility.Visible;
            whitePwnBottomRight.Visibility = Visibility.Visible;
            blackPwnTopLeft.Visibility = Visibility.Visible;
            blackPwnTopCenter.Visibility = Visibility.Visible;
            blackPwnTopRight.Visibility = Visibility.Visible;
            hideAllMoves();
            AI2.boot();
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
        //if (pawnID == "WCURRENT")
        //{
        //    pawnID = "None";
        //}
        //else if (pawnID == "BCURRENT")
        //{
        //    pawnID = "None";
        //}
        //else
        //{
        //    if (wbTurn == "White")
        //    {
        //        pawnID = "WCURRENT";
        //        if (whiteCURRENT == true)
        //        {
        //            if (blackINFRONT == false)
        //            {
        //                moveDotINFRONT.Visibility = Visibility.Visible;
        //                btnMoveINFRONT.Visibility = Visibility.Visible;
        //                moveAvailable = true;
        //            }
        //            if (blackDIAGNALLEFT == true)
        //            {
        //                moveDotDIAGNALLEFT.Visibility = Visibility.Visible;
        //                btnMoveDIAGNALLEFT.Visibility = Visibility.Visible;
        //                moveAvailable = true;
        //            }
        //            if (blackDIAGNALRIGHT == true)
        //            {
        //                moveDotDIAGNALRIGHT.Visibility = Visibility.Visible;
        //                btnMoveDIAGNALRIGHT.Visibility = Visibility.Visible;
        //                moveAvailable = true;
        //            }
        //        }
        //    }
        //    else if (wbTurn == "Black")
        //    {
        //        pawnID = "BCURRENT";
        //        if (blackCURRENT == true)
        //        {
        //            if (whiteINFRONT == false)
        //            {
        //                moveDotINFRONT.Visibility = Visibility.Visible;
        //                btnMoveINFRONT.Visibility = Visibility.Visible;
        //                moveAvailable = true;
        //            }
        //            if (whiteDIAGNALLEFT == true)
        //            {
        //                moveDotDIAGNALLEFT.Visibility = Visibility.Visible;
        //                btnMoveDIAGNALLEFT.Visibility = Visibility.Visible;
        //                moveAvailable = true;
        //            }
        //            if (whiteDIAGNALRIGHT == true)
        //            {
        //                moveDotDIAGNALRIGHT.Visibility = Visibility.Visible;
        //                btnMoveDIAGNALRIGHT.Visibility = Visibility.Visible;
        //                moveAvailable = true;
        //            }
        //        }
        //    }
        //}

        private void moveChecker(RoutedEventArgs e)
        {
            moveAvailable = false;
            BtnBottomRight_Click(btnBottomRight, e);
            BtnBottomCenter_Click(btnBottomCenter, e);
            BtnBottomLeft_Click(btnBottomLeft, e);
            BtnMiddleRight_Click(btnMiddleRight, e);
            BtnMiddleCenter_Click(btnMiddleCenter, e);
            BtnMiddleLeft_Click(btnMiddleRight, e);
            BtnTopRight_Click(btnTopRight, e);
            BtnTopCenter_Click(btnTopCenter, e);
            BtnTopLeft_Click(btnTopLeft, e);
            hideAllMoves();
            pawnID = "None";
            if (moveAvailable == false)
            {
                if (wbTurn == "White")
                {
                    MessageBox.Show("White can't move so black won!", "Black won");
                    blackWins = blackWins + 1;
                    resetGame();
                }
                if (wbTurn == "Black")
                {
                    MessageBox.Show("Black can't move so white won!", "White won");
                    whiteWins = whiteWins + 1;
                    resetGame();
                }
            }
            else
            {
                AI2.boot();
            }
        }

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
            else
            {

                if (wbTurn == "White")
                {
                    if (whiteBottomLeft == true)
                    {
                        pawnID = "WBL";
                        if (blackMiddleLeft == false && whiteMiddleLeft == false)

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
                }
                else if (wbTurn == "Black")
                {
                    return;
                }
            }
        }

        private void BtnMiddleLeft_Click(object sender, RoutedEventArgs e)
        {
            hideAllMoves();
            if (pawnID == "WML")
            {
                pawnID = "None";
            }
            else if (pawnID == "BML")
            {
                pawnID = "None";
            }
            else
            {

                if (wbTurn == "White")
                {
                    pawnID = "WML";
                    if (whiteMiddleLeft == true)
                    {
                        if (blackTopLeft == false)
                        {
                            moveDotTopLeft.Visibility = Visibility.Visible;
                            btnMoveTopLeft.Visibility = Visibility.Visible;
                            moveAvailable = true;
                        }
                        if (blackTopCenter == true)
                        {
                            moveDotTopCenter.Visibility = Visibility.Visible;
                            btnMoveTopCenter.Visibility = Visibility.Visible;
                            moveAvailable = true;
                        }
                    }
                }
                else if (wbTurn == "Black")
                {
                    pawnID = "BML";
                    if (blackMiddleLeft == true)
                    {
                        if (whiteBottomLeft == false)
                        {
                            moveDotBottomLeft.Visibility = Visibility.Visible;
                            btnMoveBottomLeft.Visibility = Visibility.Visible;
                            moveAvailable = true;
                        }
                        if (whiteBottomCenter == true)
                        {
                            moveDotBottomCenter.Visibility = Visibility.Visible;
                            btnMoveBottomCenter.Visibility = Visibility.Visible;
                            moveAvailable = true;
                        }
                    }
                }
            }
        }

        private void BtnTopLeft_Click(object sender, RoutedEventArgs e)
        {
            hideAllMoves();
            if (pawnID == "WTL")
            {
                pawnID = "None";
            }
            else if (pawnID == "BTL")
            {
                pawnID = "None";
            }
            else
            {

                if (wbTurn == "White")
                {
                    return;
                }
                else if (wbTurn == "Black")
                {
                    pawnID = "BTL";
                    if (blackTopLeft == true)
                    {
                        if (whiteMiddleLeft == false && blackMiddleLeft == false)
                        {
                            moveDotMiddleLeft.Visibility = Visibility.Visible;
                            btnMoveMiddleLeft.Visibility = Visibility.Visible;
                            moveAvailable = true;
                        }
                        if (whiteMiddleCenter == true)
                        {
                            moveDotMiddleCenter.Visibility = Visibility.Visible;
                            btnMoveMiddleCenter.Visibility = Visibility.Visible;
                            moveAvailable = true;
                        }
                    }
                }
            }
        }

        private void BtnBottomCenter_Click(object sender, RoutedEventArgs e)
        {
            hideAllMoves();
            if (pawnID == "WBC")
            {
                pawnID = "None";
            }
            else if (pawnID == "BBC")
            {
                pawnID = "None";
            }
            else
            {

                if (wbTurn == "White")
                {
                    pawnID = "WBC";
                    if (whiteBottomCenter == true)
                    {
                        if (blackMiddleCenter == false && whiteMiddleCenter == false)
                        {
                            moveDotMiddleCenter.Visibility = Visibility.Visible;
                            btnMoveMiddleCenter.Visibility = Visibility.Visible;
                            moveAvailable = true;
                        }
                        if (blackMiddleLeft == true)
                        {
                            moveDotMiddleLeft.Visibility = Visibility.Visible;
                            btnMoveMiddleLeft.Visibility = Visibility.Visible;
                            moveAvailable = true;
                        }
                        if (blackMiddleRight == true)
                        {
                            moveDotMiddleRight.Visibility = Visibility.Visible;
                            btnMoveMiddleRight.Visibility = Visibility.Visible;
                            moveAvailable = true;
                        }
                    }
                }
                else if (wbTurn == "Black")
                {
                    return;
                }
            }
        }

        private void BtnMiddleCenter_Click(object sender, RoutedEventArgs e)
        {
            hideAllMoves();
            if (pawnID == "WMC")
            {
                pawnID = "None";
            }
            else if (pawnID == "BMC")
            {
                pawnID = "None";
            }
            else
            {
                if (wbTurn == "White")
                {
                    pawnID = "WMC";
                    if (whiteMiddleCenter == true)
                    {
                        if (blackTopCenter == false)
                        {
                            moveDotTopCenter.Visibility = Visibility.Visible;
                            btnMoveTopCenter.Visibility = Visibility.Visible;
                            moveAvailable = true;
                        }
                        if (blackTopLeft == true)
                        {
                            moveDotTopLeft.Visibility = Visibility.Visible;
                            btnMoveTopLeft.Visibility = Visibility.Visible;
                            moveAvailable = true;
                        }
                        if (blackTopRight == true)
                        {
                            moveDotTopRight.Visibility = Visibility.Visible;
                            btnMoveTopRight.Visibility = Visibility.Visible;
                            moveAvailable = true;
                        }
                    }
                }
                else if (wbTurn == "Black")
                {
                    pawnID = "BMC";
                    if (blackMiddleCenter == true)
                    {
                        if (whiteBottomCenter == false)
                        {
                            moveDotBottomCenter.Visibility = Visibility.Visible;
                            btnMoveBottomCenter.Visibility = Visibility.Visible;
                            moveAvailable = true;
                        }
                        if (whiteBottomLeft == true)
                        {
                            moveDotBottomLeft.Visibility = Visibility.Visible;
                            btnMoveBottomLeft.Visibility = Visibility.Visible;
                            moveAvailable = true;
                        }
                        if (whiteBottomRight == true)
                        {
                            moveDotBottomRight.Visibility = Visibility.Visible;
                            btnMoveBottomRight.Visibility = Visibility.Visible;
                            moveAvailable = true;
                        }
                    }
                }
            }
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
            else
            {

                if (wbTurn == "White")
                {
                    return;
                }
                else if (wbTurn == "Black")
                {
                    pawnID = "BTC";
                    if (blackTopCenter == true)
                    {
                        if (whiteMiddleCenter == false && blackMiddleCenter == false)
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
            }
        }

        private void BtnTopRight_Click(object sender, RoutedEventArgs e)
        {
            hideAllMoves();
            if (pawnID == "WTR")
            {
                pawnID = "None";
            }
            else if (pawnID == "BTR")
            {
                pawnID = "None";
            }
            else
            {
                if (wbTurn == "White")
                {
                    return;
                }
                else if (wbTurn == "Black")
                {
                    pawnID = "BTR";
                    if (blackTopRight == true)
                    {
                        if (whiteMiddleRight == false && blackMiddleRight == false)
                        {
                            moveDotMiddleRight.Visibility = Visibility.Visible;
                            btnMoveMiddleRight.Visibility = Visibility.Visible;
                            moveAvailable = true;
                        }
                        if (whiteMiddleCenter == true)
                        {
                            moveDotMiddleCenter.Visibility = Visibility.Visible;
                            btnMoveMiddleCenter.Visibility = Visibility.Visible;
                            moveAvailable = true;
                        }
                    }
                }
            }
        }

        private void BtnMiddleRight_Click(object sender, RoutedEventArgs e)
        {
            hideAllMoves();
            if (pawnID == "WMR")
            {
                pawnID = "None";
            }
            else if (pawnID == "BMR")
            {
                pawnID = "None";
            }
            else
            {
                if (wbTurn == "White")
                {
                    pawnID = "WMR";
                    if (whiteMiddleRight == true)
                    {
                        if (blackTopRight == false)
                        {
                            moveDotTopRight.Visibility = Visibility.Visible;
                            btnMoveTopRight.Visibility = Visibility.Visible;
                            moveAvailable = true;
                        }
                        if (blackTopCenter == true)
                        {
                            moveDotTopCenter.Visibility = Visibility.Visible;
                            btnMoveTopCenter.Visibility = Visibility.Visible;
                            moveAvailable = true;
                        }
                    }
                }
                else if (wbTurn == "Black")
                {
                    pawnID = "BMR";
                    if (blackMiddleRight == true)
                    {
                        if (whiteBottomRight == false)
                        {
                            moveDotBottomRight.Visibility = Visibility.Visible;
                            btnMoveBottomRight.Visibility = Visibility.Visible;
                            moveAvailable = true;
                        }
                        if (whiteBottomCenter == true)
                        {
                            moveDotBottomCenter.Visibility = Visibility.Visible;
                            btnMoveBottomCenter.Visibility = Visibility.Visible;
                            moveAvailable = true;
                        }
                    }
                }
            }
        }

        private void BtnBottomRight_Click(object sender, RoutedEventArgs e)
        {
            hideAllMoves();
            if (pawnID == "WBR")
            {
                pawnID = "None";
            }
            else if (pawnID == "BBR")
            {
                pawnID = "None";
            }
            else
            {
                if (wbTurn == "White")
                {
                    pawnID = "WBR";
                    if (whiteBottomRight == true)
                    {
                        if (blackMiddleRight == false && whiteMiddleRight == false)
                        {
                            moveDotMiddleRight.Visibility = Visibility.Visible;
                            btnMoveMiddleRight.Visibility = Visibility.Visible;
                            moveAvailable = true;
                        }
                        if (blackMiddleCenter == true)
                        {
                            moveDotMiddleCenter.Visibility = Visibility.Visible;
                            btnMoveMiddleCenter.Visibility = Visibility.Visible;
                            moveAvailable = true;
                        }
                    }
                }
                else if (wbTurn == "Black")
                {
                    return;
                }
            }
        }


        private void BtnMoveBottomLeft_Click(object sender, RoutedEventArgs e)
        {
            hideAllMoves();
            if (wbTurn == "White")
            {
                return;
            }
            if (wbTurn == "Black")
            {
                if (pawnID == "BML")
                {
                    blackPwnMiddleLeft.Visibility = Visibility.Hidden;
                    blackPwnBottomLeft.Visibility = Visibility.Visible;
                    blackMiddleLeft = false; AI2.B4 = false;
                    blackBottomLeft = true;
                    wbTurn = "White";
                    AI2.turn = "White";
                    pawnID = "None";
                    moveChecker(e);
                    blackWins = blackWins + 1;
                    MessageBox.Show("Black wins!", "Black won");
                    resetGame();
                }
                if (pawnID == "BMC")
                {
                    blackPwnMiddleCenter.Visibility = Visibility.Hidden;
                    blackPwnBottomLeft.Visibility = Visibility.Visible;
                    whitePwnBottomLeft.Visibility = Visibility.Hidden;
                    blackMiddleCenter = false; AI2.B5 = false;
                    whiteBottomLeft = false; AI2.W7 = false;
                    blackBottomLeft = true;
                    wbTurn = "White";
                    AI2.turn = "White";
                    pawnID = "None";
                    moveChecker(e);
                    blackWins = blackWins + 1;
                    MessageBox.Show("Black wins!", "Black won");
                    resetGame();
                }
            }
        }

        private void BtnMoveMiddleLeft_Click(object sender, RoutedEventArgs e)
        {
            hideAllMoves();
            if (wbTurn == "White")
            {
                if (pawnID == "WBL")
                {
                    hideAllMoves();
                    whitePwnBottomLeft.Visibility = Visibility.Hidden;
                    whitePwnMiddleLeft.Visibility = Visibility.Visible;
                    whiteBottomLeft = false; AI2.W7 = false;
                    whiteMiddleLeft = true; AI2.W4 = true;
                    wbTurn = "Black"; AI2.turn = "Black";
                    pawnID = "None";
                    moveChecker(e);
                    AI2.boot();
                }
                else if (pawnID == "WBC")
                {
                    hideAllMoves();
                    whitePwnBottomCenter.Visibility = Visibility.Hidden;
                    blackPwnMiddleLeft.Visibility = Visibility.Hidden;
                    whitePwnMiddleLeft.Visibility = Visibility.Visible;
                    whiteBottomCenter = false; AI2.W8 = false;
                    whiteMiddleLeft = true; AI2.W4 = true;
                    blackMiddleLeft = false; AI2.B4 = false;
                    wbTurn = "Black"; AI2.turn = "Black";
                    pawnID = "None";
                    moveChecker(e);
                    AI2.boot();
                }
            }
            else if (wbTurn == "Black")
            {
                if (pawnID == "BTC")
                {
                    blackPwnTopCenter.Visibility = Visibility.Hidden;
                    blackPwnMiddleLeft.Visibility = Visibility.Visible;
                    whitePwnMiddleLeft.Visibility = Visibility.Hidden;
                    blackTopCenter = false; AI2.B2 = false;
                    whiteMiddleLeft = false; AI2.W4 = false;
                    blackMiddleLeft = true; AI2.B4 = true;
                    wbTurn = "White";
                    AI2.turn = "White";
                    pawnID = "None";
                    moveChecker(e);
                    AI2.boot();
                }
                if (pawnID == "BTL")
                {
                    blackPwnTopLeft.Visibility = Visibility.Hidden;
                    blackPwnMiddleLeft.Visibility = Visibility.Visible;
                    blackTopLeft = false; AI2.B1 = false;
                    blackMiddleLeft = true; AI2.B4 = true;
                    wbTurn = "White";
                    pawnID = "None";
                    moveChecker(e);
                    AI2.boot();
                }
            }
        }

        private void BtnMoveTopLeft_Click(object sender, RoutedEventArgs e)
        {
            hideAllMoves();
            if (wbTurn == "White")
            {
                if (pawnID == "WML")
                {
                    whitePwnMiddleLeft.Visibility = Visibility.Hidden;
                    whitePwnTopLeft.Visibility = Visibility.Visible;
                    whiteMiddleLeft = false; AI2.W4 = false;
                    whiteTopLeft = true;
                    wbTurn = "Black"; AI2.turn = "Black";
                    pawnID = "None";
                    whiteWins = whiteWins + 1;
                    MessageBox.Show("White wins!", "White won");
                    resetGame();
                }
                if (pawnID == "WMC")
                {
                    whitePwnMiddleCenter.Visibility = Visibility.Hidden;
                    whitePwnTopLeft.Visibility = Visibility.Visible;
                    blackPwnTopLeft.Visibility = Visibility.Hidden;
                    blackTopLeft = false; AI2.B1 = false;
                    whiteTopLeft = true;
                    whiteMiddleCenter = false; AI2.W5 = false;
                    wbTurn = "Black"; AI2.turn = "Black";
                    pawnID = "None";
                    whiteWins = whiteWins + 1;
                    MessageBox.Show("White wins!", "White won");
                    resetGame();
                }
            }
        }

        private void BtnMoveBottomCenter_Click(object sender, RoutedEventArgs e)
        {
            hideAllMoves();
            if (wbTurn == "White")
            {
                return;
            }
            if (wbTurn == "Black")
            {
                if (pawnID == "BML")
                {
                    blackPwnMiddleLeft.Visibility = Visibility.Hidden;
                    blackPwnBottomCenter.Visibility = Visibility.Visible;
                    whitePwnBottomCenter.Visibility = Visibility.Hidden;
                    whiteBottomCenter = false; AI2.W8 = false;
                    blackBottomCenter = true;
                    blackMiddleLeft = false; AI2.B4 = false;
                    wbTurn = "White"; AI2.turn = "White";
                    pawnID = "None"; 
                    blackWins = blackWins + 1;
                    MessageBox.Show("Black wins!", "Black won");
                    resetGame();
                }
                if (pawnID == "BMC")
                {
                    blackPwnMiddleCenter.Visibility = Visibility.Hidden;
                    blackPwnBottomCenter.Visibility = Visibility.Visible;
                    whiteBottomCenter = true;
                    whiteMiddleCenter = false; AI2.W5 = false;
                    wbTurn = "White"; AI2.turn = "White";
                    pawnID = "None";
                    blackWins = blackWins + 1;
                    MessageBox.Show("Black wins!", "Black won");
                    resetGame();
                }
                if (pawnID == "BMR")
                {
                    blackPwnMiddleRight.Visibility = Visibility.Hidden;
                    blackPwnBottomCenter.Visibility = Visibility.Visible;
                    whitePwnBottomCenter.Visibility = Visibility.Hidden;
                    whiteBottomCenter = false; AI2.W8 = false;
                    blackMiddleRight = false; AI2.B6 = false;
                    blackBottomCenter = true;
                    wbTurn = "White"; AI2.turn = "White";
                    pawnID = "None";
                    blackWins = blackWins + 1;
                    MessageBox.Show("Black wins!", "Black won");
                    resetGame();
                }
            }
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
                    whiteMiddleCenter = true; AI2.W5 = true;
                    whiteBottomLeft = false; AI2.W7 = false;
                    blackMiddleCenter = false; AI2.B5 = false;
                    wbTurn = "Black"; AI2.turn = "Black";
                    pawnID = "None";
                    moveChecker(e);
                    AI2.boot();
                }
                else if (pawnID == "WBC")
                {
                    whitePwnBottomCenter.Visibility = Visibility.Hidden;
                    whitePwnMiddleCenter.Visibility = Visibility.Visible;
                    whiteBottomCenter = false; AI2.W8 = false;
                    whiteMiddleCenter = true; AI2.W5 = true;
                    wbTurn = "Black"; AI2.turn = "Black";
                    pawnID = "None";
                    moveChecker(e);
                    AI2.boot();
                }
                else if (pawnID == "WBR")
                {
                    whitePwnBottomRight.Visibility = Visibility.Hidden;
                    whitePwnMiddleCenter.Visibility = Visibility.Visible;
                    blackPwnMiddleCenter.Visibility = Visibility.Hidden;
                    blackMiddleCenter = false; AI2.B5 = false;
                    whiteMiddleCenter = true; AI2.W5 = true;
                    whiteBottomRight = false; AI2.W9 = false;
                    wbTurn = "Black"; AI2.turn = "Black";
                    pawnID = "None";
                    moveChecker(e);
                    AI2.boot();
                }
            }
            else if (wbTurn == "Black")
            {
                if (pawnID == "BTL")
                {
                    blackPwnTopLeft.Visibility = Visibility.Hidden;
                    blackPwnMiddleCenter.Visibility = Visibility.Visible;
                    whitePwnMiddleCenter.Visibility = Visibility.Hidden;
                    whiteMiddleCenter = false; AI2.W5 = false;
                    blackMiddleCenter = true; AI2.B5 = true;
                    blackTopLeft = false; AI2.B1 = false;
                    wbTurn = "White"; AI2.turn = "White";
                    pawnID = "None";
                    moveChecker(e);
                    AI2.boot();
                }
                else if (pawnID == "BTC")
                {
                    blackPwnTopCenter.Visibility = Visibility.Hidden;
                    blackPwnMiddleCenter.Visibility = Visibility.Visible;
                    blackTopCenter = false; AI2.B2 = false;
                    blackMiddleCenter = true; AI2.B5 = true;
                    wbTurn = "White"; AI2.turn = "White";
                    pawnID = "None";
                    moveChecker(e);
                    AI2.boot();
                }
                else if (pawnID == "BTR")
                {
                    blackPwnTopRight.Visibility = Visibility.Hidden;
                    blackPwnMiddleCenter.Visibility = Visibility.Visible;
                    whitePwnMiddleCenter.Visibility = Visibility.Hidden;
                    whiteMiddleCenter = false; AI2.W5 = false;
                    blackMiddleCenter = true;
                    blackTopRight = false; AI2.B3 = false;
                    wbTurn = "White"; AI2.turn = "White";
                    pawnID = "None";
                    moveChecker(e);
                    AI2.boot();
                }
            }
        }

        private void BtnMoveTopCenter_Click(object sender, RoutedEventArgs e)
        {
            hideAllMoves();
            if (wbTurn == "White")
            {
                if (pawnID == "WML")
                {
                    whitePwnTopCenter.Visibility = Visibility.Hidden;
                    whitePwnTopCenter.Visibility = Visibility.Visible;
                    blackPwnTopCenter.Visibility = Visibility.Hidden;
                    blackTopCenter = false; AI2.B2 = false;
                    whiteTopCenter = true;
                    whiteMiddleLeft = false; AI2.W4 = false;
                    wbTurn = "Black"; AI2.turn = "Black";
                    pawnID = "None";
                    whiteWins = whiteWins + 1;
                    MessageBox.Show("White wins!", "White won");
                    resetGame();
                }
                if (pawnID == "WMC")
                {
                    whitePwnTopCenter.Visibility = Visibility.Visible;
                    whitePwnMiddleCenter.Visibility = Visibility.Hidden;
                    whiteMiddleCenter = false; AI2.W5 = false;
                    whiteTopCenter = true;
                    wbTurn = "Black"; AI2.turn = "Black";
                    pawnID = "None";
                    whiteWins = whiteWins + 1;
                    MessageBox.Show("White wins!", "White won");
                    resetGame();
                }
                if (pawnID == "WMR")
                {
                    whitePwnMiddleRight.Visibility = Visibility.Hidden;
                    blackPwnTopCenter.Visibility = Visibility.Hidden;
                    whitePwnTopCenter.Visibility = Visibility.Visible;
                    whiteTopCenter = true;
                    whiteMiddleRight = false; AI2.W6 = false;
                    blackTopCenter = false; AI2.B2 = false;
                    wbTurn = "Black"; AI2.turn = "Black";
                    pawnID = "None";
                    whiteWins = whiteWins + 1;
                    MessageBox.Show("White wins!", "White won");
                    resetGame();
                }

            }
            else if (wbTurn == "Black")
            {
                return;
            }
        }

        private void BtnMoveTopRight_Click(object sender, RoutedEventArgs e)
        {
            hideAllMoves();
            if (wbTurn == "White")
            {
                if (pawnID == "WMC")
                {
                    whitePwnMiddleCenter.Visibility = Visibility.Hidden;
                    blackPwnTopRight.Visibility = Visibility.Hidden;
                    whitePwnTopRight.Visibility = Visibility.Visible;
                    whiteTopRight = true;
                    blackTopRight = false; AI2.B3 = false;
                    whiteMiddleCenter = false; AI2.W5 = false;
                    wbTurn = "Black"; AI2.turn = "Black";
                    pawnID = "None";
                    whiteWins = whiteWins + 1;
                    MessageBox.Show("White wins!", "White won");
                    resetGame();
                }
                if (pawnID == "WMR")
                {
                    whitePwnMiddleLeft.Visibility = Visibility.Hidden;
                    whitePwnTopRight.Visibility = Visibility.Visible;
                    whiteTopRight = true;
                    whiteMiddleRight = false; AI2.W6 = false;
                    wbTurn = "Black"; AI2.turn = "Black";
                    pawnID = "None";
                    whiteWins = whiteWins + 1;
                    MessageBox.Show("White wins!", "White won");
                    resetGame();
                }
            }
            else if (wbTurn == "Black")
            {
                return;
            }
        }

        private void BtnMoveMiddleRight_Click(object sender, RoutedEventArgs e)
        {
            hideAllMoves();
            if (wbTurn == "White")
            {
                if (pawnID == "WBR")
                {
                    whitePwnBottomRight.Visibility = Visibility.Hidden;
                    whitePwnMiddleRight.Visibility = Visibility.Visible;
                    whiteMiddleRight = true; AI2.W6 = true;
                    whiteBottomRight = false; AI2.W9 = false;
                    wbTurn = "Black"; AI2.turn = "Black";
                    pawnID = "None";
                    moveChecker(e);
                    AI2.boot();
                }
                if (pawnID == "WBC")
                {
                    whitePwnBottomCenter.Visibility = Visibility.Hidden;
                    blackPwnMiddleRight.Visibility = Visibility.Hidden;
                    whitePwnMiddleRight.Visibility = Visibility.Visible;
                    whiteMiddleRight = true; AI2.W6 = true;
                    blackMiddleRight = false; AI2.B6 = false;
                    whiteBottomCenter = false; AI2.W8 = false;
                    wbTurn = "Black"; AI2.turn = "Black";
                    pawnID = "None";
                    moveChecker(e);
                    AI2.boot();
                }
            }
            else if (wbTurn == "Black")
            {
                if (pawnID == "BTR")
                {
                    blackPwnTopRight.Visibility = Visibility.Hidden;
                    blackPwnMiddleRight.Visibility = Visibility.Visible;
                    blackTopRight = false; AI2.B3 = false;
                    blackMiddleRight = true;
                    wbTurn = "White"; AI2.turn = "White";
                    pawnID = "None";
                    moveChecker(e);
                    AI2.boot();
                }
                if (pawnID == "BTC")
                {
                    blackPwnTopCenter.Visibility = Visibility.Hidden;
                    blackPwnMiddleRight.Visibility = Visibility.Visible;
                    whitePwnMiddleRight.Visibility = Visibility.Hidden;
                    blackMiddleRight = true;
                    blackTopCenter = false; AI2.B2 = false;
                    whiteMiddleRight = false; AI2.W6 = false;
                    wbTurn = "White"; AI2.turn = "White";
                    pawnID = "None";
                    moveChecker(e);
                    AI2.boot();
                }
            }
        }

        private void BtnMoveBottomRight_Click(object sender, RoutedEventArgs e)
        {
            hideAllMoves();
            if (wbTurn == "White")
            {
                return;
            }
            if (wbTurn == "Black")
            {
                if (pawnID == "BMR")
                {
                    blackPwnMiddleRight.Visibility = Visibility.Hidden;
                    blackPwnBottomRight.Visibility = Visibility.Visible;
                    blackMiddleRight = false; AI2.B6 = false;
                    blackBottomRight = true;
                    wbTurn = "White"; AI2.turn = "White";
                    pawnID = "None";
                    blackWins = blackWins + 1;
                    MessageBox.Show("Black wins!", "Black won");
                    resetGame();
                }
                if (pawnID == "BMC")
                {
                    blackPwnMiddleCenter.Visibility = Visibility.Hidden;
                    blackPwnBottomRight.Visibility = Visibility.Visible;
                    whitePwnBottomRight.Visibility = Visibility.Hidden;
                    whiteBottomRight = false; AI2.W9 = false;
                    blackMiddleCenter = false; AI2.B5 = false;
                    blackBottomRight = true;
                    wbTurn = "White"; AI2.turn = "White";
                    pawnID = "None";
                    blackWins = blackWins + 1;
                    MessageBox.Show("Black wins!", "Black won");
                    resetGame();
                }
            }

        }

        private void start_Click(object sender, RoutedEventArgs e)
        {
            AI2.boot();
            btnStart.Visibility = Visibility.Hidden;
        }

        private void disk_Click(object sender, RoutedEventArgs e)
        {
            if(sender == btnD)
            {
                AI2.folderName = @"d:\aiMem";
            }
            if (sender == btnE)
            {
                AI2.folderName = @"e:\aiMem";
            }
            if (sender == btnF)
            {
                AI2.folderName = @"f:\aiMem";
            }
            btnD.Visibility = Visibility.Hidden;
            btnE.Visibility = Visibility.Hidden;
            btnF.Visibility = Visibility.Hidden;
        }
    }
}

