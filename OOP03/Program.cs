using System;

namespace OOP03


{
    #region Q1
    public class Calculator
    {
        static int plusoprator(int x, int y)
        {
            return x + y;
        }
        static int plusoprator(int x, int y, int z)
        {
            return x + y + z;
        }
        static double plusoprator(double x, double y, double z)
        {
            return x + y + z;
        }
        #endregion

        #region Q2
        public class Rectangle
        {
            public int width { get; set; }
            public int height { get; set; }
            public Rectangle()
            {
                width = 0;
                height = 0;

            }
            public Rectangle(int w, int h)
            {
                w = width;
                h = height;
            }
            public Rectangle(int x)
            {
                x = height;
                x = width;
            }
        }
        #endregion
        internal class Program
        {
            static void Main()
            {

            }
        }
    }
}
