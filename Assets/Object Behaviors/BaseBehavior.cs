using Assets;
using UnityEngine;

/// <summary>
/// Base class for any behavior. To be used for any behavior class added to BaseInteractableObjectComponent 
/// </summary>
public abstract class BaseBehavior
{
    /// <summary>
    /// Initializes a new instace of the <see cref="BaseBehavior"/> class
    /// </summary>
    protected BaseBehavior()
    {
    }

    public void SetGameObject(GameObject gameObject)
    {
        BaseGameObject = gameObject;
    }

    /// <summary>
    /// Reference to the object this is attached to 
    /// </summary>
    public GameObject BaseGameObject { get; private set; }

    /// <summary>
    /// Validated against an attempted behavior 
    /// </summary>
    public BeaverBehaviorType Type { get; set; }

    /// <summary>
    /// Executes the behavior, regardless if the behavior is the correct one 
    /// </summary>
    /// <remarks> Should be called by TryExecute which will validate the behavior attempted </remarks>
    public abstract void Execute();
}