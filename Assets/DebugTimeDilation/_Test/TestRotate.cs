namespace MainContents.DebugUtility.Test
{
    using UnityEngine;

    // 動作確認用
    public sealed class TestRotate : MonoBehaviour
    {
        void Update()
        {
            var euler = new Vector3(10.5f, 10f, 0f) * Time.deltaTime;
            this.transform.rotation *= Quaternion.Euler(euler);
        }
    }
}