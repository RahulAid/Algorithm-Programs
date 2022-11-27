namespace Algorithm_Programs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Algorithm Programs");

            RegexMessage obj = new RegexMessage();

            Console.Write("\nEnter First Name: ");
            string firstName = Console.ReadLine();
            obj.FirstName(firstName);

            Console.Write("\nEnter Full Name: ");
            string fullName = Console.ReadLine();
            obj.FullName(fullName);

            Console.Write("\nEnter Mobile Number (Example: +(country code)-(10 digit number)): ");
            string phoneNumber = Console.ReadLine();
            obj.PhoneNumber(phoneNumber);

            Console.Write("\nEnter Date (dd/mm/yyyy): ");
            string date = Console.ReadLine();
            obj.Date(date);

            Console.WriteLine($"\nHello {obj.FirstName(firstName)}, \nWe have your full name as {obj.FullName(fullName)} in our system. \nYour contact number is {obj.PhoneNumber(phoneNumber)}. \nPlease, let us know in case of any clarification \nThank you \nBridgeLabz \n{obj.Date(date)}");

        }
    }
}