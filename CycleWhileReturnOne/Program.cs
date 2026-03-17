using System;

namespace CycleWhileReturnOne
{
   class Program
   {
      static void Main()
      {
         double inputValue = 2048;
         Calculate(inputValue);
      }

      private  void Calculate(double input)
      {
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
   }
}