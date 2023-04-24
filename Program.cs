using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

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
            // Debug Output
            Debug.WriteLine("\n--------<<<<<<<<\n");

            var pair = new KeyValuePair<int, string>(3, "b");

            var pt0 = new xPoint(0, 3);
            var pt1 = new xPoint(3, 0);
            //var pt1 = pt0 with { y = 9.0; };

            var optionalInt = new int?();
            optionalInt = 4;
            Debug.WriteLine($"optional Int : {optionalInt}");
            optionalInt = null;
            Debug.WriteLine($"optional Int : {(optionalInt ?? -100)}");

            var pt = new Point(12.0, 5.0);
            Debug.WriteLine($"pt : {pt}, length : {pt.Length()}");
            pt[1] = 16.0;
            Debug.WriteLine($"pt[0] = 3: {pt}, length : {pt.Length()}");

            (double Sum, int Count) t2 = (302.0, 32);
            Debug.WriteLine($"Sum of {t2.Count} elements is {t2.Sum}.");

            // enum
            var s = Seasons.All;
            Debug.WriteLine($"Season : {s}");
            s = Seasons.Spring;
            Debug.WriteLine($"Season : {s}");
            s |= Seasons.Autumn;
            Debug.WriteLine($"Season : {s}");

            // Vector
            var v = new Vector<int>();
            v.Changed += (sender, e) => 
                Debug.WriteLine($"Changed : {sender}, {{{e}}}, count : {v.count}, capacity : {v.capacity}");
            v.Push(0);
            v.Push(1);
            v.Push(2);
            v.Push(3);
            v.Push(4);
            v.Push(5);
            v.Push(6);
            v.Push(7);
            v.Push(8);
            v.Push(9);
            v[3] = 3;   // no output
            v[4] = 40;

            var va = new Vector<double>();
            for (double a = 0.0; a <= 10.0; a+= 1.0) va.Push(a);
            var vb = new Vector<double>();
            for (double a = 0.0; a <= 10.0; a+= 1.0) vb.Push(a);

            Debug.WriteLine($"va == vb is {va == vb}");
            Debug.WriteLine($"va != vb is {va != vb}");

            va.Push(33);
            Debug.WriteLine("va.Push(33)");
            Debug.WriteLine($"va == vb is {va == vb}");
            Debug.WriteLine($"va != vb is {va != vb}");

            Debug.WriteLine("\n-------->>>>>>>>\n");
            //Application.EnableVisualStyles();
            //Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new Form1());
        }
    }
}
