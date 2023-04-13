namespace UserRegistration
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the User Registration Page");
            Password4 passWord = new Password4();
            Console.WriteLine("Please enter password");
            string password = Console.ReadLine();
            Console.WriteLine(passWord.ValidatePassword(password));
        }
    }
}