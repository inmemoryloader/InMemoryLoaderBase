using System;

namespace InMemoryLoaderBase
{
	/// <summary>
	/// Dynamic class info.
	/// </summary>
	public class DynamicClassInfo : IDynamicClassInfo
	{
		/// <summary>
		/// Gets or sets the type of the class.
		/// </summary>
		/// <value>The type of the class.</value>
		public Type ClassType { get; set;}
		/// <summary>
		/// Gets or sets the class object.
		/// </summary>
		/// <value>The class object.</value>
		public Object ClassObject { get; set;}

		/// <summary>
		/// Initializes a new instance of the <see cref="PowerUpBase.DynamicClassInfo"/> class.
		/// </summary>
		public DynamicClassInfo()
		{
		}

		/// <summary>
		/// Initializes a new instance of the <see cref="PowerUpBase.DynamicClassInfo"/> class.
		/// </summary>
		/// <param name="paramType">Parameter type.</param>
		/// <param name="paramObject">Parameter object.</param>
		public DynamicClassInfo(Type paramType, Object paramObject)
		{
			ClassType = paramType;
			ClassObject = paramObject;
		}
	}
}

