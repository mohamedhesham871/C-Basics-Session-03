using System.Diagnostics;
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
            //Console.WriteLine("enter number :");

            //int x = int.Parse(Console.ReadLine());

            //if (x %2== 0)
            //{
            //    Console.WriteLine("Even");
            //}
            //else
            //{
            //    Console.WriteLine("ODD");
            //}
            #endregion

            #region Q5:Write a program that takes character from the user then if it is a vowel chars (a,e,I,o,u) then print (vowel) otherwise print (consonant)
            //Console.WriteLine("enter Char :");

            //string ss = Console.ReadLine();
            //switch (ss)
            //{
            //    case "a":
            //    case "e":
            //    case "I":
            //    case "o":
            //    case "u":
            //        Console.WriteLine("vowel");
            //        break;
            //    default: Console.WriteLine("consonant");
            //        break;

            //}
            #endregion

            #region Q6:Write a program that allows the user to insert an integer then print all numbers between 1 to that number.
            //Console.WriteLine("enter number :");

            //int x=int.Parse(Console.ReadLine());
            //for (int i = 1; i <= x; i++)
            //{
            //    Console.Write($"{i} ");
            //}

            #endregion

            #region Q7: Write a program that allows the user to insert an integer then  print a multiplication table up to 12
            //Console.WriteLine("enter number :");

            //int x = int.Parse(Console.ReadLine());
            //for (int i = 1; i <= 12; i++)
            //{
            //    Console.WriteLine($"{i} * {x} = {i * x}");
            //}

            #endregion
            #region Q8:Write a program that allows to user to insert number then print all even numbers between 1 to this number
            //Console.WriteLine("enter number :");

            //int x = int.Parse(Console.ReadLine());
            //for (int i = 2; i <= x; i++)
            //{
            //    if (i % 2 == 0) Console.Write($"{i} ");
            //}
            #endregion

            #region Q9: Write a program that takes two integers then prints the power
            //Console.WriteLine("enter Two  number :");

            //int x = int.Parse(Console.ReadLine());
            //int y = int.Parse(Console.ReadLine());
            //Console.WriteLine(Math.Pow(x, y));
            ////Another Solve 

            //long muti = 1;
            //for (int i=1;i<=y;i++)
            //{
            //    muti *= x ;

            //}
            //Console.WriteLine(muti);
            #endregion

            #region Q10:Write a program to enter marks of five subjects and calculate total, average and percentage
            ////i Will use Splie Function 
            //Console.WriteLine("enter Marks of five subjects ");
            //string x = Console.ReadLine();
            //int[] number = new int[5];
            //int Total=0;
            //double Avg, prec;
            //for(int i=0;i<5;i++)
            //{
            //    number[i] = int.Parse(x.Split(" ")[i]);
            //    Total += number[i];
            //}
            //Avg = (Total / 5);
            //prec = (Total/500.0) * 100;
            //Console.WriteLine($"Total number is {Total}\nthe Average is {Avg}\nthe Precentage is {prec}");
            #endregion
        }

    }
}
