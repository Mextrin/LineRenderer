using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

public class CircleWindow : EditorWindow
{
    CircleRenderer circleRenderer;
    [MenuItem("Window/Circle Renderer Settings")]
    static void Init()
    {
        CircleWindow window = (CircleWindow)EditorWindow.GetWindow(typeof(CircleWindow));
        window.Show();
    }

    private void OnGUI()
    {
        circleRenderer = (CircleRenderer)EditorGUILayout.ObjectField(circleRenderer, typeof(CircleRenderer), true);
        if (circleRenderer)
        {
            circleRenderer.Radius = EditorGUILayout.FloatField("Radius", circleRenderer.Radius);
            circleRenderer.Segments = EditorGUILayout.IntSlider("Segments", circleRenderer.Segments, 3, 20);
        }
    }
}
