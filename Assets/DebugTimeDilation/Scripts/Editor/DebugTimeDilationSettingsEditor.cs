#if UNITY_EDITOR && !DISABLE_DEBUG_SLOMO
namespace MainContents.DebugUtility
{
    using UnityEditor;

    [CustomEditor(typeof(DebugTimeDilationSettings))]
    public class DebugTimeDilationSettingsEditor : Editor
    {
        public override void OnInspectorGUI()
        {
            string guid = UnityEditor.AssetDatabase.AssetPathToGUID(UnityEditor.AssetDatabase.GetAssetPath(base.target.GetHashCode()));
            EditorGUILayout.BeginHorizontal();
            EditorGUILayout.LabelField("GUID : ");
            EditorGUILayout.TextField(guid);
            EditorGUILayout.EndHorizontal();
            base.OnInspectorGUI();
        }
    }
}
#endif
