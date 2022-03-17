using System;

namespace GetterSetter
{
    public class User//by putting public we can use it in main.
    {
        //Attributes(property and field.)
        public string Username { get; set; }
        public string Password { get; set; }
        public string email { get; set; }

        public string code()
        {

            string codename = Username[0].ToString() + Password[0].ToString() + Username[2].ToString();
            return codename;
        }


    }
    class GetterSetter
    {
        static void Main(string[] args)
        {
            User Firstuser = new User();
            Firstuser.Username = Console.ReadLine();
            Firstuser.Password = Console.ReadLine();
            Firstuser.email = Console.ReadLine();
            string codeString = Firstuser.code();

            Console.WriteLine(codeString);


            Console.ReadLine();

        }
    }
}
