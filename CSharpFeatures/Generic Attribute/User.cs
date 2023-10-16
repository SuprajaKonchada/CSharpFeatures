using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_11;
[Custom<string>()]
internal class User
{
    public string Name { get; set; }
    public required string Address { get; set; }
    public string Phone { get; set; }

}
/*
[Custom<T>()]
[Custom<int>()]
[Custom<dynamic>()]
[Custom<(int a, int b)>()]*/
[Custom<Tuple<int, int>>()]
internal class GenericUser<T>
{
    public string Name { get; set; }
}
