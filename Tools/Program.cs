using System;

namespace Tools
{
    /// <summary>
    /// 给定两个日期，计算其间隔的天数与年数
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            DateTime firstDate = GetDateTime("First Date:");
            DateTime secondDate = GetDateTime("Second Date:");

            int totalDays = (secondDate - firstDate).Days;
            if (secondDate.Year >= firstDate.Year)
            {
                
            }
            double totalYears = Math.Round(totalDays / 365.0, 1);

            Console.WriteLine($"Total Days:{totalDays}" + "\r\n" + $"Total Years:{totalYears}");

            Console.ReadLine();
        }

        /// <summary>
        /// 获取用户输入的日期
        /// </summary>
        /// <param name="showText">提示文字</param>
        /// <returns>日期</returns>
        private static DateTime GetDateTime(string showText)
        {
            DateTime date = new DateTime();
            string input;
            do
            {
                Console.WriteLine(showText);
                input = Console.ReadLine();
                if (showText == "Second Date:" && string.IsNullOrEmpty(input))
                    return DateTime.Now;

            } while (!StringToDateTime(input, ref date));
            return date;
        }

        /// <summary>
        /// 判断字符串能否转换成日期
        /// </summary>
        /// <param name="str"></param>
        /// <param name="date"></param>
        /// <returns></returns>
        private static bool StringToDateTime(string str, ref DateTime date)
        {
            return DateTime.TryParse(str, out date);
        }

        /// <summary>
        /// 判断闰年
        /// </summary>
        /// <param name="year">给定年份</param>
        /// <returns></returns>
        private static bool LeapYear(int year)
        {
            return year%400 == 0 || (year%4 == 0 && year%100 != 0);
        }

    }
}
