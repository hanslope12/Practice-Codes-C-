using System;

namespace GetterSetterClasses
{
    class GetterSetterClasses
    {
        public class Employee//by putting public we can use it in main.
        {
            //Attributes(property and field.)
            public string FamilyName { get; set; }//properties and mga ito.
            public string FirstName { get; set; }//ang mga properties ay getter and setter.
            public string IDNumber { get; set; }//para silang variables

            public Employee(string apelyido, string pangalan)//method ito. pero and pangalan nya ay pareho ng class name
            {                                                // sa class name. tapos, wala syang return value
                FamilyName = apelyido;                                              // this is called a constructor
                FirstName = pangalan;
            }
            public Employee()
            {

            }

            //method
            public string getFullName()//this is a method that concatenates the familyname and firstname
            {
                string buongPangalan = FamilyName + ", " + FirstName;
                return buongPangalan;
            }
            public string Getinitials()//this is a method that gets the first characters of firstname and familyname and concatenates them
            {

                string sagot = FirstName[0].ToString() + FamilyName[0].ToString();
                return sagot;
            }
        }


        static void Main(string[] args)
        {
            Employee jeloi = new Employee("Serna", "John");//iTO AY TINAWAG NA INSTANTIATION 
                                                           // ANOO ANG GINAGAWA NG instantiation?
                                                           // ito ay bumubuo ng isang object.
                                                           //sa kasong ito ang object ay si jeloi na buhat sa class employee
                                                           //Instantiation requires the reserved word "new".
            Employee kenzo = new Employee();
            /* 
             Employee jeloi = new Employee("Serna", "John") is the same as the other two below
             jeloi.FamilyName = "Serna";                                                         //ito ay setting the values of the properties.
             jeloi.FirstName = "John";                   */
            jeloi.IDNumber = "WS2312";
            kenzo.FamilyName = "Austria";
            kenzo.FirstName = "SLEEPYHEAD";
            kenzo.IDNumber = "ZZZZZZZZZZZ3";
            string initialsString = jeloi.Getinitials();
            string fullname = jeloi.getFullName();// the dot is for Method  Invocation
            Console.WriteLine(jeloi.FamilyName);
            Console.WriteLine(kenzo.FamilyName);

            Console.WriteLine(kenzo.Getinitials());
            Console.WriteLine(jeloi.getFullName());
            Console.WriteLine(fullname);
            Console.WriteLine(initialsString);
            Console.ReadLine();

        }
    }
}
