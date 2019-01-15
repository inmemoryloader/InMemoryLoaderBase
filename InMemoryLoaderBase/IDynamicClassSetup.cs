
namespace InMemoryLoaderBase
{
	public interface IDynamicClassSetup
	{
        string Assembly { get; set; }
        string Class { get; set; }
		string InitMethod { get; }
	}
}