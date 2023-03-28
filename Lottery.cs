using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork_6_lottery_
{
    public static class Lottery
    {
        public static List<int> Emit(int number)   // повертає list унікальних чисел від 1 до number
        {
            var lotteryNumbers = new List<int>();
            for (int i = 1; i <= number; i++)
            {
                lotteryNumbers.Add(i);
            }
            var random = new Random();   //Random - потрібен для генерування випадкових чисел
            for (int i = lotteryNumbers.Count - 1; i > 0; i--) // зворотній цикл
            {
                int j = random.Next(i + 1);   // j - випадкове число
                int temp = lotteryNumbers[i];
                lotteryNumbers[i] = lotteryNumbers[j];
                lotteryNumbers[j] = temp;
            }
            return lotteryNumbers;
        }
    }
}
