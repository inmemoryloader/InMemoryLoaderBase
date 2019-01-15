
namespace InMemoryLoaderBase
{
    /// <inheritdoc />
    public class DynamicClassSetup : IDynamicClassSetup
    {
        /// <inheritdoc />
        public string Assembly { get; set; }

        /// <inheritdoc />
        public string Class { get; set; }

        /// <inheritdoc />
        public string InitMethod { get; } = "Init";
    }
}