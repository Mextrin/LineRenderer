using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(LineRenderer))]
public class CircleRenderer : MonoBehaviour
{
    [SerializeField, Tooltip("Radius of the circle")] float radius = 3f;
    [SerializeField, Range(3, 20), Tooltip("Amount of sides in the circle")] int segments = 10;
    [Tooltip("I couldn't come up with anything better and didn't want to have radius and segments static so I made this just togglable bool that does nothing")] public static bool someBool;

    public float Radius
    {
        get => radius;
        set
        {
            radius = value;
            UpdateRenderer();
        }
    }

    void Start()
    {
    }

    void Update()
    {
        
    }

    void UpdateRenderer()
    {
        Vector3[] positions = new Vector3[segments + 1];
        for (int i = 0; i < positions.Length; i++)
        {
            Quaternion rotation = Quaternion.Euler(new Vector3(0, (360 / segments + 1) * i, 0));
            positions[i] = rotation * new Vector3(0, 0, radius) + transform.position;
        }

        LineRenderer lineRenderer = GetComponent<LineRenderer>();
        lineRenderer.positionCount = positions.Length;
        lineRenderer.SetPositions(positions);
    }
}
