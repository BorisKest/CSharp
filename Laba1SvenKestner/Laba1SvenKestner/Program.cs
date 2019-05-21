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
        public Double x0 = 1, tStep = 1, temp, x1, Delta;
        private int k;
        public string a0,b0;
        static public String g;
        bool flag = false;
       
        //----------------------------------------------------------------------------------------------------------------------------------


        public string SvenFunc()
        {
            
            // x0 - tStep, x0, x0 + tStep;
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
            return 25 / 2 *temp ;
        }

        public string TempFunc()
        {
            double[] x = new double[100];
            while (flag == false)
            {
                if (ActFunc(x0 - tStep) >= ActFunc(x0)) //1
                {
                    if (ActFunc(x0) <= ActFunc(x0 + tStep))//11
                    {
                        a0 = Convert.ToString(x0 - tStep);
                        b0 = Convert.ToString(x0 + tStep);
                        return "a0 = " + a0 + "b0=" + b0 + "  //11";

                    }
                    else if (ActFunc(x0) >= ActFunc(x0 + tStep))//12
                    {
                        a0 = Convert.ToString(x0);
                        x1 = x0 + tStep;
                        k = 1;
                        Delta = tStep;

                    }

                }
                else if (ActFunc(x0 - tStep) <= ActFunc(x0))//2
                {
                    if (ActFunc(x0) <= ActFunc(x0 + tStep))//21 
                    {
                        Delta = -tStep;
                        b0 = Convert.ToString(x0);
                        x0 -= tStep;

                    }
                    else if (ActFunc(x0) >= ActFunc(x0 + tStep))//22 no exit
                    {
                        return "функция не является унимодальной, а требуемый интервал неопределенности не может быть найден,рекомендуется задать другую начальную точку x0";
                    }

                }

                x[k + 1] = x[k] + Math.Pow(2, k) * Delta;
                k++;


                if (ActFunc(x[k + 1]) < ActFunc(x[k]))
                {
                    if (Delta == tStep)
                    {
                        a0 = Convert.ToString(x[k]);
                        k++;

                    }
                    else if (Delta == -tStep)
                    {
                        b0 = Convert.ToString(x[k]);
                        k++;

                    }

                }
                else if (ActFunc(x[k + 1]) > ActFunc(x[k]))
                {
                    flag = true;
                    if (Delta == tStep)
                    {
                        b0 = Convert.ToString(x[k]);
                        k++;

                    }
                    else if (Delta == -tStep)
                    {
                        a0 = Convert.ToString(x[k]);
                        k++;

                    }
                    
                }
            }
            return " [ "+ a0 + "  : " + b0 + " ]";
        }
                // x[k+1]= x[k] +2^k * Delta
               
        
    }
}
