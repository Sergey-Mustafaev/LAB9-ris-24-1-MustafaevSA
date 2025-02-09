using System;

namespace Lab9
{
    public class Program
    {
        static DialClock GetClockByTwoParams()
        {
            InputOutput.Message("Задайте время на часах.");
            InputOutput.MessageWithoutEndLine("Введите значение часа: ");
            int hours = InputOutput.GetNumber(0, 23);
            InputOutput.MessageWithoutEndLine("Введите значение минуты: ");
            int minutes = InputOutput.GetNumber(0, 59);
            return new DialClock(hours, minutes);
        }

        static void FillDialClockArray(ref DialClockArray clockArray)
        {
            int length = clockArray.Length;
            for (int i = 0; i < length; i++)
            {
                InputOutput.MessageWithoutEndLine("Часы номер ", i + 1, ": ");
                clockArray[i] = GetClockByTwoParams();
            }
            return;
        }

        static DialClock FindMaxAngleDialClock(ref DialClockArray clockArray)
        {
            if (clockArray is null || clockArray.Length < 1)
                return null;
            int currentIndex = 0;
            int length = clockArray.Length;
            for (int i = 1; i < length; i++)
            {
                if (clockArray[i].CalculateClockHandsAngle() > clockArray[currentIndex].CalculateClockHandsAngle())
                    currentIndex = i;
            }
            return clockArray[currentIndex];
        }

        static void Main(string[] args)
        {

            const int extremeValue = 10_000_000;
            InputOutput.Message("Начало демонстрации лабораторной работы.");
            DialClock clockAlpha = GetClockByTwoParams();
            InputOutput.Message("Значение поля \"Hours\" равно ", clockAlpha.Hours,
                ", значение поля \"Minutes\" равно ", clockAlpha.Minutes);
            InputOutput.Message("Вызов статической функции DialClock.CalculateClockHandsAngle(dialClock)",
                " возвращает угол между стрелками ", DialClock.CalculateClockHandsAngle(clockAlpha));
            InputOutput.Message("Вызов метода класса dialClock.CalculateClockHandsAngle() возвращает тот же угол ",
                clockAlpha.CalculateClockHandsAngle());
            InputOutput.Message("Было создано ", DialClock.ObjectCount, " объектов.");
            InputOutput.Message("++dialClock добавляет одну минуту: ", ++clockAlpha);
            InputOutput.Message("--dialClock вычитает одну минуту: ", --clockAlpha);
            InputOutput.Message("(bool)dialClock явное преобразование - Истина <=> Угол кратен 2,5: ", (bool)clockAlpha);
            int dialClockToInt = clockAlpha;
            InputOutput.Message("(int)dialClock неявное преобразование -");
            InputOutput.Message("    - сколько минут прошло с момента когда стрелки указывали на верхнее деление: ", dialClockToInt);
            InputOutput.MessageWithoutEndLine("Для следующих действий потребуется определить число: ");
            int numberAlpha = InputOutput.GetNumber(-extremeValue, extremeValue);
            InputOutput.Message("dialClock + number добавляет минуты: ", clockAlpha + numberAlpha);
            InputOutput.Message("number + dialClock аналогично, то есть сложение коммутативно: ", numberAlpha + clockAlpha);
            InputOutput.Message("dialClock - number вычитает минуты: ", clockAlpha - numberAlpha);
            InputOutput.Message("number - dialClock аналогично, но результат будет обратным: ", numberAlpha - clockAlpha);
            InputOutput.MessageWithoutEndLine("Для следующих действий потребуется определить вторые часы: ");
            DialClock clockBeta = GetClockByTwoParams();
            InputOutput.Message("Операторы сравнения сравнивают угол между стрелками у двух часов.");
            InputOutput.Message(clockAlpha, " > ", clockBeta, ": ", clockAlpha > clockBeta);
            InputOutput.Message(clockAlpha, " < ", clockBeta, ": ", clockAlpha < clockBeta);
            InputOutput.Message(clockAlpha, " >= ", clockBeta, ": ", clockAlpha >= clockBeta);
            InputOutput.Message(clockAlpha, " <= ", clockBeta, ": ", clockAlpha <= clockBeta);
            InputOutput.Message("Для дальнейшей демонстрации потребуется определить коллекцию.");
            InputOutput.Message("В целях демонстрации их длина будет ограничена 10-ью элементами.");
            InputOutput.MessageWithoutEndLine("Генерация на основе генераторе рандома, введите длину коллекции: ");
            int length = InputOutput.GetNumber(1, 10);
            DialClockArray clockArrayAlpha = new DialClockArray(length);
            InputOutput.Message("Сама коллекция: ", clockArrayAlpha);
            InputOutput.Message("Генерация на основе генераторе ввода, введите элементы коллекции:");
            DialClockArray clockArrayBeta = new DialClockArray(length);
            FillDialClockArray(ref clockArrayBeta);
            InputOutput.Message("Сама коллекция: ", clockArrayBeta);
            InputOutput.Message("Проверим глубокое копирование.");
            DialClockArray clockArrayGamma = new DialClockArray(clockArrayAlpha);
            InputOutput.Message("Коллекция-копия: ", clockArrayGamma);
            InputOutput.Message("Изменим оригинал.");
            clockArrayAlpha[0]++;
            InputOutput.Message("Изменённая коллекция: ", clockArrayAlpha);
            InputOutput.Message("Коллекция-копия ещё раз: ", clockArrayGamma);
            InputOutput.Message("Проверим индексирование.");
            DialClock clockGamma = new DialClock();
            InputOutput.MessageWithoutEndLine("Получим элемент с существующим индексом [0]: ");
            try
            {
                InputOutput.Message(clockArrayAlpha[0]);
                clockGamma = clockArrayAlpha[0] + 1000;
            }
            catch (Exception e)
            {
                InputOutput.Message(e.Message);
            }
            InputOutput.MessageWithoutEndLine("Изменим его и выведем: ");
            try
            {
                clockArrayAlpha[0] = clockGamma;
                InputOutput.MessageWithoutEndLine("исключение не возникло; ");
            }
            catch (Exception e)
            {
                InputOutput.MessageWithoutEndLine(e.Message, "; ");
            }
            try
            {
                InputOutput.Message(clockArrayAlpha[0]);
            }
            catch (Exception e)
            {
                InputOutput.Message(e.Message);
            }
            InputOutput.MessageWithoutEndLine("Получим элемент с не-существующим индексом [-1]: ");
            try
            {
                InputOutput.Message(clockArrayAlpha[-1]);
                clockGamma = clockArrayAlpha[-1] + 1000;
            }
            catch (Exception e)
            {
                InputOutput.Message(e.Message);
            }
            InputOutput.MessageWithoutEndLine("Изменим его и выведем: ");
            try
            {
                clockArrayAlpha[-1] = clockGamma;
                InputOutput.MessageWithoutEndLine("исключение не возникло; ");
            }
            catch (Exception e)
            {
                InputOutput.MessageWithoutEndLine(e.Message, "; ");
            }
            try
            {
                InputOutput.Message(clockArrayAlpha[-1]);
            }
            catch (Exception e)
            {
                InputOutput.Message(e.Message);
            }
            InputOutput.Message("Часы с самым большим углом между стрелками в коллекции [",
                clockArrayBeta, "] это часы ", FindMaxAngleDialClock(ref clockArrayBeta), " с углом ",
                FindMaxAngleDialClock(ref clockArrayBeta).CalculateClockHandsAngle(),
                " градусов.");
            InputOutput.Message("Итого количество созданных объектов ", DialClock.ObjectCount,
                ", количество созданных коллекций ", DialClockArray.ObjectCount);
            InputOutput.Message("Конец демонстрации.");
            return;
        }
    }
}
