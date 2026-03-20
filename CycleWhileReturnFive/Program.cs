using System;
using System.Collections.Generic;

// Вариант с передачей результата в другой метод на каждой итерации

namespace CycleWhileReturnFive
{
   internal class Program
   {
      static void Main()
      {
         double input = 1024;
         List<double> results = CalculateConsole(input);

         for (int i = 0; i < results.Count; i++)
         {
            double result = results[i];
            Console.WriteLine("Результат: {0}", result);
         }
      }

      private static List<double> CalculateConsole(double input)
      {
         List<double> results = new List<double>();
         int iterationCount = 0;

         while (iterationCount < 10)
         {
            iterationCount++;
            double result = input * iterationCount;
            results.Add(result);
            Console.WriteLine("Итерация: {0}, Результат: {1}", iterationCount, result);
         }

         return results;
      }
   }
}