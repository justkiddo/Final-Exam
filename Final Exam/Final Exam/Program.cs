using Final_Exam.Classes;

namespace Final_Exam
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
              var res = IntWorker.ConvertIntToString(Convert.ToInt32(Console.ReadLine()));
              Console.WriteLine(res);
            }catch(FormatException ex)
            {
                Console.WriteLine("Нужно вводить ТОЛЬКО простые числа без пробелов");
            }catch(OverflowException ex)
            {
                Console.WriteLine("Слишком большое число");
            } catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}