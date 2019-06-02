using System;
namespace Laba3Nelder
{
    public struct Program
    {
        //................var.............................

        
        //.................................................
    
    }
    class met
    {
        met()
        {

        }

        public int i;
        private double[] arrayX = new double[10];
        private double[] arrayY = new double[10];

        public double F(double tempX,double tempY)
        {
            return Math.Pow(tempY, 2) * tempX + 7;

        }

        public double MetFunc()
        {
            double y1, y2, y3;
            double best, good, worst;
            for (; i >= 3; i++)
            {
                Random rand = new Random();
                arrayX[i] = rand.Next(-10, 10);
                arrayY[i] = rand.Next(-10, 10);
            }
            y1 = F(arrayX[1],arrayY[1]);
            y2 = F(arrayX[2],arrayY[2]);
            y3 = F(arrayX[3],arrayY[3]);

            for (;;i++)
            {
                if (y1>y2&& y1>y3)
                   {
                    best = y1;
                    if (y2>y3)
                    {
                        good = y2;
                        worst = y3;
                    }
                    else
                    {
                        good = y3;
                        worst = y2;
                    }
                   }
                if (y2 > y1 && y2 > y3)
                {
                    best = y2;
                    if (y1 > y3)
                    {
                        good = y1;
                        worst = y3;
                    }
                    else
                    {
                        good = y3;
                        worst = y1;
                    }
                }
                if (y3 > y2 && y3 > y1)
                {
                    best = y3;
                    if (y2 > y1)
                    {
                        good = y2;
                        worst = y1;
                    }
                    else
                    {
                        good = y1;
                        worst = y2;
                    }
                }
            }

            return 12;
            
        }
        public double[] mid= new double;
        public double m(x)
        {
            mid = (arrayX[i] + arrayY[i]) / 2);
        }

       
    }
}
