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
            public static complex operator +(complex c1, complex c2)
            {
                return new complex(c1.Real + c2.Real, c1.Imagein + c2.Imagein);
            }
            public static complex operator -(complex c1, complex c2)
            {
                return new complex(c1.Real - c2.Real, c1.Imagein - c2.Imagein);
            }
        }
        #endregion

        #region Q4
        public class Employee
        {
            public virtual void work()
            {
                 Console.WriteLine("Employee is  working");

            }
            public class Manager : Employee
            {
                 public override void work()
                {
                    Console.WriteLine("Manager is managing");

                }
            }
            #endregion
            #region Q5 
            public class BaseClass
            {
                public virtual void DisplayMessage()
                {
                    Console.WriteLine("Message from BaseClass");
                }

            }
            public class DerivedClass1 : BaseClass
            {
                public override void DisplayMessage()
                {
                    Console.WriteLine("Message DerivedClass");
                }

            }
            public class DerivedClass2 :BaseClass
            {
                public override void DisplayMessage()
                {
                    Console.WriteLine("Message DerivedClass2");
                }
            }
            #endregion

            #region Q1 p2
            public class duration
            {
                public double sec { set; get; }
                public double min { set; get; }
                public double hour { set; get; }

                public duration(double s, double m, double h)
                {
                    sec = s;
                    min = m;
                    hour = h;
                }

                public void Display()
                {
                    Console.WriteLine($"{hour}h {min}m {sec}s");
                }
            }
            #endregion

            #region Q2 p2
           public class person
            {
                public string fname { get; set; }
                public string lname { set; get; }

                public override string ToString()
                {
                    return $"{fname}{lname}";
                }
                public override int GetHashCode()
                {
                    return HashCode.Combine(fname,lname);
                }
            }
            #endregion

            #region Q3 p2
            public class Duration2
            {
                public int Hours { get; private set; }
                public int Minutes { get; private set; }
                public int Seconds { get; private set; }

                public Duration2(int hours, int minutes, int seconds)
                {
                    Hours = hours;
                    Minutes = minutes;
                    Seconds = seconds;
                }

            
                public Duration2(int totalSeconds)
                {
                    Hours = totalSeconds / 3600;
                    totalSeconds %= 3600;
                    Minutes = totalSeconds / 60;
                    Seconds = totalSeconds % 60;
                }
                #endregion
                internal class Program
            {
                static void Main()
                {
                    #region Q4
                    Employee emp = new Employee();
                    emp.work();
                    Manager mgr = new Manager();
                    mgr.work();
                    #endregion

                    #region Q5
                    BaseClass b=new BaseClass();
                    b.DisplayMessage();

                    DerivedClass1 d=new DerivedClass1();
                    d.DisplayMessage();

                    DerivedClass2 e=new DerivedClass2();
                    e.DisplayMessage();
                    #endregion

                    #region Q1 p2
                    duration t=new duration(2,4,6);
                    t.Display();
                    #endregion
                }
            }
        }
    }
}

