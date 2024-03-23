using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GiuaKy
{
    class Program
    {
        static void Main(string[] args)
        {

            List<Department> departments = Department.CreateDepartment();
            List<Position> positions = Position.CreatePosition();
            List<Employee> employees = Employee.CreateEmployee();

            Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine("---------------------------");
            Console.Write("Nhập từ khóa tìm kiếm: ");
            string key = Console.ReadLine();
            Console.Write("Tuổi từ: ");
            int minAge = int.Parse(Console.ReadLine());
            Console.Write("Đến tuổi: ");
            int maxAge = int.Parse(Console.ReadLine());
            Console.Write("Vị trí: ");
            string position = Console.ReadLine();
            Console.Write("Phòng ban: ");
            string department = Console.ReadLine();

            //Phương thức tìm kiếm

            var result = from emp in employees
                         join dep in departments on emp.Department_id equals dep.id
                         join pos in positions on emp.Position_id equals pos.id
                         where (emp.name.Contains(key) || pos.name.Contains(key) || dep.name.Contains(key))
                              && emp.CalculateAge(emp.birthDay) >= minAge && emp.CalculateAge(emp.birthDay) <= maxAge
                              && (string.IsNullOrEmpty(position) || pos.name.Equals(position))
                              && (string.IsNullOrEmpty(department) || dep.name.Equals(department))
                         select new
                         {
                             EmployeeName = emp.name,
                             EmployeeAge = emp.CalculateAge(emp.birthDay),
                             Position = pos.name,
                             Department = dep.name
                         };


            // In kết quả
            foreach (var item in result)
            {
                Console.WriteLine($"Tên nhân viên: {item.EmployeeName}, Tuổi: {item.EmployeeAge}, Vị trí: {item.Position}, Phòng ban: {item.Department}");
            }

            Console.ReadLine();

            
        }
    }
}
