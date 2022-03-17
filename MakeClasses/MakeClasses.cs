using System;

namespace MakeClasses
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    namespace ConsoleApp24
    {
        public class Employee//by putting public we can use it in main.
        {
            //Attributes(property and field.)
            public string FamilyName
            {
                get; set;
            }
            public string FirstName { get; set; }
            public string IDNumber { get; set; }
            //method
            public string getFullName()
            {
                string buongPangalan = FamilyName + ", " + FirstName;
                return buongPangalan;
            }
            public string initials()
            {
                string sagot = string.Empty;
                sagot = FirstName[0].ToString() + "  " + FamilyName[0].ToString();
                return sagot;
            }
        }
        class MakeClasses
        {
            static void Main(string[] args)
            {
                Employee jeloi = new Employee();//iTO AY TINAWAG NA INSTANTIATION 
                                                // ANOO ANG GINAGAWA NG instantiation?
                                                // ito ay bumubuo ng isang object.
                                                //sa kasong ito ang object ay si jeloi na buhat sa class employee
                                                //Instantiation requires the reserved word "new".
                Employee kenzo = new Employee();
                jeloi.FamilyName = "Serna";//ito ay setting the values of the properties.
                jeloi.FirstName = "John";
                jeloi.IDNumber = "WS2312";
                kenzo.FamilyName = "Austria";
                kenzo.FirstName = "SLEEPYHEAD";
                kenzo.IDNumber = "ZZZZZZZZZZZ3";
                string initialsString = jeloi.initials();
                string fullname = jeloi.getFullName();// the dot is for Method  Invocation
                Console.WriteLine(jeloi.FamilyName);
                Console.WriteLine(kenzo.FamilyName); ;
                Console.WriteLine(jeloi.getFullName());
                Console.WriteLine(fullname);
                Console.WriteLine(initialsString);
                Console.ReadLine();

            }
        }
    }
}
