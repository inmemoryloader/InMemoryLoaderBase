
using System;
using System.Reflection;

namespace InMemoryLoaderBase
{
    /// <inheritdoc />
    public class DynamicClassInfo : IDynamicClassInfo
    {
        /// <summary>
        ///     Initializes a new instance of the <see cref="InMemoryLoaderBase.DynamicClassInfo" /> class.
        /// </summary>
        public DynamicClassInfo()
        {
        }

        /// <summary>
        ///     Initializes a new instance of the <see cref="InMemoryLoaderBase.DynamicClassInfo" /> class.
        /// </summary>
        /// <param name="paramType">Parameter type.</param>
        /// <param name="paramObject">Parameter object.</param>
        public DynamicClassInfo(Type paramType, object paramObject)
        {
            ClassType = paramType;
            ClassObject = paramObject;
        }

        /// <inheritdoc />
        public Type ClassType { get; set; }

        /// <inheritdoc />
        public object ClassObject { get; set; }

        /// <inheritdoc />
        public MethodInfo[] GetMethods() => ClassType.GetMethods(BindingFlags.Public | BindingFlags.Instance);
    }
}