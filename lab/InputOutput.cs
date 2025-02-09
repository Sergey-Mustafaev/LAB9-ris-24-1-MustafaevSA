using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab9
{
    public class InputOutput
    {
        private static CultureInfo _culture = CultureInfo.CreateSpecificCulture("ru-Ru");

        private static CultureInfo Culture
        {
            get => _culture;
            set { }
        }

        public static int GetNumber(int minValue = Int32.MinValue, int maxValue = Int32.MaxValue)
        {
            int result = 0;
            bool isConvert = false;
            while (!isConvert)
            {
                try
                {
                    result = int.Parse(Console.ReadLine(), Culture);
                }
                catch (ArgumentNullException)
                {
                    Console.WriteLine("Не получилось получит ввод.");
                    continue;
                }
                catch (FormatException)
                {
                    Console.WriteLine("Ввод не является числом или число нецелое.");
                    continue;
                }
                catch (OverflowException)
                {
                    Console.WriteLine("В числе слишком много цифр.");
                    continue;
                }
                catch
                {
                    Console.WriteLine("Возникла непредвиденная ошибка.");
                    continue;
                }
                if (result < minValue)
                {
                    Console.WriteLine($"Число не входит в ОДЗ, оно меньше чем {minValue}.");
                    continue;
                }
                else if (result > maxValue)
                {
                    Console.WriteLine($"Число не входит в ОДЗ, оно больше чем {maxValue}.");
                    continue;
                }
                else
                {
                    isConvert = true;
                }
            }
            return result;
        }
        
        public static void Message(params object[] args)
        {
            foreach (object obj in args)
            {
                Console.Write(obj.ToString());
            }
            Console.WriteLine();
        }

        public static void MessageWithoutEndLine(params object[] args)
        {
            foreach (object obj in args)
            {
                Console.Write(obj.ToString());
            }
        }
    }
}
