﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Processor
{
    internal class Kernel
    {
        private int[,] kernel1;
        private int[,] kernel2;
        private int[,] kernel3;
        private int[,] kernel4;
        private int[,] kernel5;
        private int[,] kernel6;
        private int[,] kernel7;
        private int[,] kernel8;
        private int[,] kernel9;
        private int[,] kernel10;
        private int[,] hmtKernel1;
        private int[,] hmtKernel2;
        private int[,] hmtKernel3;
        private int[,] hmtKernel4;
        private int[,] hmtKernel5;
        private int[,] hmtKernel6;
        private int[,] hmtKernel7;
        private int[,] hmtKernel8;
        private int[,] hmtKernel9;
        private int[,] hmtKernel10;
        private int[,] hmtKernel11;
        private int[,] hmtKernel12;

        public Kernel()
        {
            kernel1 = new int[,] { { 0, 0, 0 }, { 0, 1, 1 }, { 0, 0, 0 } };
            kernel2 = new int[,] { { 0, 0, 0 }, { 0, 1, 0 }, { 0, 1, 0 } };
            kernel3 = new int[,] { { 1, 1, 1 }, { 1, 1, 1 }, { 1, 1, 1 } };
            kernel4 = new int[,] { { 0, 1, 0 }, { 1, 1, 1 }, { 0, 1, 0 } };
            kernel5 = new int[,] { { 0, 0, 0 }, { 0, 1, 1 }, { 0, 1, 0 } };
            kernel6 = new int[,] { { 0, 0, 0 }, { 0, -1, 1 }, { 0, 1, 0 } };
            kernel7 = new int[,] { { 0, 0, 0 }, { 1, 1, 1 }, { 0, 0, 0 } };
            kernel8 = new int[,] { { 0, 0, 0 }, { 1, -1, 1 }, { 0, 0, 0 } };
            kernel9 = new int[,] { { 0, 0, 0 }, { 1, 1, 0 }, { 1, 0, 0 } };
            kernel10 = new int[,] { { 0, 1, 1 }, { 0, 1, 0 }, { 0, 0, 0 } };
            hmtKernel1 = new int[,] { { 1, 0, 0 }, { 1, -1, 0 }, { 1, 0, 0 } };
            hmtKernel2 = new int[,] { { 1, 1, 1 }, { 0, -1, 0 }, { 0, 0, 0 } };
            hmtKernel3 = new int[,] { { 0, 0, 1 }, { 0, -1, 1 }, { 0, 0, 1 } };
            hmtKernel4 = new int[,] { { 1, 0, 0 }, { 1, -1, 0 }, { 1, 0, 0 } };
            hmtKernel5 = new int[,] { { -1, -1, -1 }, { 0, 1, 0 }, { 1, 1, 1 } };
            hmtKernel6 = new int[,] { { 0, 0, 0 }, { 1, 1, 0 }, { 1, 1, 0 } };
            hmtKernel7 = new int[,] { { 1, 0, 0 }, { 1, 1, 0 }, { 1, 0, 0 } };
            hmtKernel8 = new int[,] { { 1, 1, 0 }, { 1, 1, 0 }, { 0, 0, 0 } };
            hmtKernel9 = new int[,] { { 1, 1, 1 }, { 0, 1, 0 }, { 0, 0, 0 } };
            hmtKernel10 = new int[,] { { 0, 1, 1 }, { 0, 1, 1 }, { 0, 0, 0 } };
            hmtKernel11 = new int[,] { { 0, 0, 1 }, { 0, 1, 1 }, { 0, 0, 1 } };
            hmtKernel12 = new int[,] { { 0, 0, 0 }, { 0, 1, 1 }, { 0, 1, 1 } };
        }

        public int[,] GetKernel(int number)
        {
            switch(number)
            {
                case 1:
                    return kernel1;
                case 2:
                    return kernel2;
                case 3:
                    return kernel3;
                case 4:
                    return kernel4;
                case 5:
                    return kernel5;
                case 6:
                    return kernel6;
                case 7:
                    return kernel7;
                case 8:
                    return kernel8;
                case 9:
                    return kernel9;
                case 10:
                    return kernel10;
                case 11:
                    return hmtKernel1;
                case 12:
                    return hmtKernel2;
                case 13:    
                    return hmtKernel3;
                case 14:
                    return hmtKernel4;
                case 15:
                    return hmtKernel5;
                case 16:
                    return hmtKernel6;
                case 17:
                    return hmtKernel7;
                case 18:
                    return hmtKernel8;
                case 19:
                    return hmtKernel9;
                case 20:
                    return hmtKernel10;
                case 21:
                    return hmtKernel11;
                case 22:
                    return hmtKernel12;
                default:
                    {
                        //TODO: Think of a better way to do this
                        Console.WriteLine("No matching mask");
                        return kernel1;
                    }
            }
        }
    }
}
