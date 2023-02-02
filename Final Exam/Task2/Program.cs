using Task2.Classes;

namespace Task2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                double value1, value2;
                Console.WriteLine("Введите число");
                value1 = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Введите степень числа");
                value2 = Convert.ToDouble(Console.ReadLine());
                var res = MathWorker.Squared(value1, value2);
                Console.WriteLine($"{value2} степень числа {value1} - {res}");

                Console.WriteLine("Введите число для вычисления факториала");
                int value3 = Convert.ToInt32(Console.ReadLine());

                var res2 = MathWorker.Factorial(value3);
                Console.WriteLine($"Факториал числа {value3} - {res2}");
                
            }
            catch (FormatException e)
            {
                Console.WriteLine(e.Message + " first catch");
            }catch(Exception e)
            {
                Console.WriteLine(e.Message + " second catch");
            }
        }
    }
}