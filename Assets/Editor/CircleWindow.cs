using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

public class CircleWindow : EditorWindow
{
    [MenuItem("Window/Circle Renderer Global Settings")]
    static void Init()
    {
        CircleWindow window = (CircleWindow)EditorWindow.GetWindow(typeof(CircleWindow));
        window.Show();
    }

    private void OnGUI()
    {
        CircleRenderer.someBool = EditorGUILayout.Toggle("Some bool", CircleRenderer.someBool);
    }
}
