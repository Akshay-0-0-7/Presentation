namespace RefKeyword
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number = 10;

            Console.WriteLine($"number before modifying: {number}");

            ModifyInteger(ref number);

            Console.WriteLine($"number after modifying: {number}");

        }

        static void ModifyInteger(ref int value)
        {
            value += 10;

            //Console.WriteLine($"Modifying without ref keyword: {value}");
        }
    }
}
