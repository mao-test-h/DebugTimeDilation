#if UNITY_EDITOR && !DISABLE_DEBUG_SLOMO
namespace MainContents.DebugUtility
{
    using UnityEngine;
    using UnityEditor;

    /// <summary>
    /// デバッグ機能 : ゲームスピード管理
    /// </summary>
    public sealed class DebugTimeDilation : MonoBehaviour
    {
        [System.Serializable]
        public struct KeySet
        {
            public KeyCode Key;
            public float TimeDilation;
        }

        const string SettingsGUID = "1cc6dcf1a4f07ce48965d736c8485719";
        DebugTimeDilationSettings _settings;

        [RuntimeInitializeOnLoadMethod]
        static void Initialize()
        {
            var obj = new GameObject("___DebugSlomo", typeof(DebugTimeDilation));
            obj.hideFlags = HideFlags.HideInHierarchy;
            DontDestroyOnLoad(obj);
        }

        void Start()
        {
            this._settings = AssetDatabase.LoadAssetAtPath<DebugTimeDilationSettings>(AssetDatabase.GUIDToAssetPath(SettingsGUID));
        }

        void Update()
        {
            if (this._settings == null) { return; }
            foreach (var setting in this._settings.KeySets)
            {
                if (Input.GetKeyDown(setting.Key))
                {
                    Time.timeScale = setting.TimeDilation;
                }
            }
        }
    }
}
#endif
