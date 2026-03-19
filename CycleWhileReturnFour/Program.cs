using System;
using System.Collections.Generic;

// Вариант с передачей результата в другой метод на каждой итерации

namespace CycleWhileReturnFour
{
   internal class Program
   {
      static void Main()
      {
         double input = 1024;

         // Перебираем результаты каждой итерации
         foreach (var result in CalculateConsole(input))
         {
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
            Console.WriteLine($"Итерация: {iterationCount}, Результат: {result}");
            
            yield return result; // Возвращаем результат на каждой итерации
         }
      }
   }
}