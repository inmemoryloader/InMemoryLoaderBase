using System;

namespace InMemoryLoaderBase
{
	/// <summary>
	/// Dynamic class setup.
	/// </summary>
	public class DynamicClassSetup : IDynamicClassSetup
	{
		/// <summary>
		/// The init method.
		/// </summary>
		private const string initMethod = "Init";

		/// <summary>
		/// Gets or sets the assembly.
		/// </summary>
		/// <value>The assembly.</value>
		public string Assembly {
			get;
			set;
		}
		/// <summary>
		/// Gets or sets the class.
		/// </summary>
		/// <value>The class.</value>
		public string Class {
			get;
			set;
		}
		/// <summary>
		/// Gets the init method.
		/// </summary>
		/// <value>The init method.</value>
		public string InitMethod {
			get { return initMethod; }
		}
	}
}

