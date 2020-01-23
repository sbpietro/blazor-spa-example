using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ServerSideSPA.Domain
{
    public class Employee
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Department { get; set; }

        public string Gender { get; set; }

        public int CityId { get; set; }

        public virtual City City { get; set; }
    }
}
