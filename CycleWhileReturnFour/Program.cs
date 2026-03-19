using System;
using System.Collections.Generic;

// Вариант с передачей результата в другой метод на каждой итерации

namespace CycleWhileReturnFour
{
   internal class Program
   {
      static void Main()
      {
         double input = 2048;

         // Перебираем результаты каждой итерации
         foreach (double result in CalculateConsole(input))
         {
            Console.WriteLine("Полученный результат: {0}", result);
         }

         while (true)
         {
             IEnumerable<double> result = CalculateConsole(input);
            Console.WriteLine("Полученный результат: {0}", result);
         }
      }

      private static IEnumerable<double> CalculateConsole(double input)
      {
         int iterationCount = 0;

         // Ограничение в 10 итераций
         while (iterationCount < 10)
         {
            iterationCount++;
            double result = input * iterationCount;
            Console.WriteLine("Итерация: {0}, Результат: {1}", iterationCount, result);
            // Возвращаем результат на каждой итерации
            yield return result;
         }
      }
   }
}