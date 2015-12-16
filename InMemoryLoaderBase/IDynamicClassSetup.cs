using System;

namespace InMemoryLoaderBase
{
	/// <summary>
	/// I dynamic class setup.
	/// </summary>
	public interface IDynamicClassSetup
	{
		/// <summary>
		/// Gets or sets the assembly.
		/// </summary>
		/// <value>The assembly.</value>
		string Assembly {
			get;
			set;
		}
		/// <summary>
		/// Gets or sets the class.
		/// </summary>
		/// <value>The class.</value>
		string Class {
			get;
			set;
		}
		/// <summary>
		/// Gets the init method.
		/// </summary>
		/// <value>The init method.</value>
		string InitMethod {
			get;
		}
	}
}

