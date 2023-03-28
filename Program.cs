
using HomeWork_6_lottery_;
using System;
using System.Collections.Generic;
using System.Linq;


public class Program
{
    public static void Main()
    {
        var draws = new List<List<int>>();  // list який міститьрозіграші лотереї
        for (int i = 0; i < 100; i++)  // генерує новий  розіграш
        {
            var draw = Lottery.Emit(100);
            draws.Add(draw);
        }
        var neverAppeared = StatOperations.NeverAppeared(draws); // числа які ніколи не попадались протягом 100 розіграшів 
        Console.WriteLine("Numbers that never appeared in 100 draws: " + string.Join(", ", neverAppeared));
        var mostAppeared = StatOperations.MostAppeared(draws, 5);  // топ 5 чисел які частіше всього випадали протягом розіграшу 
        Console.WriteLine("Top 5 most appeared numbers in 100 draws: " + string.Join(", ", mostAppeared));
    }
}
