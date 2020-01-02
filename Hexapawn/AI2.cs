using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Forms;

namespace Hexapawn
{
    class AI2
    {
        public static string lastMove = "74";
        public static bool moveSucces;
        public static bool clickSucces = false;


        public static string turn = "White";

        public static string winsAndLoses;

        public static bool W7 = true;
        public static bool W8 = true;
        public static bool W9 = true;
        public static bool W4 = false;
        public static bool W5 = false;
        public static bool W6 = false;
        public static bool W1 = false;
        public static bool W2 = false;
        public static bool W3 = false;

        public static bool B7 = false;
        public static bool B8 = false;
        public static bool B9 = false;
        public static bool B4 = false;
        public static bool B5 = false;
        public static bool B6 = false;
        public static bool B1 = true;
        public static bool B2 = true;
        public static bool B3 = true;
        static string board;
        static string whiteBoard;
        static string blackBoard;
        public static string movePlay;
        public static bool firstBoot = true;
        public static string folderName;
        public static bool firstPlay = true;
        public static List<string> whiteMatch = new List<string>();
        public static List<string> blackMatch = new List<string>();
        public static List<string> whiteMatchBoard = new List<string>();
        public static List<string> blackMatchBoard = new List<string>();

        public static void boot()
        {
            //test();
            //System.Windows.MessageBox.Show("Black wins!", "Black won");
            
            pawnCheck();
        }
        public static async Task test()
        {
            await Task.Delay(200);
            LeftMouseClick(1000, 600);
        }
        public static void last2Moves(string lm)
        {
            if (lastMove.Length < 2)
            {
                lastMove += lm;
            }
            else
            {
                lastMove = lastMove.Substring(1);
                lastMove += lm;
            }
        }

        public static async Task pressBox(string w)
        {
            string[] matchMovesWhite = whiteMatch.ToArray();
            string[] matchMovesBlack = blackMatch.ToArray();

            Array.ForEach(matchMovesBlack, Console.WriteLine);
            Array.ForEach(matchMovesWhite, Console.WriteLine);


            if (w == "White")
            {
                for (int wins = 0; wins < matchMovesWhite.Length; wins++)
                {

                    //get all bytes
                    //bytes to string
                    //add 1 or 0 to the string
                    //string to bytes
                    //bytes to file
                    string pathString = System.IO.Path.Combine(folderName, whiteMatchBoard[wins]);

                    string filePath = System.IO.Path.Combine(pathString, whiteMatch[wins]);

                    byte[] winArray = File.ReadAllBytes(filePath);
                    winsAndLoses = Encoding.ASCII.GetString(winArray);
                    winsAndLoses = winsAndLoses + "1";

                    using (System.IO.FileStream fs = System.IO.File.Create(filePath))
                    {
                        byte[] bytes = Encoding.ASCII.GetBytes(winsAndLoses);
                        fs.Write(bytes, 0, bytes.Length);
                    }
                    pathString = System.IO.Path.Combine(folderName, blackMatchBoard[wins]);

                    filePath = System.IO.Path.Combine(pathString, blackMatch[wins]);

                    winArray = File.ReadAllBytes(filePath);
                    winsAndLoses = Encoding.ASCII.GetString(winArray);
                    winsAndLoses = winsAndLoses + "0";

                    using (System.IO.FileStream fs = System.IO.File.Create(filePath))
                    {
                        byte[] bytes = Encoding.ASCII.GetBytes(winsAndLoses);
                        fs.Write(bytes, 0, bytes.Length);
                    }
                }
            }
            else if (w == "Black")
            {
                for (int wins = 0; wins < matchMovesWhite.Length; wins++)
                {

                    //get all bytes
                    //bytes to string
                    //add 1 or 0 to the string
                    //string to bytes
                    //bytes to file
                    string pathString = System.IO.Path.Combine(folderName, whiteMatchBoard[wins]);

                    string filePath = System.IO.Path.Combine(pathString, whiteMatch[wins]);

                    byte[] winArray = File.ReadAllBytes(filePath);
                    winsAndLoses = Encoding.ASCII.GetString(winArray);
                    winsAndLoses += "0";

                    using (System.IO.FileStream fs = System.IO.File.Create(filePath))
                    {
                        byte[] bytes = Encoding.ASCII.GetBytes(winsAndLoses);
                        fs.Write(bytes, 0, bytes.Length);
                    }
                    pathString = System.IO.Path.Combine(folderName, blackMatchBoard[wins]);

                    filePath = System.IO.Path.Combine(pathString, blackMatch[wins]);

                    winArray = File.ReadAllBytes(filePath);
                    winsAndLoses = Encoding.ASCII.GetString(winArray);
                    winsAndLoses += "1";

                    using (System.IO.FileStream fs = System.IO.File.Create(filePath))
                    {
                        byte[] bytes = Encoding.ASCII.GetBytes(winsAndLoses);
                        fs.Write(bytes, 0, bytes.Length);
                    }
                }
            }
            test();
        }

        public static async Task pressStart()
        {
            await Task.Delay(20);
            LeftMouseClick(950, 50);
        }

        public static async Task press1()
        {
            LeftMouseClick(850, 400);
            last2Moves("1");


        }
        public static async Task press2()
        {
            LeftMouseClick(950, 400);
            last2Moves("2");


        }
        public static async Task press3()
        {
            LeftMouseClick(1050, 400);
            last2Moves("3");


        }
        public static async Task press4()
        {
            LeftMouseClick(850, 550);
            last2Moves("4");


        }
        public static async Task press5()
        {
            LeftMouseClick(950, 550);
            last2Moves("5");


        }
        public static async Task press6()
        {
            LeftMouseClick(1050, 550);
            last2Moves("6");


        }
        public static async Task press7()
        {
            LeftMouseClick(850, 700);
            last2Moves("7");


        }
        public static async Task press8()
        {
            LeftMouseClick(950, 700);
            last2Moves("8");


        }
        public static async Task press9()
        {
            LeftMouseClick(1050, 700);
            last2Moves("9");


        }


        public static void pawnCheck()
        {
            whiteBoard = "";
            blackBoard = "";
            board = "";

            if (B1 == true)
                blackBoard += "1";
            if (B2 == true)
                blackBoard += "2";
            if (B3 == true)
                blackBoard += "3";
            if (B4 == true)
                blackBoard += "4";
            if (B5 == true)
                blackBoard += "5";
            if (B6 == true)
                blackBoard += "6";
            if (B7 == true)
                blackBoard += "7";
            if (B8 == true)
                blackBoard += "8";
            if (B9 == true)
                blackBoard += "9";
            if (W1 == true)
                whiteBoard += "1";
            if (W2 == true)
                whiteBoard += "2";
            if (W3 == true)
                whiteBoard += "3";
            if (W4 == true)
                whiteBoard += "4";
            if (W5 == true)
                whiteBoard += "5";
            if (W6 == true)
                whiteBoard += "6";
            if (W7 == true)
                whiteBoard += "7";
            if (W8 == true)
                whiteBoard += "8";
            if (W9 == true)
                whiteBoard += "9";

            if (whiteBoard.Length <= 3)
            {
                for (int i = whiteBoard.Length; i < 3; i = whiteBoard.Length)
                {
                    whiteBoard = "0" + whiteBoard;
                }
            }
            if (blackBoard.Length <= 3)
            {
                for (int i = blackBoard.Length; i < 3; i = blackBoard.Length)
                {
                    blackBoard = "0" + blackBoard;
                }
            }
            if (turn == "White")
            {
                board = "W" + blackBoard + whiteBoard;
            }
            if (turn == "Black")
            {
                board = "B" + blackBoard + whiteBoard;
            }

            if (turn == "White")
                whiteMatchBoard.Add(board);
            else
                blackMatchBoard.Add(board);

            aiThink();
        }
        //This is a replacement for Cursor.Position in WinForms
        [DllImport("user32.dll", CharSet = CharSet.Auto, CallingConvention = CallingConvention.StdCall)]
        public static extern void mouse_event(uint dwFlags, uint dx, uint dy, uint cButtons, uint dwExtraInfo);
        //Mouse actions
        private const int MOUSEEVENTF_LEFTDOWN = 0x02;
        private const int MOUSEEVENTF_LEFTUP = 0x04;
        private const int MOUSEEVENTF_RIGHTDOWN = 0x08;
        private const int MOUSEEVENTF_RIGHTUP = 0x10;

        [DllImport("user32.dll", SetLastError = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool SetCursorPos(uint X, uint Y);
        public static void LeftMouseClick(uint X, uint Y)
        {
            SetCursorPos(X, Y);
            //Call the imported function with the cursor's current position
            mouse_event(MOUSEEVENTF_LEFTDOWN | MOUSEEVENTF_LEFTUP, X, Y, 0, 0);
        }

        private static string[] GetFileNames(string path)
        {
            string[] files = Directory.GetFiles(path);
            for (int i = 0; i < files.Length; i++)
                files[i] = Path.GetFileName(files[i]);
            return files;
        }

        static async void aiThink()
        {
            int wins = 0;
            int loses = 0;


            string pathString = System.IO.Path.Combine(folderName, board);

            if (System.IO.Directory.Exists(pathString))
            {
                //read file names
                string[] oldMoves = GetFileNames(pathString);

                //read wins and loses of all moves
                winsAndLoses = string.Join("", oldMoves);
                for (int e = 0; e < oldMoves.Length; e++)
                {
                    string filePath = System.IO.Path.Combine(pathString, oldMoves[e]);
                    byte[] winArray = File.ReadAllBytes(filePath);
                    winsAndLoses = Encoding.ASCII.GetString(winArray);
                }

                for (int i = 0; i < winsAndLoses.Length; i++)
                {
                    char winOrLose = winsAndLoses[i];
                    if (winOrLose == 49)
                    {
                        wins = wins + 1;
                    }
                    else
                    {
                        loses = loses + 1;
                    }
                }

                //new move or old move
                int totalResults = wins + loses;
                decimal winChance;
                try
                {
                    winChance = wins * 100 / totalResults;
                }
                catch
                {
                    winChance = 0;
                }

                decimal winProcent = Math.Round(winChance, 0);

                int newOrOld = Convert.ToInt32(winProcent);
                List<int> winChancePerMove = new List<int>();
                int tempChance;

                Random rnd = new Random();
                int choice = rnd.Next(1, newOrOld + 1);
                if (choice <= newOrOld)
                {
                    for (int j = 0; j < oldMoves.Length; j++)
                    {
                        string filePath = System.IO.Path.Combine(pathString, oldMoves[j]);
                        byte[] winArray = File.ReadAllBytes(filePath);
                        winsAndLoses = Encoding.ASCII.GetString(winArray);

                        for (int x = 0; x < winsAndLoses.Length; x++)
                        {
                            char winOrLose = winsAndLoses[x];
                            if (winOrLose == 49)
                            {
                                wins = wins + 1;
                            }
                            else
                            {
                                loses = loses + 1;
                            }

                        }
                        tempChance = wins * 100 / loses;
                        winChancePerMove.Add(tempChance);
                    }
                    int[] winsArray = winChancePerMove.ToArray();
                    int totalChance = 0;

                    for (int s = winsArray.Length - 1; s >= 0; s--)
                    {
                        totalChance = totalChance + winsArray[s];
                    }

                    int tempCalc = 0;
                    List<int> winProcentPerMoveList = new List<int>();
                    for (int n = 0; n < winsArray.Length; n++)
                    {
                        for (int s = n; s >= 0; s--)
                        {
                            tempCalc = tempCalc + winsArray[s];
                        }
                        winProcentPerMoveList.Add(tempCalc);
                    }
                    int[] winProcentPerMove = winProcentPerMoveList.ToArray();

                    Random rnd2 = new Random();
                    int aiChoice = rnd2.Next(1, totalChance + 1);

                    for (int y = 0; y < oldMoves.Length; y++)
                    {
                        if (aiChoice <= winProcentPerMove[y])
                        {
                            play(oldMoves[y]);
                        }
                    }
                }
                else
                {
                    string moveTurn = await rndPlay();

                    if (moveTurn == "White")
                        whiteMatch.Add(lastMove);
                    else
                        blackMatch.Add(lastMove);

                    string fileName = lastMove;

                    pathString = System.IO.Path.Combine(pathString, fileName);

                    Console.WriteLine("Path to my file: {0}\n", pathString);

                    if (!System.IO.File.Exists(pathString))
                    {
                        using (System.IO.FileStream fs = System.IO.File.Create(pathString))
                        {
                            byte[] bytes = Encoding.ASCII.GetBytes("0");
                            fs.Write(bytes, 0, bytes.Length);
                        }
                    }
                    else
                    {
                        Console.WriteLine("File \"{0}\" already exists.", fileName);
                    }

                }


                //Random rnd = new Random();
                //int chance = box1 + box2 + box3;
                //int choice = rnd.Next(1, chance + 1);

                //if (choice <= box1)
                //{
                //    MessageBox.Show("box1");
                //}
                //else if (choice <= box1 + box2)
                //{
                //    MessageBox.Show("box2");
                //}
                //else if (choice <= box1 + box2 + box3)
                //{
                //    MessageBox.Show("box3");
                //}



                //if new move do rndPlay();
                //if old move create a rnd number between 0 and total wins and loses
                //if it is in the first move do that move etc

            }
            else
            {
                System.IO.Directory.CreateDirectory(pathString);

                string moveTurn = await rndPlay();

                if (moveTurn == "White")
                    whiteMatch.Add(lastMove);
                else
                    blackMatch.Add(lastMove);

                string fileName = lastMove;

                pathString = System.IO.Path.Combine(pathString, fileName);

                Console.WriteLine("Path to my file: {0}\n", pathString);

                using (System.IO.FileStream fs = System.IO.File.Create(pathString))
                {
                    byte[] bytes = Encoding.ASCII.GetBytes("0");
                    fs.Write(bytes, 0, bytes.Length);
                }
            }
            await pressStart();
        }

        public static async Task<string> rndPlay()
        {
            
            if (firstPlay == true)
            {
                firstPlay = false;
                movePlay = turn;
                moveSucces = false;
            }
            for (int g = 0; moveSucces != true; g++)
            {

                Random rndP = new Random();
                int rndPress = rndP.Next(1, 10);
                if (rndPress == 1)
                {
                    await press1();
                }
                if (rndPress == 2)
                {
                    await press2();
                }
                if (rndPress == 3)
                {
                    await press3();
                }
                if (rndPress == 4)
                {
                    await press4();
                }
                if (rndPress == 5)
                {
                    await press5();
                }
                if (rndPress == 6)
                {
                    await press6();
                }
                if (rndPress == 7)
                {
                    await press7();
                }
                if (rndPress == 8)
                {
                    await press8();
                }
                if (rndPress == 9)
                {
                    await press9();
                }
                //if (moveSucces == false)
                //{
                //    await taskReturn();
                //}

                await Task.Delay(75);
            }
            moveSucces = false;
            //firstPlay = true;
            return movePlay;
        }
        public static async Task taskReturn()
        {
            await Task.Delay(30);
            await rndPlay();
        }
        public static void aiLearn()
        {

            string pathString = System.IO.Path.Combine(folderName, board);

            string fileName = lastMove;

            if (!System.IO.File.Exists(pathString))
            {
                using (System.IO.FileStream fs = System.IO.File.Create(pathString))
                {
                    byte[] bytes = Encoding.ASCII.GetBytes(lastMove);
                    fs.Write(bytes, 0, bytes.Length);
                }
            }
            else
            {
                Console.WriteLine("File \"{0}\" already exists.", fileName);
                return;
            }

            try
            {
                byte[] readBuffer = System.IO.File.ReadAllBytes(pathString);
                foreach (byte b in readBuffer)
                {
                    Console.Write(b + " ");
                }
                Console.WriteLine();
            }
            catch (System.IO.IOException e)
            {
                Console.WriteLine(e.Message);
            }
            System.Console.WriteLine("Press ant key to exit.");
            System.Console.ReadKey();
        }
        public static async Task play(string e)
        {
            char firstPress = e[0];
            char secondPress = e[1];
            if (firstPress == 49)
            {
                press1();
            }
            if (firstPress == 50)
            {
                press2();
            }
            if (firstPress == 51)
            {
                press3();
            }
            if (firstPress == 52)
            {
                press4();
            }
            if (firstPress == 53)
            {
                press5();
            }
            if (firstPress == 54)
            {
                press6();
            }
            if (firstPress == 55)
            {
                press7();
            }
            if (firstPress == 56)
            {
                press8();
            }
            if (firstPress == 57)
            {
                press9();
            }

            Task.Delay(30);

            if (secondPress == 49)
            {
                press1();
            }
            if (secondPress == 50)
            {
                press2();
            }
            if (secondPress == 51)
            {
                press3();
            }
            if (secondPress == 52)
            {
                press4();
            }
            if (secondPress == 53)
            {
                press5();
            }
            if (secondPress == 54)
            {
                press6();
            }
            if (secondPress == 55)
            {
                press7();
            }
            if (secondPress == 56)
            {
                press8();
            }
            if (secondPress == 57)
            {
                press9();
            }

            if (turn == "White")
                whiteMatch.Add(lastMove);
            else
                blackMatch.Add(lastMove);
        }

    }
}
