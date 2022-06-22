using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

    public delegate void ShowInfo(string s);
    public delegate int Calculation(int n1, int n2);
    public class DemoDelegate
    {
        public static ShowInfo Notice = new ShowInfo(PrintAll);

        public event ShowInfo NoticeInformation; // declare event

        public int TinhTong(int a, int b)
        {
            return a + b;
        }
        public int TinhHieu(int a, int b)
        {
            return a - b;
        }
        public int TinhNhan(int a, int b)
        {
            return a * b;
        }

        public void CreateNotice()
        {
            Notice += PrintAll;
            Notice += SayAbuotMe;
        }
        //////////////////////////////////////////
        public static void PrintAll(string str)
        {
            Console.WriteLine("Hello " + str);
        }

        public void SayAbuotMe(string msg)
        {
            Console.WriteLine("Say: " + msg);
        }

        public static void Main(string[] args)
        {
            ShowInfo si = new ShowInfo(PrintAll);
            si("T2108M");
            ShowInfo si2 = new ShowInfo(new DemoDelegate().SayAbuotMe);
            si2("Hello World");

            ShowInfo si3 = new ShowInfo(PrintAll);
            si3 += new DemoDelegate().SayAbuotMe;

            si3("Hello T2108M");
            ///////////////////////////////////////
            Notice("Hello Notice");
            ///////////////////////////////////////
            Calculation c = new Calculation(new DemoDelegate().TinhTong);
            c += new DemoDelegate().TinhTong;
            c += new DemoDelegate().TinhHieu;
            c += new DemoDelegate().TinhNhan;
            c(4, 6);
            ///////////////////////////////////////
            ShowInfo d = delegate (string s)
            {
                Console.WriteLine(s);
                Console.WriteLine("Hello");
                Console.WriteLine("World");
            };
            d("Xin chao delegate");
            ///////////////////////////////////////
            DemoDelegate dd = new DemoDelegate();
            dd.NoticeInformation += PrintAll;
            dd.NoticeInformation += dd.SayAbuotMe;

            dd.NoticeInformation("hello");
            ///////////////////////////////////////
            List<string> ls = new List<string>();
         }
    }
