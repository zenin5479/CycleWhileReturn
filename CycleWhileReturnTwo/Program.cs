using System;

// Вариант без передачи результата на каждой итерации

namespace CycleWhileReturnTwo
{
   class Program
   {
      static void Main()
      {
         double input = 2048;
         Calculate(input);
      }

      private static void Calculate(double input)
      {
         // Используем long, чтобы избежать переполнения int
         long iterations = 0;
         // Бесконечный цикл
         while (true)
         {
            iterations++;
            double result = input * iterations;
            Console.WriteLine("Итерация: {0}, Результат: {1};", iterations, result);
         }
      }
   }
}