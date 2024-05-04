using UnityEngine;

namespace CrawfisSoftware
{
    [CreateAssetMenu(fileName = "randomSeed", menuName = "delete me")]
    public class ScriptableInt : ScriptableObject
    {
        [SerializeField] public int m_Value = 0;
    }
}