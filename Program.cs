namespace C__Basics_Session_03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Q1 : Write a program that takes a number from the user then print yes if that number can be divided by 3 and 4 otherwise print no
            Console.WriteLine("enter number :");
            int x=int.Parse(Console.ReadLine());

            if(x%3==0 &&  x%4==0)
            {
                Console.WriteLine("YES");
            }
            else
            {
                Console.WriteLine("NO");
            }
            #endregion
        }
    }
}
