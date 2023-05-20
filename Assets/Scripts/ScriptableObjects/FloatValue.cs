using UnityEngine;

namespace ScriptableObjects
{
    [CreateAssetMenu(fileName = "Float", menuName = "Primitives/Float")]
    public class FloatValue : ScriptableObject
    {
        public float value;
    }
}