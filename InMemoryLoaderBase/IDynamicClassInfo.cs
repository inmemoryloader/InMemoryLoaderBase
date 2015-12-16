using System;

namespace InMemoryLoaderBase
{
	/// <summary>
	/// I dynamic class info.
	/// </summary>
	public interface IDynamicClassInfo
	{
		/// <summary>
		/// Gets or sets the type of the class.
		/// </summary>
		/// <value>The type of the class.</value>
		Type ClassType { get; set;}
		/// <summary>
		/// Gets or sets the class object.
		/// </summary>
		/// <value>The class object.</value>
		Object ClassObject { get; set;}
	}
}

