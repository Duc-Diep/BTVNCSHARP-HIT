﻿using System;

namespace Bai4
{
    class Bai4
    {
        static void Main(string[] args)
        {
            Console.Write("Nhap so nguyen n: ");
            int n = int.Parse(Console.ReadLine());
            int s1=0, s2=1, s3=0;
            for(int i = 1; i <= n; i++)
            {
                s1 += i;
                s2 *= i;
                s3 += (i-1) * i;
            }
            Console.WriteLine("S1 = "+s1);
            Console.WriteLine("S2 = "+s2);
            Console.WriteLine("S3 = "+s3);
        }
    }
}
