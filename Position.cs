using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GiuaKy
{
    class Position
    {
        public int id { get; set; }
        public string name { get; set; }

        public Position(int id, string name)
        {
            this.id = id;
            this.name = name;
        }

        public static List<Position> CreatePosition()
        {
            return new List<Position>
            {
                new Position(1, "Dev"),
                new Position(2,"Tester"),
                new Position(3,"Human Resources")
            };
        }
    }
}
