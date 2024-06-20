using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Expressions.Models
{
    public record Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string FirstName { get; set; }
        public int Age  { get; set; }

    }
}
