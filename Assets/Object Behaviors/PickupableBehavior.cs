using Assets;
using UnityEngine;

/// <summary>
/// Attribute that allows an object to be picked up and put down 
/// </summary>
public class CarryBehavior : BaseBehavior
{
    /// <summary>
    /// Default Constructor 
    /// </summary>
    /// <param name="baseGameObject"> The object to act on </param>
    public CarryBehavior(GameObject baseGameObject)
        : base(baseGameObject)
    {
        Behavior = BeaverBehaviors.PickUp;
    }

    /// <summary>
    /// Beaver will pick up the object if it's not already holding it 
    /// </summary>
    /// <param name="objectTransform"> Transform of the object to try to pick up </param>
    protected override void Execute()
    {
        if (BeaverAttributesComponent.CarriedObject == null)
        {
            BaseGameObject.transform.parent = GameManager.BeaverTransform;
            BeaverAttributesComponent.CarriedObject = BaseGameObject.transform;
        }
    }
}