﻿using Assets;
using UnityEngine;

/// <summary>
/// Uses BeaverInputComponent to call upon external object's behaviors 
/// </summary>
public class BeaverInteractComponent
{
    /// <summary>
    /// Default Constructor 
    /// </summary>
    /// <param name="beaverObjectTransform"> Beaver's transform </param>
    public BeaverInteractComponent(Transform beaverObjectTransform)
    {
        BeaverTransform = beaverObjectTransform;
    }

    private Transform BeaverTransform { get; set; }

    private Transform PickedUpObject { get; set; }

    /// <summary>
    /// Attempts to call the behavior on the object 
    /// </summary>
    /// <param name="beaverBehavior"> BeaverBehaviorEnum behavior to execute </param>
    public void CallBehavior(BeaverBehaviorType beaverBehavior)
    {
        if (beaverBehavior != BeaverBehaviorType.None)
        {
            // Can drop an item at any time
            if (beaverBehavior == BeaverBehaviorType.Carry && BeaverAttributesComponent.CarriedObject != null)
            {
                DropObject();
                return;
            }

            var transformInfront = GetTransformInFront();
            if (transformInfront != null)
            {
                var interactObjectBehaviors = transformInfront.gameObject.GetComponent<BaseInteractableObjectComponent>();
                if (interactObjectBehaviors != null)
                {
                    interactObjectBehaviors.ExecuteBehavior(beaverBehavior);
                }
            }
        }
    }

    /// <summary>
    /// Beaver will drop whatever object it is holding 
    /// </summary>
    private void DropObject()
    {
        BeaverAttributesComponent.CarriedObject.parent = null;
        BeaverAttributesComponent.CarriedObject = null;
    }

    /// <summary>
    /// Finds the BeaverTransform in front of the beaver 
    /// </summary>
    /// <returns> Raycast hit's BeaverTransform </returns>
    private Transform GetTransformInFront()
    {
        RaycastHit hit;
        var forwardDirectionVector = BeaverTransform.TransformDirection(Vector3.forward);
        if (Physics.Raycast(BeaverTransform.position, forwardDirectionVector, out hit, 2f))
        {
            return hit.transform;
        }

        return null;
    }
}