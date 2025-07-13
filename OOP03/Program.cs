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

        #region Q3
        public class complex
        {
            public int Real { set; get; }
            public int Imagein { set; get; }

            public complex(int real, int imagein)
            {
                Real = real;
                Imagein = imagein;

            }
           public static complex operator +(complex c1,complex c2)
            {
                return new complex(c1.Real + c2.Real, c1.Imagein + c2.Imagein);
            }
            public static complex operator -(complex c1, complex c2)
            {
                return new complex(c1.Real - c2.Real, c1.Imagein - c2.Imagein);
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

