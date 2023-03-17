using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class ToggleObject : MonoBehaviour
{
    public InputActionReference toggleReference = null;

    void Awake()
    {
        toggleReference.action.performed += Toggle;
    }

    private void OnDestory()
    {
        toggleReference.action.performed -= Toggle;
    }

    private void Toggle(InputAction.CallbackContext context)
    {
        bool isActive = !gameObject.activeSelf;
        gameObject.SetActive(isActive);
    }
}