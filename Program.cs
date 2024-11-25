using System;

namespace ActivitatsT2AC4
{
    public class Codi
    {
        public static int[] EnterQuantity()
        {
            const string StartMsg = "Quants valors vols?";
            Console.WriteLine(StartMsg);
            int quantity = Convert.ToInt32(Console.ReadLine());
            int[] arrayNums = new int[quantity];
            return arrayNums;
        }
        public static void Main()
        {
            const string QuestionMsg = "Quin valor vols introduir?";
            try
            {   
                int[] arrayNums = EnterQuantity();
                for (int i = 0; i < arrayNums.Length; i++)
                {
                    Console.WriteLine(QuestionMsg);
                    arrayNums[i] = Convert.ToInt32(Console.ReadLine());
                }
                for (int i = 0;i < arrayNums.Length; i++)
                {
                    Console.Write(arrayNums[i]);
                }
            }
            catch (Exception)
            {
                Console.WriteLine("Error");
            }
            
        }
    }
}