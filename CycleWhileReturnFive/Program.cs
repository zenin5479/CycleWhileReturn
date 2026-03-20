using System;
using System.Collections.Generic;

// Вариант с передачей результата в другой метод

namespace CycleWhileReturnFive
{
   internal class Program
   {
      static void Main()
      {
         double input = 2048;

         // Список List<double> является более гибким решением
         List<double> results = CalculateConsole(input);
         int i = 0;
         while (i < results.Count)
         {
            double result = results[i];
            Console.WriteLine("Результат: {0}", result);
            i++;
         }
      }

      private static List<double> CalculateConsole(double input)
      {
         List<double> results = new List<double>();
         int iteration = 0;

         // Бесконечный цикл
         while (iteration < 10)
         {
            iteration++;
            double result = input * iteration;
            results.Add(result);

            // Выводим результат в консоль
            Console.WriteLine("Итерация: {0}, Результат: {1}", iteration, result);
            // Возвращаем результат на каждой итерации
            yield return result;
         }

         //return results;
      }
   }
}