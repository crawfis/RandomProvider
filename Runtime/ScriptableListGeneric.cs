using System.Collections.Generic;

using UnityEngine;

namespace CrawfisSoftware
{
    public class ScriptableListGeneric<T> : ScriptableObject
    {
        [SerializeField] public List<T> List;
    }
}