using System.Diagnostics;

namespace Exc_13._6._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string text = File.ReadAllText(@"C:\Users\lino-\OneDrive\Рабочий стол\Text1.txt");

            GetListTime(text);

            GetLinkedListTime(text);
        }

        static void GetListTime(string text)
        {
            var words = text.Split(' ', StringSplitOptions.RemoveEmptyEntries);
            List<string> list = new List<string>();
            var watch = new Stopwatch();
            foreach (string word in words)
            {
                watch = Stopwatch.StartNew();
                list.Add(word);
            }
            Console.WriteLine($"Вставка в List<T>: {watch.Elapsed.TotalMilliseconds} мс");
        }

        static void GetLinkedListTime(string text)
        {
            var words = text.Split(' ', StringSplitOptions.RemoveEmptyEntries);
            LinkedList<string> list = new LinkedList<string>();
            var watch = new Stopwatch();
            foreach (string word in words)
            {
                watch = Stopwatch.StartNew();
                list.AddLast(word);
            }
            Console.WriteLine($"Вставка в LinkedList<T>: {watch.Elapsed.TotalMilliseconds} мс");
        }
    }
}
