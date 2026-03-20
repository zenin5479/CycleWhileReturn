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

         // Получаем IEnumerable
         IEnumerable<double> results = CalculateConsole(input);

         // Получаем перечислитель
         IEnumerator<double> enumerator = results.GetEnumerator();

         // Используем while
         while (enumerator.MoveNext())
         {
            double result = enumerator.Current;
            Console.WriteLine("Полученный результат: {0}", result);
         }

         // Освобождаем ресурсы
         enumerator.Dispose();
      }

      private static IEnumerable<double> CalculateConsole(double input)
      {
         int iteration = 0;

         // Бесконечный цикл
         while (true)
         {
            iteration++;
            double result = input * iteration;
            Console.WriteLine("Итерация: {0}, Результат: {1}", iteration, result);
            // Возвращаем результат на каждой итерации
            yield return result;
         }
      }
   }
}