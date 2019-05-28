using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prog_4s_l7_2
{
    class Program
    {
        interface IRoom
        {
            //double Dlina { get;  }
            //double Shirina { get;  }
            //int Kilk { get; set; }
            void Show();
            double plosha();


        }

        class ClassRoom : IRoom, IComparable, IComparer<ClassRoom>
        {
            double dlina, shirina, kilk;
            public ClassRoom(double dlina, double shirina, int kilk)
            {
                this.dlina = dlina;
                this.shirina = shirina;
                this.kilk = kilk;
            }

            public void Show()
            {
                Console.WriteLine("ClassRoom ce plosha {1}", plosha());
            }
            public double plosha()
            {
                return dlina * shirina;
            }
            public int CompareTo(object obj)
            {
                ClassRoom c = obj as ClassRoom;
                return plosha().CompareTo(c.plosha());

            }

            public int Compare(ClassRoom x, ClassRoom y)
            {

                return x.kilk.CompareTo(y.kilk);
            }

        }

        class MyRoom : IRoom, IComparable, IComparer<MyRoom>
        {
            double dlina, shirina, kilk;
            public MyRoom(double dlina, double shirina, int kilk)
            {
                this.dlina = dlina;
                this.shirina = shirina;
                this.kilk = kilk;
            }

            public void Show()
            {
                Console.WriteLine("MyRoom ce plosha {1}", plosha());
            }
            public double plosha()
            {
                return dlina * shirina;
            }
            public int CompareTo(object obj)
            {
                MyRoom c = obj as MyRoom;
                return plosha().CompareTo(c.plosha());

            }

            public int Compare(MyRoom x, MyRoom y)
            {

                return x.kilk.CompareTo(y.kilk);
            }

        }

        static void Main(string[] args)
        {
            ClassRoom x = new ClassRoom(15, 12, 15);
            ClassRoom y = new ClassRoom(12, 30, 80);
            if (x.CompareTo(y) > 0)
                Console.WriteLine("У x больше площадь");
            else Console.WriteLine("У y больше площадь");

            List<ClassRoom> okna = new List<ClassRoom>();


            MyRoom x1 = new MyRoom(10, 7, 12);
            MyRoom y1 = new MyRoom(12, 30, 23);
            if (x1.CompareTo(y1) > 0)
                Console.WriteLine("У x больше площадь");
            else Console.WriteLine("У y больше площадь");


        }

    }
}

