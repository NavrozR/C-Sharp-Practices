using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sunday { 

    public class Library
    {
        public void add()
        {
            int num1 = 100;
            int num2 = 500;
            int num3;
            num3 = num1 + num2;
            Console.WriteLine(num3);
        }

        public void sub()
        {
            int num1 = 100;
            int num2 = 50;
            int num3;
            num3 = num1 - num2;
            Console.WriteLine(num3);
        }
        public void multi()
        {
            int num1 = 100;
            int num2 = 50;
            int num3;
            num3 = num1 * num2;
            Console.WriteLine(num3);
        }
        public void divide()
        {
            int num1 = 100;
            int num2 = 50;
            int num3;
            num3 = num1 / num2;
            Console.WriteLine(num3);
        }
        public void OddEven()
        {
            int num = 9;
            if (num % 2 == 0)
            {
                Console.WriteLine("num is even");
            }
            else
            {
                Console.WriteLine("num is odd");
            }
        }
        public void OddEven2()

        {
            Console.WriteLine("enter the value");
            int a = Convert.ToInt32(Console.ReadLine());
            if (a > 5)
            {
                Console.WriteLine("value is greater tha 5");
            }
            else
            {
                Console.WriteLine("value is less than 5");
            }

        }

        public void OddEven3(int x, int y)
        {
            int c = (x + y);
            Console.WriteLine("value of c is " + c);
        }

        public int OddEven4(int x, int y)
        {
            int c = (x + y);
            Console.WriteLine("value of c is " + c);
            return c;
        }

        public void practice1()
        {
            int a = 10;
            Console.WriteLine("Value of a is " + a);
        }

        public void practice2(int a)
        {
            Console.WriteLine("Value of a is " + a);
        }

        public int practice3(int a)
        {
            Console.WriteLine("Value of a is " + a);
            return a;
        }

        public void practice4(int a)
        {
            a *= a;
            Console.WriteLine("value of a inside the function is " + a);
        }

        public void practice5()

        {
            int a = 3;
            int b;
            Console.WriteLine("enter value of b");
            b = Convert.ToInt32(Console.ReadLine());
            if (b == a)
            {
                Console.WriteLine("value of b is equal to value of value of a " + b);
            }
            else if (b > a)
            {
                Console.WriteLine("value of b is greater than value of a " + b);
            }
            else
            {
                switch (b)
                {
                    case 1:
                        Console.WriteLine("value of b is equal to " + b);
                        break;
                    case 2:
                        Console.WriteLine("value of b is equal to " + b);
                        break;
                }
            }
        }

        public void practice6()

        {
            int sum = 0;
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine(i);
                sum = sum + i;
            }
            Console.WriteLine(sum);
        }

        public void practice7()
        {
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    Console.WriteLine(i + "     " + j);
                }
            }
        }

        public void practice8()
        {
            int i = 0;
            while (i < 5)
            {
                Console.WriteLine("the value of i is " + i);
                i++;
            }

        }

        public void practice9()
        {
            int max = 10;
            int i = 1;
            while (i <= max)

            {
                Console.WriteLine("\n" + i);
                i++;
            }
        }

        public void practice10()
        {
            int max = 10;
            int i = 1;
            do
            {
                Console.WriteLine("\n" + i);
                i++;
            }
            while (i <= max);
        }

        public void practice11()
        {
            int max = 5;
            int i = 2;
            do
            {
                Console.WriteLine("\n" + i);
                i++;
                if (i > max)
                    break;
            }
            while (true);
        }

        public void practice12()
        {

            int i;

            for (i = 0; i < 20; i++)
            {
                if (i != 0 && i % 2 == 0)
                {
                    Console.WriteLine(i);
                }
            }
        }

        public string message(string a, double b)
        {
            string c = a + b;
            Console.WriteLine("the value of C " + c);
            return c;
        }


        public void PassGrade()

        {
            Console.WriteLine("Enter your marks");
            int num1 = int.Parse(Console.ReadLine());

            if (num1 >= 70)
            {
                Console.WriteLine("Marks are distinction " + num1);
            }
            else if ((num1 >= 60) && (num1 < 70))
            {
                Console.WriteLine("Marks are Firstclass " + num1);
            }
            else if ((num1 >= 50) && (num1 < 60))
            {
                Console.WriteLine("Marks are Secondclass " + num1);
            }
            else if ((num1 >= 40) && (num1 < 50))
            {
                Console.WriteLine("Marks are Passclass " + num1);
            }
            else
            {
                Console.WriteLine("You have failed ");
            }

        }


        public void SwitchLearn()
        {
            int a;
            int b = 0;
            int c;
            Console.WriteLine("Enter value of a");
            a = int.Parse(Console.ReadLine());

            {
                if (a <= 2)
                {
                    c = a + b;
                }
                else
                {
                    c = a * b;
                }
            }
            switch (c)
            {
                case 0:
                    Console.WriteLine("based on value of a entered, value of C is equal to 0");
                    break;
                case 1:
                    Console.WriteLine("based on value of a entered, value of C is equal to 0");
                    break;
                case 2:
                    Console.WriteLine("based on value of a entered, value of C is equal to 2");
                    break;
                default:
                    Console.WriteLine("based on value of a entered, value of C is lower than 0");
                    break;
            }

        }

        public double Student1percentage(double history1, double maths1, double english1)

        {
            double history;
            double maths;
            double english;
            double Percentagestudent1;
            history = history1;
            maths = maths1;
            english = english1;


            Console.WriteLine("Enter marks for history1");
            history1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter marks for maths1");
            maths1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter marks for english1");
            english1 = double.Parse(Console.ReadLine());

            Percentagestudent1 = (history1 + maths1 + english1) / 300 * 100;

            if ((history1 < 35) || (maths1 < 35) || (english1 < 35))

            {
                Console.WriteLine("Result is Fail " + history1 + maths1 + english1);
            }

            else

            {

                if (Percentagestudent1 < 60 && Percentagestudent1 > 35)
                {
                    Console.WriteLine("Grade is PASS %" + Percentagestudent1);
                }

                else if (Percentagestudent1 >= 60 && Percentagestudent1 < 70)
                {
                    Console.WriteLine("Grade is FIRST CLASS %" + Percentagestudent1);
                }

                else if (Percentagestudent1 >= 70)
                {
                    Console.WriteLine("Grade is DISTINCTION %" + Percentagestudent1);
                }

                else
                {
                    Console.WriteLine("Grade is FAIL");
                }

            }

            return Percentagestudent1;
        }


        public void ReverseLoop()
        {

            for (int i = 20; i >= 1; i--)
            {
                Console.WriteLine(i);
            }
        }

        public void OddEven5()
        {
            double i;
            Console.WriteLine("Enter the value of i");
            i = double.Parse(Console.ReadLine());

            if (i % 2 == 0)
            {
                Console.WriteLine("the number is even  " + i);
            }
            else
            {
                Console.WriteLine("the number is odd  " + i);
            }
        }

        public void TimeTable()
        {
            int a;
            int b;
            int c;
            string d = "X";
            string e = "=";
            Console.WriteLine("Enter the value of a");
            a = int.Parse(Console.ReadLine());

            for (b = 1; b <= 10; b++)

            {
                c = a * b;
                Console.WriteLine(string.Format("{0} {1} {2} {3} {4}", a, d, b, e, c));
            }
        }

        public void ArrayProject()
        {
            int[] num = { 8, 3, 4 };
            Console.WriteLine(num[0]);
            Console.WriteLine(num[0] + num[1] + num[2]);
            Console.WriteLine(num.Length);
            Console.WriteLine(num.Max());
            Array.Sort(num);
            foreach (int i in num)
            {
                Console.WriteLine(i);
            }

        }

        public void ArrayProject2()
        {
            int[] k = new int[15];
            int i;
            int j;

            for (i = 0; i < 15; i++)
            {
                k[i] = i + 50;
            }

            for (j = 0; j < 15; j++)
            {
                Console.WriteLine(k[j]);
            }

        }

        public void ListMethod()
        {
            List<int> intList = new List<int>();
            intList.Add(10);
            intList.Add(11);
            intList.Add(12);

            foreach (var item in intList)
            {
                Console.WriteLine(item);
            }

            intList.Remove(11);
            intList.RemoveAt(0);

            foreach (var item in intList)
            {
                Console.WriteLine(item);
            }

        }

        public int P10(int a, int b, int c) 
        {
            int d = (a + b + c);
            Console.WriteLine("Marks for Maths : " +a);
            Console.WriteLine("Marks for English : " +b);
            Console.WriteLine("Marks for Science : " +c);
           // Console.WriteLine("Total Marks : " + d);
            return d; 
        
        }

       
        
       




    }
}
