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

         // Получает IEnumerable
         IEnumerable<double> results = CalculateConsole(input);

         // Получает перечислитель
         IEnumerator<double> enumerator = results.GetEnumerator();

         // Использует while
         while (enumerator.MoveNext())
         {
            double result = enumerator.Current;
            Console.WriteLine("Полученный результат: {0}", result);
         }

         // Освобождает ресурсы
         enumerator.Dispose();
      }

      private static IEnumerable<double> CalculateConsole(double input)
      {
         int iteration = 0;

         // Ограничение в 10 итераций
         while (iteration < 10)
         {
            iteration++;
            double result = input * iteration;
            Console.WriteLine("Итерация: {0}, Результат: {1}", iteration, result);
            // Возвращает результат на каждой итерации
            yield return result;
         }
      }
   }
}