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
         long iteration = 0;
         // Бесконечный цикл
         while (true)
         {
            iteration++;
            double result = input * iteration;
            Console.WriteLine("Итерация: {0}, Результат: {1};", iteration, result);
         }
      }
   }
}