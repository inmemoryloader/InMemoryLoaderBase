using System;

namespace InMemoryLoaderBase
{
	/// <summary>
	/// Definiert den Typ eines AM/PM-Strings in einer Zeitangabe
	/// </summary>
	public enum DateTimeAmPmType
	{
		/// <summary>
		/// Keine AM/PM-Angabe
		/// </summary>
		None,
		/// <summary>
		/// AM/PM-Angabe links von der Zeitangabe
		/// </summary>
		Left,
		/// <summary>
		/// AM/PM-Angabe rechts von der Zeitangabe
		/// </summary>
		Right
	}
}