using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.XR;
using UnityEngine.XR.Interaction.Toolkit;

public class PointerRaycast : MonoBehaviour
{
    public XRRayInteractor rayInteractor;
    private ActionBasedController actionController;
    private InputHelpers.Button triggerButton = InputHelpers.Button.Trigger;

    private void Awake()
    {
        // Get the right-hand ActionBasedController component
        actionController = GetComponent<ActionBasedController>();
    }

    private void Update()
    {
        RaycastHit res;
        if (rayInteractor.TryGetCurrent3DRaycastHit(out res))
        {
            Vector3 groundPt = res.point; // the coordinate that the ray hits
            Debug.Log(" coordinates on the ground: " + res.collider.gameObject.name);
            // Check if the trigger button is pressed
            if (actionController.selectAction.action.ReadValue<float>() > 0.1f && res.collider.gameObject.name == "school")
            {
                // Trigger button is pressed
                Debug.Log("Trigger button is pressed");
            }
        }
    }
}
