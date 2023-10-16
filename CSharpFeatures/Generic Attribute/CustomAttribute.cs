using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_11;
internal class CustomAttribute<T> : Attribute
{
    public Type CurrentType => typeof(T);
}
