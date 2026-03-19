// Вариант с передачей результата в другой метод на каждой итерации

using System;
using System.Collections.Generic;

namespace CycleWhileReturnFour
{
   internal class Program
   {
      static void Main()
      {
         double inputValue = 1024;

         // Перебираем результаты каждой итерации
         foreach (var result in CalculateConsole(inputValue))
         {
            Console.WriteLine($"Полученный результат: {result}");
         }
      }

      private static IEnumerable<double> CalculateConsole(double input)
      {
         int iterationCount = 0;

         while (iterationCount < 10) // Ограничение в 10 итераций
         {
            iterationCount++;
            double result = input * iterationCount;
            Console.WriteLine($"Итерация: {iterationCount}, Результат: {result}");
            yield return result; // Возвращаем результат на каждой итерации
         }
      }
   }
}