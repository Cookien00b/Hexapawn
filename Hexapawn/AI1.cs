using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace Hexapawn
{
    class AI1
    {
        //turn 1
        static int box1 = 10;
        static int box2;
        //turn 2
        static int box3;
        static int box4;
        static int box5;
        static int box6;
        static int box7;
        static int box8;
        static int box9;
        static int box10;
        static int box11;
        static int box12;
        static int box13;
        //turn 3
        static int box14;
        static int box15;
        static int box16;
        static int box17;
        static int box18;
        static int box19;
        static int box20;
        static int box21;
        static int box22;
        static int box23;
        static int box24;

        static int generation;


        public static void boot()
        {
            save();
        }


        public static void save()
        {
            TextWriter tw = new StreamWriter("AI1mem.txt");
            
            tw.WriteLine(box1);
            tw.WriteLine(box2);
            tw.WriteLine(box3);
            tw.WriteLine(box4);
            tw.WriteLine(box5);
            tw.WriteLine(box6);
            tw.WriteLine(box7);
            tw.WriteLine(box8);
            tw.WriteLine(box9);
            tw.WriteLine(box10);
            tw.WriteLine(box11);
            tw.WriteLine(box12);
            tw.WriteLine(box13);
            tw.WriteLine(box14);
            tw.WriteLine(box15);
            tw.WriteLine(box16);
            tw.WriteLine(box17);
            tw.WriteLine(box18);
            tw.WriteLine(box19);
            tw.WriteLine(box20);
            tw.WriteLine(box21);
            tw.WriteLine(box22);
            tw.WriteLine(box23);
            tw.WriteLine(box24);
            tw.WriteLine(generation);


            tw.Close();
        }
        public static void load()
        {
            TextReader tr = new StreamReader("AI1mem.txt");

            string box1string = tr.ReadLine();
            string box2string = tr.ReadLine();
            string box3string = tr.ReadLine();
            string box4string = tr.ReadLine();
            string box5string = tr.ReadLine();
            string box6string = tr.ReadLine();
            string box7string = tr.ReadLine();
            string box8string = tr.ReadLine();
            string box9string = tr.ReadLine();
            string box10string = tr.ReadLine();
            string box11string = tr.ReadLine();
            string box12string = tr.ReadLine();
            string box13string = tr.ReadLine();
            string box14string = tr.ReadLine();
            string box15string = tr.ReadLine();
            string box16string = tr.ReadLine();
            string box17string = tr.ReadLine();
            string box18string = tr.ReadLine();
            string box19string = tr.ReadLine();
            string box20string = tr.ReadLine();
            string box21string = tr.ReadLine();
            string box22string = tr.ReadLine();
            string box23string = tr.ReadLine();
            string box24string = tr.ReadLine();
            string generationstring = tr.ReadLine();

            box1 = Convert.ToInt32(box1string);
            box2 = Convert.ToInt32(box2string);
            box3 = Convert.ToInt32(box3string);
            box4 = Convert.ToInt32(box4string);
            box5 = Convert.ToInt32(box5string);
            box6 = Convert.ToInt32(box6string);
            box7 = Convert.ToInt32(box7string);
            box8 = Convert.ToInt32(box8string);
            box9 = Convert.ToInt32(box9string);
            box10 = Convert.ToInt32(box10string);
            box11 = Convert.ToInt32(box11string);
            box12 = Convert.ToInt32(box12string);
            box13 = Convert.ToInt32(box13string);
            box14 = Convert.ToInt32(box14string);
            box15 = Convert.ToInt32(box15string);
            box16 = Convert.ToInt32(box16string);
            box17 = Convert.ToInt32(box17string);
            box18 = Convert.ToInt32(box18string);
            box19 = Convert.ToInt32(box19string);
            box20 = Convert.ToInt32(box20string);
            box21 = Convert.ToInt32(box21string);
            box22 = Convert.ToInt32(box22string);
            box23 = Convert.ToInt32(box23string);
            box24 = Convert.ToInt32(box24string);
            generation = Convert.ToInt32(generationstring);

            tr.Close();
        }


    }
}
