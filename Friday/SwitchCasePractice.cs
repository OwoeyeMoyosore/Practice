using System;



namespace SwitchCasePractice
{
    public class SwitchCasePractice
    {
        static void Main()
        {
            int Totalbookcost = 0;
            Console.WriteLine("1-Small, 2-Medium, 3-Large");
            Console.WriteLine("Enter your Choice");
            int Choice = int.Parse(Console.ReadLine());

            switch (Choice)
            {
                case 1:
                    Totalbookcost += 1;
                    break;
                case 2:
                    Totalbookcost += 1;
                    break;
                case 3:
                    Totalbookcost += 3;
                    break;
                case 4:
                    Totalbookcost += 4;
                    break;
                default:
                    Console.WriteLine("Your choice {0} is invalid", Choice);
                break;
            }
         
         Console.WriteLine("Your choice is {0) ", Choice);
        }
    }
}

