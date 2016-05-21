using Assets;
using UnityEngine;

/// <summary>
/// Attribute that allows an object to be picked up and put down 
/// </summary>
public class PickupableBehavior : BaseBehavior
{
    /// <summary>
    /// Default Constructor 
    /// </summary>
    /// <param name="baseGameObject"> The object to act on </param>
    public PickupableBehavior(GameObject baseGameObject)
        : base(baseGameObject)
    {
        Behavior = BeaverBehaviors.PickUp;
    }

    /// <summary>
    /// Currently does nothing 
    /// </summary>
    protected override void Execute()
    {
    }
}