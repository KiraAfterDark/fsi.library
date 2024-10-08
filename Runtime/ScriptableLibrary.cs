using System.Collections.Generic;
using UnityEngine;

namespace Fsi.Libraries
{
    public abstract class ScriptableLibrary<TKey, TValue>
        : ScriptableObject, ILibrary<TKey, TValue> 
            where TValue : ILibraryEntry<TKey, TValue> 
    {
        [Header("Library")]
        
        [SerializeField]
        private List<TValue> entries = new();

        public List<TValue> Entries => entries;
    }
}
