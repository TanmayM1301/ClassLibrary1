using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    
    public class SearchDetails
    {
        int emp_id;
        string Emp_Name;
        int Emp_Salary;
        string Emp_Department;
        string Emp_Gender;

    static void Main(string[] args)
        {
            List<SearchDetails> Search = new List<SearchDetails>()
            {
                new SearchDetails{emp_id=101,Emp_Name="arjun",Emp_Salary=50000,Emp_Department="Delivery",Emp_Gender="Male"},
                new SearchDetails{emp_id=102,Emp_Name="pranav",Emp_Salary=40000,Emp_Department="Support",Emp_Gender="Male"},
                new SearchDetails{emp_id=103,Emp_Name="ayush",Emp_Salary=55000,Emp_Department="Testing",Emp_Gender="Male"},
                new SearchDetails{emp_id=104,Emp_Name="vishwas",Emp_Salary=60000,Emp_Department="DevOps",Emp_Gender="Male"},
                new SearchDetails{emp_id=105,Emp_Name="hansraj",Emp_Salary=10000,Emp_Department="Cloud",Emp_Gender="Male"},
                new SearchDetails{emp_id=106,Emp_Name="tanmay",Emp_Salary=25000,Emp_Department="Support",Emp_Gender="Male"},
                new SearchDetails{emp_id=107,Emp_Name="devansh",Emp_Salary=65000,Emp_Department="Cloud",Emp_Gender="Male"},
                new SearchDetails{emp_id=108,Emp_Name="shreya",Emp_Salary=50000,Emp_Department="Delivery",Emp_Gender="Female"},
                new SearchDetails{emp_id=109,Emp_Name="muskan",Emp_Salary=75000,Emp_Department="DevOps",Emp_Gender="Female"},
                new SearchDetails{emp_id=110,Emp_Name="aditya",Emp_Salary=30000,Emp_Department="Delivery",Emp_Gender="Male"},
                new SearchDetails{emp_id=111,Emp_Name="nimish",Emp_Salary=100000,Emp_Department="Delivery",Emp_Gender="Male"},
            };
        }
        class SearchByName
        {
            string name;
            Console.WriteLine("Enter The Name You want to Search");
            var result_set = Search.Where(emp => emp.Emp_Department == name).OrderBy(
                                 sal => sal.Emp_Salary);
  
            foreach (SearchDetails emp in result_set)
            {
            Console.WriteLine(emp.emp_id + " " + emp.Emp_Name +" " + emp.Emp_Salary + " " + emp.Emp_Department);
            }
        }
        class SearchByGender
        {
            string gender;
            Console.WriteLine("Enter The Gender You want to Search");
            gender=Console.ReadLine();
            var result_set = Search.Where(emp => emp.Emp_Department == gender).OrderBy(
                                 sal => sal.Emp_Salary);
  
            foreach (SearchDetails emp in result_set)
            {
            Console.WriteLine(emp.emp_id + " " + emp.Emp_Name +" " + emp.Emp_Salary + " " + emp.Emp_Department);
            }
        }
        class SearchByDepartment
        {
            string Department;
            Console.WriteLine("Enter The Department You want to Search");
            var result_set = Search.Where(emp => emp.Emp_Department == Department).OrderBy(
                                 sal => sal.Emp_Salary);
  
            foreach (SearchDetails emp in result_set)
            {
            Console.WriteLine(emp.emp_id + " " + emp.Emp_Name +" " + emp.Emp_Salary + " " + emp.Emp_Department);
            }
        }
    }
}
