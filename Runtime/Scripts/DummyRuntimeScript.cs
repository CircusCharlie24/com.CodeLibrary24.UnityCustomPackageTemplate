using UnityEngine;

namespace CodeLibrary24.CustomPackageTemplate
{
    public class DummyRuntimeScript : MonoBehaviour
    {
        private void OnEnable()
        {
            Debug.Log("Runtime test script");
        }
    }
}