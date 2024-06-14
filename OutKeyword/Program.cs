namespace OutKeyword
{
    internal class Program
    {
        static void Main()
        {
            string fullName = "John Doe";
            string firstName, lastName;

            // Call the method to split the full name into first and last names
            SplitName(fullName, out firstName, out lastName);

            // Print the results
            Console.WriteLine($"First Name: {firstName}");
            Console.WriteLine($"Last Name: {lastName}");
        }

        static void SplitName(string fullName, out string firstName, out string lastName)
        {
            // Split the full name by space
            string[] nameParts = fullName.Split(' ');

            // Assign the split parts to the out parameters
            firstName = nameParts[0];
            lastName = nameParts[1];
        }
    }
}
