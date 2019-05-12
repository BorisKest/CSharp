using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Laba1SvenKestner
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
    }
    class Sven
    {
        public Sven()
        {

        }
        // -------------------------------------------------------------------VAR-----------------------------------------------------------
        public double x0 = 2, tStep = 1,  x1=0, Delta;
        private int k=0;
        public string a0, b0;
        static public String g;

        //----------------------------------------------------------------------------------------------------------------------------------


        public string SvenFunc()
        {
            for (int i = 0; i <= 3; i++)
            {
                switch (i)
                {
                    case 1:
                        g = g + "case 1 = " + Convert.ToString(ActFunc(x0 - tStep));
                        break;
                    case 2:
                        g = g + "case 2 = " + Convert.ToString(ActFunc(x0));
                        break;
                    case 3:
                        g = g + "case 3 = " + Convert.ToString(ActFunc(x0 + tStep));
                        break;
                }
            }
            return g;
        }

        static double ActFunc(double temp)
        {
            return Math.Pow( temp,2 )+2*temp+ 3;
        }
        // Что тут происходит одному товарищу Свену известно 
        public string TempFunc()
        {
            double[] x = new double[10];

            if (ActFunc(x0 - tStep) >= ActFunc(x0) && ActFunc(x0) <= ActFunc(x0 + tStep)) //1
            {

                a0 = Convert.ToString(x0 - tStep);
                b0 = Convert.ToString(x0 + tStep);
                return a0 + " " +b0 ;
            }



                if (ActFunc(x0 - tStep) <= ActFunc(x0) && ActFunc(x0) >= ActFunc(x0 + tStep))//22 no exit
                {
                    return "функция не является унимодальной, а требуемый интервал неопределенности не может быть найден,рекомендуется задать другую начальную точку x0";
                }

            
            for (; ; k++) 
            {
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
                        x[1] = x0;
                    }
                     if (Delta == -tStep)
                    {
                        x[0] = xF;
                    }
                    break;
                   
                }
            }
            return " [ " + Convert.ToString( x[0]) + "  : " + Convert.ToString(x[1] )+ " ]";
        }
    }
}
