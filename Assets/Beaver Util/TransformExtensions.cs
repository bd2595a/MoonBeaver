namespace Assets.Beaver_Util
{
    using UnityEngine;

    /// <summary>
    /// Extensions and shortcuts 
    /// </summary>
    internal static class TransformExtensions
    {
        /// <summary>
        /// Removes transform's parent 
        /// </summary>
        /// <param name="child"> Child to be freed from parent </param>
        public static void DropParent(this Transform child)
        {
            child.parent = null;
        }

        /// <summary>
        /// Removes transform's parent 
        /// </summary>
        /// <param name="child"> Child to be freed from parent </param>
        public static void DropParent(this GameObject child)
        {
            DropParent(child.transform);
        }

        /// <summary>
        /// Shortcut for transform.gameObject.GetComponent T 
        /// </summary>
        /// <typeparam name="T"> Type of component </typeparam>
        /// <param name="transform"> Transform to get component from </param>
        /// <returns> GetComponent </returns>
        public static T GetComponent<T>(this Transform transform)
        {
            return transform.gameObject.GetComponent<T>();
        }
    }
}