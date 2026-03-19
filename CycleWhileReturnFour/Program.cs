// Вариант с передачей результата в другой метод на каждой итерации

using System;

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
   }
}