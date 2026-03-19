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

         // Используем while вместо foreach
         while (enumerator.MoveNext())
         {
            double result = enumerator.Current;
            Console.WriteLine($"Полученный результат: {result}");
         }

         // Важно освободить ресурсы
         enumerator.Dispose();
      }

      private static IEnumerable<double> CalculateConsole(double input)
      {
         int iterationCount = 0;

         // Ограничение в 10 итераций
         while (true)
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