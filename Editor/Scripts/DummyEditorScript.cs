using UnityEditor;
using UnityEngine;

namespace CodeLibrary24.CustomPackageTemplate
{
    public class DummyEditorScript : Editor
    {
        private void OnEnable()
        {
            Debug.Log("Editor test script");
        }
    }
}