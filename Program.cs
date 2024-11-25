using System;

namespace ActivitatsT2AC4
{
    public class Codi
    {
        //Enter how much values want to enters
        public static int[] EnterQuantity()
        {
            const string StartMsg = "How much values you want to enter?";
            Console.WriteLine(StartMsg);
            int quantity = Convert.ToInt32(Console.ReadLine());
            int[] arrayNums = new int[quantity];
            return arrayNums;
        }
        public static int[] ChangeNumbers(int[] arrayNums)
        {
            //bubble sort
            for (int i = 0; i < arrayNums.Length; i++)
            {

                for (int j = 0; j < arrayNums.Length; j++)
                {
                    if (arrayNums[i] > arrayNums[j])
                    {
                        int aux = arrayNums[i];
                        arrayNums[i] = arrayNums[j];
                        arrayNums[j] = aux;
                    }
                }

            }
            return arrayNums;
        }
        public static void Main()
        {
            const string QuestionMsg = "What values you want to enter?";
            try
            {   
                //Array for the values
                int[] arrayNums = EnterQuantity();
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
                arrayNums = ChangeNumbers(arrayNums);
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