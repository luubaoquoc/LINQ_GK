using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GiuaKy
{
    class Employee
    {
        public int id { get; set; }
        public string name { get; set; }
        public DateTime birthDay { get; set; }
        public int Department_id { get; set; }
        public int Position_id { get; set; }

        public Employee(int id, string name, DateTime birthDay, int Department_id, int Position_id)
        {
            this.id = id;
            this.name = name;
            this.birthDay = birthDay;
            this.Department_id = Department_id;
            this.Position_id = Position_id;

        }

        public static List<Employee> CreateEmployee()
        {
            return new List<Employee>
            {
                new Employee(1,"Luu Bao Quoc", new DateTime(2003,11,30), 1, 1),
                new Employee(2,"Vo Thi Tra My", new DateTime(2003,09,27), 1, 2),
                new Employee(3,"Le Van Sy", new DateTime(2000,04,13), 2, 1),
                new Employee(4,"Nguyen Tan Tuan", new DateTime(2001,06,18), 3, 3),
                new Employee(5,"Nguyen xuan Phap", new DateTime(2004,02,03), 2, 2),
                new Employee(6,"Nguyen Nhat Tan", new DateTime(2002,07,25), 3, 2),
                new Employee(7,"Pham Hung Thuan", new DateTime(2001,01,12), 2, 3),
            };
        }
        // Phương thức để tính tuổi từ ngày sinh
        public int CalculateAge(DateTime dateOfBirth)
        {
            DateTime today = DateTime.Today;
            int age = today.Year - dateOfBirth.Year;
            if (dateOfBirth > today.AddYears(-age))
                age--;

            return age;
        }
    }
}
