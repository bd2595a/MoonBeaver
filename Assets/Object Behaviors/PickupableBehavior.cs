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
    /// <param name="baseGameObject">The object to act on</param>
    public PickupableBehavior(GameObject baseGameObject) : base(baseGameObject)
    {
        this.Behavior = BeaverBehaviorsEnum.PickUp;
    }

    /// <summary>
    /// Modifies behavior enum to signal BeaverInteractComponent that the object can be picked up
    /// </summary>
    protected override void Execute()
    {
    }
}