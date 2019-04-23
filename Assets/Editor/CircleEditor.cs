using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

[CustomEditor(typeof(CircleRenderer))]
public class CircleEditor : Editor
{
    CircleRenderer renderer;
    private void OnSceneGUI()
    {
        renderer = target as CircleRenderer;

        renderer.Radius = (Handles.RadiusHandle(Quaternion.identity, renderer.transform.position, renderer.Radius));
    }
}
