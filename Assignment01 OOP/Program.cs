namespace Assignment01_OOP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Employee[] EmpArr = new Employee[3];
            DateTime date1 = new DateTime(2020, 5, 20);
            DateTime date2 = new DateTime(2019, 5, 20);
            DateTime date3 = new DateTime(2018, 5, 20);

            Employee e1 = new Employee(1, "Mohamed", Privileges.DBA, 5500, date1, Gender.M);
            Employee e2= new Employee(2, "Ahmed", Privileges.Guest, 5500, date2, Gender.M);
            Employee e3 = new Employee(3, "Yousif", Privileges.secretary, 5500, date3, Gender.M);
            EmpArr[0] = e1;
            EmpArr[1] = e2;
            EmpArr[3] = e3;

            Array.Sort(EmpArr);

            for(int i = 0; i < EmpArr.Length; i++)
            {
                EmpArr[0].DisplayInfo();
            }
            
        }
    }
}
