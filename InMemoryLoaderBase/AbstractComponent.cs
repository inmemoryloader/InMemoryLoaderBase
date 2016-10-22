using System;

namespace InMemoryLoaderBase
{
    /// <summary>
    /// Abstract power up component class, Components must inherit this class. Otherwise the ComponentLoader will fail.
    /// </summary>
    public abstract class AbstractPowerUpComponent
    {
        /// <summary>
        /// The key, needed to check if the Component inherits the correct Member.
        /// </summary>
        public const int Key = 0815;

        /// <summary>
        /// Init the specified paramArgument.
        /// </summary>
        /// <param name="paramArgument">Parameter argument.</param>
        public bool Init(int paramArgument)
        {
            if (paramArgument.Equals(Key))
            {
                return true;
            }
            return false;
        }
    }
}