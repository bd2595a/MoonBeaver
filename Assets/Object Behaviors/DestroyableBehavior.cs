using Assets;
using UnityEngine;

/// <summary>
/// Attribute that allows an object to be destroyed
/// </summary>
public class DestroyableBehavior : BaseBehavior
{
    /// <summary>
    /// Default Constructor
    /// </summary>
    /// <param name="baseGameObject">BaseObject to act upon</param>
    public DestroyableBehavior(GameObject baseGameObject) : base(baseGameObject)
    {
        this.Behavior = BeaverBehaviorsEnum.Destroy;
    }

    /// <summary>
    /// Destroys this object
    /// </summary>
    protected override void Execute()
    {
        Object.DestroyObject(BaseGameObject);
    }
}