using System;

// Вариант с передачей результата в другой метод на каждой итерации

namespace CycleWhileReturnThree
{
   class Program
   {
      static void Main()
      {
         double input = 2048;
         CalculateAndProcess(input);
      }

      // Основной метод расчета и обработки
      private static void CalculateAndProcess(double input)
      {
         int iteration = 0;

         // Бесконечный цикл
         while (true)
         {
            iteration++;
            double result = input * iteration;

            // Выводим результат в консоль
            Console.Write(result);
            Console.WriteLine("\nИтерация: {0}", iteration);

            // Передаем результат в другой метод
            ProcessResult(result);
         }
      }

      // Метод для обработки результата
      private static void ProcessResult(double value)
      {
         // Здесь можно добавить любую логику обработки
         Console.WriteLine("Обрабатываем значение: {0}", value);

         // Пример простой обработки - проверка на четность
         if (value % 2 == 0)
         {
            Console.WriteLine("Значение четное");
         }
         else
         {
            Console.WriteLine("Значение нечетное");
         }
      }
   }
}