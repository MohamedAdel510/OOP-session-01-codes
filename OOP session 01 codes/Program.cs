
using Common;
using System.ComponentModel;

namespace OOP_session_01_codes
{
    //-- What can we write inside the namespace
    // 1- Class
    // 2- Struct
    // 3- Enum
    // 4- Interface
    // -- Allowed access modifier inside namespace
    // 1- internal (defualt access modifiers):
    //    Accessable within the namespace only 
    //    not accessable outside the namespace
    // 2- public:
    //    Accessable every where

    internal class Program
    {
        static void Main()
        {
            #region Access Modifiers
            // What we can write inside the class or struct:
            //1- Attributes 
            //2- Properties (Full property - Automatic property - index)
            //3- Functions (Constructors - Getters & Setters - Methods)
            //4- Event

            // * Allowed access modifier inside struct:
            // 1- private : Accessable inside the struct or class only
            // 2- internal
            // 3- public

            // * Allowed access modifiers inside the class and interface:
            // 1- private (defualt access modifier for the class)
            // 2- private protected
            // 3- protected
            // 4- internal
            // 5- internal protected
            // 6- public  (defualt access modifier for the interface)


            // TypeA obj = new TypeA(); invalid dou to protiction level of the class
            //TypeB obj = new TypeB();
            //obj.X = 1; ;
            //obj.Y = 2; ;
            //Console.WriteLine(obj.X);
            //Console.WriteLine(obj.Y); // accessable duo to public access modifier
            #endregion

            #region What is OOP
            // * Style of programming based on objext concept,
            //   it doesnot refer to a specific language but it is a way to
            //   build a program by making simulation of reality

            //     procedural programming         Vs          OOP

            //  .Based on functions                    .Based on real world objects

            //  .Gives the imprtance on the            .Gives importance on the state and
            //   sequance of the function execution     bevavior of object

            //  .Exposs the data to the whole program  .Encabsulate the data
            //  
            //  .Complex in nature so it difficult     .Simple in nature so it is easy to modifiy
            //   to modify, extend and maintain         extend and mintain.
            #endregion

            #region Class and Encapsulation
            //Employee e = new Employee(10, "Mohamed", 10000);
            //e.DisplayInfo();
            //e.stId(20);
            //e.DisplayInfo();
            //e.Id = 15;         // using property 
            //e.Id = 9;
            //Console.WriteLine(e.Id); 
            #endregion


        }
    }

    
}
