using Assets;
using UnityEngine;

/// <summary>
/// Attribute that allows an object to be destroyed 
/// </summary>
public class DestroyableBehavior : BaseBehavior
{
    public DestroyableBehavior()
    {
        Type = BeaverBehaviorType.Destroy;
    }

    /// <summary>
    /// Destroys this object 
    /// </summary>
    public override void Execute()
    {
        Object.DestroyObject(BaseGameObject);
    }
}