namespace Abstract_Class_Task.Models
{
    internal class Account
    {
        public string userName { get; set; }
        public string password { get; set; }




        public void Login(string userName, string password)
        {
            string correctUsername = "AdminEA18yr@";
            string correctPassword = "AdminEA18yr@";
            if (userName == correctUsername && password == correctPassword)
                Console.WriteLine("Girish ugurludur");
            else
            Console.WriteLine("Username ve ya Password sehvdir");
        }
    }
}
