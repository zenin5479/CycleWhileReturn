using System;

namespace CycleWhileReturnOne
{
   class Program
   {
      static void Main()
      {
         double input = 2048;

         // Используем long, чтобы избежать переполнения int
         long iterations = 0;

         // Бесконечный цикл
         while (true)
         {
            iterations++;
            double result = input * iterations;
            Console.WriteLine("Итерация: {0}", result);
         }
      }

      private static void Calculate(double input)
      {
      }
   }
}