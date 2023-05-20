using UnityEngine;

namespace ScriptableObjects
{
    [CreateAssetMenu(fileName = "Boolean", menuName = "Primitives/Boolean", order = 0)]
    public class BooleanValue : ScriptableObject
    {
        public bool value;
    }
}