using System;
using acfour_eudald_fajula_library;

namespace ActivitatsT2AC4
{
    public class Codi
    {   
        public static void Main()
        {
            const string QuestionMsg = "What values you want to enter?";
            const string StartMsg = "How much values you want to enter?";
            Console.WriteLine(StartMsg);
            try
            {
                int quantity = Convert.ToInt32(Console.ReadLine());
                int[] arrayNums = new int[quantity];
                //Entering the values to the array
                for (int i = 0; i < arrayNums.Length; i++)
                {
                    Console.WriteLine(QuestionMsg);
                    arrayNums[i] = Convert.ToInt32(Console.ReadLine());
                }
                //Showing the values of the array
                for (int i = 0;i < arrayNums.Length; i++)
                {
                    Console.Write($"{arrayNums[i]}, ");
                }
                arrayNums = MethodClasesAC4.ChangeNumbers(arrayNums);
                //Space
                Console.WriteLine("");
                //Show the values but descendats
                for (int i = 0; i < arrayNums.Length; i++)
                {
                    Console.Write($"{arrayNums[i]}, ");
                }
            }
            catch (Exception)
            {
                Console.WriteLine("Error");
            }
            
        }
    }
}