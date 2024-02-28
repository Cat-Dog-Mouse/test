
using System;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace test // 注意：实际的命名空间取决于项目名称。
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number = 5;
            YH test = new YH(number);
            list.change(10);// 进行第二次调用以演示 data 的保留
        }
    }
    public class list { 
        public static void change(int num)
    {
            List<int> Array = new List<int>();
            // 显示有序数组中的元素
            int m,n;
            m = 1;
            n = num;
            for (;num >0; num--)
            {
                Array.Add(num);

            }
            foreach (var number in Array)
            {
                Console.Write(" ");
                Console.Write(number);
            }
            Console.WriteLine(" ");
            //***************
            int i, j, min;
            for (i = 0; i < n - 1; i++)
            {
                min = i;
                for (j = i + 1; j < n; j++)
                {
                    if (Array[min] > Array[j])
                    {
                        min = j;
                    }
                }
                    int TEMP = Array[min];
                    Array[min] = Array[i];
                    Array[i] = TEMP;
               
            }
            foreach (var number in Array)
            {
                Console.Write(" ");
                Console.Write(number);
            }
            //***************
            Console.WriteLine("Array: ");
            int index = 0;
            while (Array.Count > 0)
            { 
                if (index + m < Array.Count)
                {
                    index = index + m;
                   
                }
                else
                {
                    index = (index + m) % Array.Count;
                }
                Console.WriteLine("Array num:{0}", Array[index]);
                Array.RemoveAt(index);
                foreach (var number  in Array)
                {
                    Console.WriteLine(number);
                }
            }


    }
        
}
    public class YH
    {
        private int data = 0; 
        public YH(int num)
        {
            int rows = num; 

           
            int[][] triangle = new int[rows][];

           
            for (int i = 0; i < rows; i++)
            {
                triangle[i] = new int[i + 1];
                triangle[i][0] = 1;
                triangle[i][i] = 1; 

                for (int j = 1; j < i; j++)
                {
                    if (i > 0 && j > 0)
                    {
                        triangle[i][j] = triangle[i - 1][j - 1] + triangle[i - 1][j];
                    }
                }
            }
            Console.WriteLine("杨辉三角：");
            for (int i = 0; i < rows; i++)
            {
                // 打印空格以使杨辉三角呈现对齐效果
                for (int k = 0; k < (rows-i); k++)
                {
                    Console.Write(" ");
                }
                for (int j = 0; j <= i; j++)
                {
                    Console.Write(triangle[i][j] + " ");
                }

                Console.WriteLine();
            }
        }
    }
}