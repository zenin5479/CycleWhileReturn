

using System.Collections.Generic;

// Вариант с передачей результата в другой метод на каждой итерации

namespace CycleWhileReturnFive
{
   internal class Program
   {
      static void Main()
      {

      }

      private static List<double> CalculateConsole(double input)
      {
         List<double> results = new List<double>();
         int iterationCount = 0;

         while (iterationCount < 10)
         {
            iterationCount++;
            double result = input * iterationCount;
            results.Add(result);
         }

         return results;
      }
   }
}