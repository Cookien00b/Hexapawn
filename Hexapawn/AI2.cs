using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace Hexapawn
{
    class AI2
    {
        //turn 1
        static int box1;
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
        static int box25;
        static int box26;
        static int box27;
        static int box28;
        static int box29;
        static int box30;
        static int box31;
        static int box32;
        static int box33;
        static int box34;
        static int box35;
        static int box36;
        static int box37;
        static int box38;
        static int box39;
        static int box40;
        static int box41;
        static int box42;
        static int box43;
        static int box44;
        static int box45;
        static int box46;
        static int box47;
        static int box48;

        static int generation;


        public static void boot()
        {
            load();
        }


        public static void save()
        {
            TextWriter tw = new StreamWriter("AI2mem.txt");
            //tw.WriteLine(boxNO);
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
            tw.WriteLine(box25);
            tw.WriteLine(box26);
            tw.WriteLine(box27);
            tw.WriteLine(box28);
            tw.WriteLine(box29);
            tw.WriteLine(box30);
            tw.WriteLine(box31);
            tw.WriteLine(box32);
            tw.WriteLine(box33);
            tw.WriteLine(box34);
            tw.WriteLine(box35);
            tw.WriteLine(box36);
            tw.WriteLine(box37);
            tw.WriteLine(box38);
            tw.WriteLine(box39);
            tw.WriteLine(box40);
            tw.WriteLine(box41);
            tw.WriteLine(box42);
            tw.WriteLine(box43);
            tw.WriteLine(box44);
            tw.WriteLine(box45);
            tw.WriteLine(box46);
            tw.WriteLine(box47);
            tw.WriteLine(box48);



            tw.Close();
        }
        public static void load()
        {
            TextReader tr = new StreamReader("AI2mem.txt");

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
            string box25string = tr.ReadLine();
            string box26string = tr.ReadLine();
            string box27string = tr.ReadLine();
            string box28string = tr.ReadLine();
            string box29string = tr.ReadLine();
            string box30string = tr.ReadLine();
            string box31string = tr.ReadLine();
            string box32string = tr.ReadLine();
            string box33string = tr.ReadLine();
            string box34string = tr.ReadLine();
            string box35string = tr.ReadLine();
            string box36string = tr.ReadLine();
            string box37string = tr.ReadLine();
            string box38string = tr.ReadLine();
            string box39string = tr.ReadLine();
            string box40string = tr.ReadLine();
            string box41string = tr.ReadLine();
            string box42string = tr.ReadLine();
            string box43string = tr.ReadLine();
            string box44string = tr.ReadLine();
            string box45string = tr.ReadLine();
            string box46string = tr.ReadLine();
            string box47string = tr.ReadLine();
            string box48string = tr.ReadLine();


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
            box25 = Convert.ToInt32(box25string);
            box26 = Convert.ToInt32(box26string);
            box27 = Convert.ToInt32(box27string);
            box28 = Convert.ToInt32(box28string);
            box29 = Convert.ToInt32(box29string);
            box30 = Convert.ToInt32(box30string);
            box31 = Convert.ToInt32(box31string);
            box32 = Convert.ToInt32(box32string);
            box33 = Convert.ToInt32(box33string);
            box34 = Convert.ToInt32(box34string);
            box35 = Convert.ToInt32(box35string);
            box36 = Convert.ToInt32(box36string);
            box37 = Convert.ToInt32(box37string);
            box38 = Convert.ToInt32(box38string);
            box39 = Convert.ToInt32(box39string);
            box40 = Convert.ToInt32(box40string);
            box41 = Convert.ToInt32(box41string);
            box42 = Convert.ToInt32(box42string);
            box43 = Convert.ToInt32(box43string);
            box44 = Convert.ToInt32(box44string);
            box45 = Convert.ToInt32(box45string);
            box46 = Convert.ToInt32(box46string);
            box47 = Convert.ToInt32(box47string);
            box48 = Convert.ToInt32(box48string);

            tr.Close();
        }
    }
}
