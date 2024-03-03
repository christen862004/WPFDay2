using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPFDay2
{
    internal static class EmployeeSampleData
    {
        public static List<Employee> Emps { get; set; } 
            = new List<Employee>();

        static EmployeeSampleData()
        {   
            Emps.Add(new Employee() { Id = 1, Name = "Ahmed", Address = "Alex", Age = 20 });
            Emps.Add(new Employee() { Id = 2, Name = "Asmaa", Address = "Alex", Age = 20 });
            Emps.Add(new Employee() { Id = 3, Name = "Mohamed", Address = "Alex", Age = 20 });
            Emps.Add(new Employee() { Id = 4, Name = "Carolin", Address = "Alex", Age = 20 });
            Emps.Add(new Employee() { Id = 5, Name = "Mody", Address = "Alex", Age = 20 });
        }
        
    }
}
