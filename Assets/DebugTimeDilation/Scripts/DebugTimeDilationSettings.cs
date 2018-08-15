#if UNITY_EDITOR && !DISABLE_DEBUG_SLOMO
namespace MainContents.DebugUtility
{
    using UnityEngine;

    [CreateAssetMenu(menuName = "DebugUtility/DebugTimeDilationSettings", fileName = "DebugTimeDilationSettings")]
    public sealed class DebugTimeDilationSettings : ScriptableObject
    {
        [SerializeField] DebugTimeDilation.KeySet[] _keySets;
        public DebugTimeDilation.KeySet[] KeySets
        {
            get { return this._keySets; }
        }
    }
}
#endif
