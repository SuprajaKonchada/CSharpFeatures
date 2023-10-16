using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_9
{
    public class Member
    {
        //Init-Only Properties
        public int Id { get; init; }
        public string Name { get; init; }
        public string Address { get; set; }
    }
}

