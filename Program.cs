using System.Transactions;

namespace C__Basics_Session_03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Q1 : Write a program that takes a number from the user then print yes if that number can be divided by 3 and 4 otherwise print no
            //Console.WriteLine("enter number :");
            //int x=int.Parse(Console.ReadLine());

            //if(x%3==0 &&  x%4==0)
            //{
            //    Console.WriteLine("YES");
            //}
            //else
            //{
            //    Console.WriteLine("NO");
            //}
            #endregion

            #region Q2: Write a program that allows the user to insert an integer then print negative if it is negative number otherwise print positive.

            //Console.WriteLine("enter number :");
            //int x = int.Parse(Console.ReadLine());

            //if (x >=0)
            //{
            //    Console.WriteLine("positive");
            //}
            //else
            //{
            //    Console.WriteLine("negative");
            //}
            #endregion

            #region Q3: Write a program that takes 3 integers from the user then prints the max element and the min element.
            //Console.WriteLine("enter three number  :");
            //int x= int.Parse(Console.ReadLine());
            //int y= int.Parse(Console.ReadLine());   
            //int z= int.Parse(Console.ReadLine());
            //int MaxNumber ,MinNumber;

            ////Fisrt Way To solve 
            //MaxNumber = Math.Max(Math.Max(x, y), z);
            //MinNumber = Math.Min(Math.Min(x, y), z);
            //Console.WriteLine($"MAX number is {MaxNumber} and Min Number is {MinNumber}");
            ////Second way To solve 
            //if (x > y)
            //{
            //    if (x > z)
            //    {
            //        MaxNumber = x;
            //        MinNumber = (y > z) ? z : y;
            //    }
            //    else
            //    {
            //        MaxNumber = z;
            //        MinNumber = y;
            //    }
            //}
            //else if (y > z)
            //{
            //    MaxNumber = y;
            //    MinNumber = (x > z) ? z : x;
            //}
            //else
            //{
            //    MaxNumber = z;
            //    MinNumber = x;
            //}
            //Console.WriteLine($"Max number is : {MaxNumber} and min number is {MinNumber}");
            #endregion

            #region Q4: Write a program that allows the user to insert an integer number then check If a number is even or odd.
            Console.WriteLine("enter number :");

            int x = int.Parse(Console.ReadLine());

            if (x %2== 0)
            {
                Console.WriteLine("Even");
            }
            else
            {
                Console.WriteLine("ODD");
            }
            #endregion
        }
    }
}
