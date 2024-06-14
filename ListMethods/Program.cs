using static System.Runtime.InteropServices.JavaScript.JSType;

namespace ListMethods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = new List<int>() { 15, 3, 8, 7, 19, 15, 4, 13, 6, 1, 8, 2, 18, 12, 11, 10, 6, 3, 17, 2, 14, 5, 8, 13, 7 };

            numbers.Add(6);
            Console.WriteLine(string.Join(", ", numbers));
            Console.WriteLine();

            numbers.Insert(0, 19);
            Console.WriteLine(string.Join(", ", numbers));
            Console.WriteLine();

            numbers.AddRange(new List<int>() { 25, 53, 77, 86 });
            Console.WriteLine(string.Join(", ", numbers));
            Console.WriteLine();

            numbers.InsertRange(3, new int[] { 97, 75, 83, 51 });
            Console.WriteLine(string.Join(", ", numbers));
            Console.WriteLine();

            numbers.Remove(8);
            Console.WriteLine(string.Join(", ", numbers));
            Console.WriteLine();

            numbers.RemoveAt(12);
            Console.WriteLine(string.Join(", ", numbers));
            Console.WriteLine();

            numbers.RemoveRange(15, 18);
            Console.WriteLine(string.Join(", ", numbers));
            Console.WriteLine();

            bool Contains = numbers.Contains(3);
            Console.WriteLine(Contains);
            Console.WriteLine();

            int Index = numbers.IndexOf(97);
            Console.WriteLine(Index);
            Console.WriteLine();

            int LastIndex = numbers.LastIndexOf(8);
            Console.WriteLine(LastIndex);
            Console.WriteLine();

            numbers.Sort();
            Console.WriteLine(string.Join(", ", numbers));
            Console.WriteLine();

            numbers.Reverse();
            Console.WriteLine(string.Join(", ", numbers));
            Console.WriteLine();

            int[] ListArray = numbers.ToArray();
            foreach (int i in ListArray) Console.WriteLine(i);
            Console.WriteLine();

            int FindResult = numbers.Find(x => x > 17);
            Console.WriteLine(FindResult);
            Console.WriteLine();

            List<int> evenNumbers = numbers.FindAll(x => x % 2 == 0);
            Console.WriteLine(string.Join(", ", evenNumbers));
            Console.WriteLine();

            int FindIndexResult = numbers.FindIndex(x => x > 22);
            Console.WriteLine(FindIndexResult);
            Console.WriteLine();

            int FindLastResult = numbers.FindLast(x => x / 3 == 0);
            Console.WriteLine(FindLastResult);
            Console.WriteLine();

            int FindLastIndexResult = numbers.FindLastIndex(x => x / 97 == 0);
            Console.WriteLine(FindLastIndexResult);
            Console.WriteLine();

            numbers.ForEach(x => Console.WriteLine(x + 2));
            Console.WriteLine(string.Join(", ", numbers));
            Console.WriteLine();

            numbers.Clear();
            Console.WriteLine(string.Join(", ", numbers));
        }
    }
}
