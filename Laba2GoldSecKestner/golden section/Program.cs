using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace golden_section
{
    static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }

        class Sven // Found the [a:b]
        {
            public Sven()
            {

            }
            // -------------------------------------------------------------------VAR-----------------------------------------------------------
            private double x0 = 4, tStep = 1, x1, Delta ,A , B;
            private int k = 0;
            private string a0, b0;


            //----------------------------------------------------------------------------------------------------------------------------------




            static double ActFunc(double temp)
            {
                return 25 - 9 * temp;
            }
            // Что тут происходит одному товарищу Свену известно 
            public Tuple<double , double > TempFunc()
            {
                double[] x = new double[10];
                
                if (ActFunc(x0 - tStep) >= ActFunc(x0) && ActFunc(x0) <= ActFunc(x0 + tStep)) //1
                {

                    A = x0 - tStep;
                    B = x0 + tStep;
                    return new Tuple<double, double>( A,B);


                }

                if (ActFunc(x0 - tStep) >= ActFunc(x0) && ActFunc(x0) >= ActFunc(x0 + tStep))//12
                {
                    a0 = Convert.ToString(x0);
                    x[0] = x0;
                    x0 = x0 + tStep;
                    k = 1;
                    Delta = tStep;

                }



                if (ActFunc(x0 - tStep) <= ActFunc(x0) && ActFunc(x0) <= ActFunc(x0 + tStep))//2
                {

                    Delta = -tStep;
                    x[1] = x0;
                    x0 -= tStep;
                    k = 1;

                }

                if (ActFunc(x0 - tStep) <= ActFunc(x0) && ActFunc(x0) >= ActFunc(x0 + tStep))//22 no exit
                {
                    return new Tuple<double, double>(666,666);
                }


                for (; ; k++)
                {
                    double xF;
                    xF = x0 + Math.Pow(2, k) * Delta;
                    if (ActFunc(xF) < ActFunc(x0))
                    {
                        if (Delta == tStep)
                        {
                            x[0] = x0;
                            x0 = xF;
                        }
                        if (Delta == -tStep)
                        {
                            x[1] = x0;
                            x0 = xF;
                        }

                    }
                    if (ActFunc(xF) >= ActFunc(x0))
                    {

                        if (Delta == tStep)
                        {
                            A= x0;
                        }
                        if (Delta == -tStep)
                        {
                            B = xF;
                        }
                        break;

                    }
                }
                return new Tuple<double, double>(A,B) ;
            }
            // x[k+1]= x[k] +2^k * Delta

             

        }

        class GolsSec// use the gold section to opti.
        {
            //........................................................var.............................................
           static private double a, b, f;
           static double  eps = 0.001, z = (3 - Math.Sqrt(5)) / 2;
           static double x1 = a + z * (b - a), x2 = b - z * (b - a);
            //........................................................................................................
            Sven svan = new Sven();
            

            private GolsSec()
                {
                a = svan.TempFunc().Item1;
                b = svan.TempFunc().Item2;



                for (int i = 0; b - a > eps; i++)
                {
                    if (f(x1) <= f(x2))
                    {
                        b = x2;
                        x2 = x1;
                        x1 = a + b - x2;
                    }
                    else
                    {
                        a = x1;
                        x1 = x2;
                        x2 = a + b - x1;
                    }
                }
                    double x = (a + b) / 2;
                    Console.WriteLine(x);
                    Console.WriteLine(f(x));
            }
        }
    }
}
