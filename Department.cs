using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GiuaKy
{
    class Department
    {
        public int id { get; set; }
        public string name { get; set; }

        public Department(int id, string name)
        {
            this.id = id;
            this.name = name;
        }

        public static List<Department> CreateDepartment()
        {
            return new List<Department>
            {
                new Department(1,"HR"),
                new Department(2,"QC"),
                new Department(3,"VIP")
            };
        }
    }
}
