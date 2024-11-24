using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 圓周率作業
{
    internal class Program
    {
        public static int n = -1;
        static void Main(string[] args)
        {
            //1112410001_蔡嘉成
            Console.WriteLine("請輸入圓半徑");
            double r = double.Parse(Console.ReadLine());
            Console.WriteLine("請輸入圓週率的精準度");
            Console.WriteLine("因為個人電腦計算能力有限,請輸入4~15的整數");
            n = int.Parse(Console.ReadLine());
            double pi = CountPi(n);
            if (pi == -1) return;
            else
            {
                Console.WriteLine("圓周率的精準度:" + n);
                Console.WriteLine("圓周率為:{0:g}",pi);
                Console.WriteLine("圓周長為:{0:g}",GetCircumference(r));
                Console.WriteLine("圓面積為:{0:g}", GetCircleArea(r));
                Console.ReadLine();
            }
        }
        static double CountPi(int n)//計算圓周率
        {
            double pi = 0;
            double result = 0;
            double sum = 0;
            if (n >=4 && n<=15)
            {
                for (int i = 0; i < n; i++)
                {
                    result = Math.Pow(-1, i) / (2 * i + 1);
                    sum = sum + result;
                }
                pi =  4*sum;
            }
            else pi = -1;
            return (double)pi;
        }
        static double GetCircumference(double R)//計算圓週
        {
            double CF = 0;
            CF = CountPi(n)*(2*R);//直徑?半徑?
            //Console.WriteLine(CF);
            return (double)CF;
        }
        static double GetCircleArea(double r)//圓面積
        {
            double CA = 0;
            CA= CountPi(n)*r*r;
            return (double)CA;
        }
    }
}
