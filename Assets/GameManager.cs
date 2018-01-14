using UnityEngine;

namespace Assets
{
    public class GameManager : MonoBehaviour
    {
        private static Transform _beaverTransform;
        public static Transform BeaverTransform
        {
            get
            {
                if (_beaverTransform == null)
                {
                    _beaverTransform = GameObject.Find("Beaver").transform;
                }

                return _beaverTransform;
            }
        }
    }
}
