using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork_6_lottery_
{
    public static class StatOperations
    {
        public static List<int> NeverAppeared(List<List<int>> draws)
        {
            var allNumbers = new List<int>();    // список усіх можливих чисел
            for (int i = 1; i <= draws[0].Count; i++)
            {
                allNumbers.Add(i);
            }
            var appearedNumbers = new List<int>();
            foreach (var draw in draws)
            {
                foreach (var number in draw)
                    if (!appearedNumbers.Contains(number))
                    {
                        appearedNumbers.Add(number);
                        allNumbers.Remove(number);
                    }
            }
            return allNumbers; // вертає числа які ніколи не з'являлися у draws
        }

        public static List<int> MostAppeared(List<List<int>> draws, int topCount)
        {
            var allNumbers = new List<int>();
            for (int i = 1; i <= draws[0].Count; i++) // список всіх можливих чисел від 1 до кількості чисел у першому розіграші
            {
                allNumbers.Add(i);
            }
            var frequencyCounts = new Dictionary<int, int>(); //  dictionary, де ключ - число, а значення -  кількість зустрічей
            foreach (var draw in draws) // Проходимося по всіх розіграшах
            {
                foreach (var number in draw) // Проходимося по всіх числах у розіграші
                {
                    if (!frequencyCounts.ContainsKey(number)) // Якщо числа не було , то додаємо його в dictionary
                    {
                        frequencyCounts[number] = 0;
                    }
                    frequencyCounts[number]++; // додаються числа які зустрічаються в dictionary
                }
            }
            var topNumbers = frequencyCounts.OrderByDescending(pair => pair.Value).Take(topCount).Select(pair => pair.Key).ToList(); // топ числа які частіше зустрічаються в словнику
            return topNumbers;
        }
    }
}








