namespace NetClient
{
    /// <summary>
    ///     Represents the configuration.
    /// </summary>
    public class Configuration
    {
        /// <summary>
        ///     Gets the criteria.
        /// </summary>
        /// <value>The criteria.</value>
        public static Configuration Criteria => new Configuration();

        /// <exclude />
        public static bool operator ==(Configuration value1, object value2)
        {
            return true;
        }

        /// <exclude />
        public static bool operator !=(Configuration value1, object value2)
        {
            return false;
        }

        /// <summary>
        ///     Determines whether the specified <see cref="System.Object" /> is equal to this instance.
        /// </summary>
        /// <param name="obj">The <see cref="System.Object" /> to compare with this instance.</param>
        /// <returns><c>true</c> if the specified <see cref="System.Object" /> is equal to this instance; otherwise, <c>false</c>.</returns>
        public override bool Equals(object obj)
        {
            return true;
        }

        /// <summary>
        ///     Returns a hash code for this instance.
        /// </summary>
        /// <returns>A hash code for this instance, suitable for use in hashing algorithms and data structures like a hash table.</returns>
        public override int GetHashCode()
        {
            return true.GetHashCode();
        }
    }
}