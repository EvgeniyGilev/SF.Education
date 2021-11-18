using System;

namespace SF.Education.Mod9_ConsoleApp
{
    /// <summary>
    /// The program.
    /// </summary>
    public class Program
    {
        /// <summary>
        /// Mains the.
        /// </summary>
        /// <param name="args">The args.</param>
        public static void Main(string[] args)
        {
            try
            {
                int a = 5 / Convert.ToInt32(Console.ReadLine());
                Exception ex = new Exception("Hello!");
      
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.StackTrace);
                throw;
            }
        }

        /// <summary>
        /// Shows the message.
        /// </summary>
        public static void ShowMessage()
        {
            Console.WriteLine("Hello World!");
        }

        /// <summary>
        /// Sums the a b c.
        /// </summary>
        /// <param name="a">The a.</param>
        /// <param name="b">The b.</param>
        /// <param name="c">The c.</param>
        /// <returns>sum numbers</returns>
        public static int Sum(int a, int b, int c)
        {
            return a + b + c;
        }

        /// <summary>
        /// Checks the length.
        /// </summary>
        /// <param name="row">The row.</param>
        /// <returns>A bool.</returns>
        public static bool CheckLength(string row)
        {
            if (row.Length > 3)
            {
                return true;
            }

            return false;
        }
    }
}
