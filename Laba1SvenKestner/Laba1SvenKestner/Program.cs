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
        public Double x0 = 2.1, tStep = 0.001, temp, x1, Delta;
        private int k;
        public string a0,b0;
        //double[] x;
        static public String g;
        bool flag = false;
       
        //----------------------------------------------------------------------------------------------------------------------------------


        public void SvenFunc()
        {
            
            // x0 - tStep, x0, x0 + tStep;
            for (int i = 0; i < 3; i++)
            {
                switch (i)
                {
                    case 1:
                        g = g + "case1 " + Convert.ToString(ActFunc(x0 - tStep, 0));
                        break;
                    case 2:
                        g = g + "case2 " + Convert.ToString(ActFunc(x0, 0));
                        break;
                    case 3:
                        g = g + "cas3 " + Convert.ToString(ActFunc(x0 + tStep, 0));
                        break;

                }

            }
        }

        static double ActFunc(double temp, double result)
        {
            result = temp * 2;
            return result;
        }

        public string TempFunc()
        {
            if (ActFunc(x0 - tStep, 0) >= ActFunc(x0, 0))//1
            {
                if (ActFunc(x0, 0) <= ActFunc(x0 + tStep, 0))
                {
                    a0 = Convert.ToString(x0 - tStep);
                    b0 = Convert.ToString(x0 + tStep);
                    
                }
                 if (ActFunc(x0, 0) >= ActFunc(x0 + tStep, 0))//12
                {
                    a0 = Convert.ToString(x0);
                    x1 = x0 + tStep;
                    k = 1;
                    Delta = tStep;
                   
                }
                
            }
             if (ActFunc(x0 - tStep, 0) <= ActFunc(x0, 0))//2
            {
                if (ActFunc(x0, 0) <= ActFunc(x0 + tStep, 0))//21 
                {
                    Delta = -tStep;
                    b0 = Convert.ToString(x0);
                    x0 -= tStep;
                    

                }
                 if (ActFunc(x0, 0) >= ActFunc(x0 + tStep, 0))//22 no exit
                {
                     return "функция не является унимодальной, а требуемый интервал неопределенности не может быть найден,рекомендуется задать другую начальную точку x0";
                }
               
            }
            
            while   ( flag == false )
            {
                
                k = 0;
                k++;
                double[] x = new double[8];

                if (ActFunc(x[k + 1], .0) < ActFunc(x[k], .0))
                {
                    if (Delta == tStep)
                    {
                        a0 = Convert.ToString(x[k]);
                        k++;
                        
                    }
                     if (Delta == -tStep)
                    {
                        b0 = Convert.ToString(x[k]);
                        k++;
                       
                    }
                    
                }
                 if (ActFunc(x[k + 1], 0) > ActFunc(x[k], 0))
                {
                    flag = true;
                    if (Delta == tStep)
                    {
                        b0 = Convert.ToString(x[k]);
                        k++;

                    }
                     if (Delta == -tStep)
                    {
                        a0 = Convert.ToString(x[k]);
                        k++;
                        
                    }
                    
                }
              
            }
            // x[k+1]= x[k] +2^k * Delta
            return a0 + ' ' + b0; ;
        }
    }
}
