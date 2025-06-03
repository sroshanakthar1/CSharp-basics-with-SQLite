namespace UMSLoginCheck
{
    internal class Program
    {
        static void IsValidLogin(string username, string password)
        {
            if (username == null || password.Length < 6)
            {
                Console.WriteLine("Invalid Login");
            }
            else
            {
                Console.WriteLine("Valid Login");
            }

        }
        static void Main(string[] args)
        {
            Console.Write("Enter Username : ");    
            string Username = Console.ReadLine();
            
            Console.Write("Enter Password : ");
            string Password = Console.ReadLine();

            IsValidLogin(Username, Password);
        }
    }
}