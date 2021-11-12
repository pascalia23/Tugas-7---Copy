using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PAS.Models
{
    public class Employee
    {
        public int EmployeeId { get; set; }
        public string FirstName{ get; set; }
        public string LastName{ get; set; }
        public string Email{ get; set; }
        public DateTime DateOfBirth{ get; set; }
        public Gender Gender{ get; set; }
        public int  MyProperty{ get; set; }
        public Department  Department{ get; set; }
        public int  DepartmentId{ get; set; }
        public int  DepartmentName{ get; set; }
        public string PhotoPath{ get; set; }
    }
    public enum Gender{
        Male,Female
    }
}