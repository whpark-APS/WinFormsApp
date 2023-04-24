using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

using gtl.container;
using gtl.coordinate;
using xPoint = gtl.coordinate.Point;

namespace WinFormsApp
{
    static class Program
    {
        [Flags] public enum Seasons
        {
            Spring = 1, Summer = 2, Autumn = 4, Winter = 8,

            All = Spring | Summer | Autumn | Winter
        }
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Console.WriteLine("\n--------<<<<<<<<\n");

            var pair = new KeyValuePair<int, string>(3, "b");

            var pt0 = new xPoint(0, 3);
            var pt1 = new xPoint(3, 0);
            //var pt1 = pt0 with { y = 9.0; };

            var optionalInt = new int?();
            optionalInt = 4;
            Console.WriteLine($"optional Int : {optionalInt}");
            optionalInt = null;
            Console.WriteLine($"optional Int : {(optionalInt ?? -100)}");

            var pt = new Point(12.0, 5.0);
            Console.WriteLine($"pt : {pt}, length : {pt.Length()}");

            (double Sum, int Count) t2 = (302.0, 32);
            Console.WriteLine($"Sum of {t2.Count} elements is {t2.Sum}.");

            // enum
            var s = Seasons.All;
            Console.WriteLine($"Season : {s}");
            s = Seasons.Spring;
            Console.WriteLine($"Season : {s}");
            s |= Seasons.Autumn;
            Console.WriteLine($"Season : {s}");

            Console.WriteLine("\n-------->>>>>>>>\n");
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}
