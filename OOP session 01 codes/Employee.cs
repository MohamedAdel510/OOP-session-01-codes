using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Intrinsics.X86;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace OOP_session_01_codes
{
    internal class Employee
    {
        #region Attributes
        private int id;
        private string name;
        private decimal salary;
        #endregion

        #region Constructors
        //If you don’t create any constructor, C++ will create the default 
        //constructor for you, but it will be empty without any code or logic
        // defualt or parameterless Constructor usefull for object creation and intialization
        public Employee()
        {
            id = 0;
            name = "";
            salary = 0.0m;
        }

        // But if you create a parameterized constructor without creating default 
        // constructor, Clr will not create it and you will be asked to send data
        // at each time as you will use the parameterized constructor
        // So don’t create any parameterized constructor before creating the default one
        public Employee(int id, string name, decimal salary) // parametrized constructor (overloading)
        {
            this.id = id;
            this.name = name;
            this.salary = salary;
        }
        #endregion

        // Allow encapsulation using setters  and  getters
        #region Getters
        public int getId()
        {
            return id;
        }
        public string getName()
        {
            return name;
        }
        public decimal getSalary()
        {
            return salary;
        }
        #endregion

        #region Setters
        public void stId(int id)
        {
            this.id = id;
        }
        public void stName(string name)
        {
            this.name = name;
        }
        public void setSalary(decimal salary)
        {
            this.salary = salary;
        }
        #endregion

        //Allow encapsulation using property
        // Automatic property by defualt declare private attributes
        #region Automatic property
        //public int Id { get; set; }
        //public string Name { get; set; }
        //public decimal Salary { get; set; }
        #endregion

        // or using full property
        #region full property
        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public decimal Salary
        {
            get { return salary; }
            set { salary = value; }
        }
        #endregion

        #region Methods
        public void DisplayInfo()
        {
            System.Console.WriteLine($"ID: {Id}");
            System.Console.WriteLine($"Name: {Name}");
            System.Console.WriteLine($"Salary: {Salary}");
            Console.WriteLine("----------");
        }

        public override string ToString()
        {
            return $"ID: {Id} \nName: {Name}\n Salary: {Salary}";
        }
        #endregion
    }
}
