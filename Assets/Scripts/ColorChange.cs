using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class ColorChange : MonoBehaviour
{
    public InputActionReference colorChangeReference = null;

    private MeshRenderer meshRenderer = null;
    private float lastValue = 0.0f;

    void Awake()
    {
        meshRenderer = GetComponent<MeshRenderer>();
    }

    // random color
    void Update()
    {
        float value = colorChangeReference.action.ReadValue<float>();
        if (value != lastValue)
        {
            UpdateColor(value);
            lastValue = value;
        }
    }

    // random color
    private void UpdateColor(float newValue)
    {
        meshRenderer.material.color = new Color(newValue, newValue, 0.0f);
    }
}