using System;

namespace Test
{
    /// <summary>
    /// Тестовый класс для изучения автодокументирования
    /// </summary>
    public class TestClass
    {
        /// <summary>
        /// Метод приветствия
        /// </summary>
        /// <remarks>
        /// Статический метод.
        /// </remarks>
        public static void Welcome()
        {
            Console.WriteLine("Welcome!");
        }

        /// <summary>
        /// Сложение числа <paramref name="num1"/> с числом <paramref name="num2"/> и возврат их суммы.
        /// </summary>
        /// <param name="num1">
        /// первое целое число
        /// </param>
        /// <param name="num2">
        /// Второе целое число
        /// </param>
        /// <returns>
        /// Возвращает сумму двух целых чисел
        /// </returns>
        /// <example>
        /// <code>
        /// var result = TestClass.Add(5, 6);
        /// </code>
        /// </example>
        public static int Add(int num1, int num2)
        {
            return num1 + num2;
        }
    }
}