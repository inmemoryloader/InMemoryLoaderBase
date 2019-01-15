
using System;
using System.Reflection;
using System.Threading.Tasks;

namespace InMemoryLoaderBase
{
    public interface IDynamicClassInfo
    {
        Type ClassType { get; set; }
        object ClassObject { get; set; }
        MethodInfo [] GetMethods ();
    }
}