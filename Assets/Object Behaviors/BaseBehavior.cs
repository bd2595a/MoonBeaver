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
    /// <param name="baseGameObject"> Behavior's GameObject </param>
    protected BaseBehavior(GameObject baseGameObject)
    {
        this.BaseGameObject = baseGameObject;
    }

    /// <summary>
    /// Reference to the object this is attached to 
    /// </summary>
    protected GameObject BaseGameObject { get; set; }

    /// <summary>
    /// Validated against an attempted behavior 
    /// </summary>
    protected BeaverBehaviors Behavior { get; set; }

    /// <summary>
    /// Validates and executes the behavior if possible 
    /// </summary>
    /// <param name="attemptedBehavior"> Behavior to try to execute </param>
    /// <returns> True if attempted behavior matches base Behavior </returns>
    public bool TryExecute(BeaverBehaviors attemptedBehavior)
    {
        if (Behavior == attemptedBehavior)
        {
            Execute();
            return true;
        }

        return false;
    }

    /// <summary>
    /// Executes the behavior, regardless if the behavior is the correct one 
    /// </summary>
    /// <remarks> Should be called by TryExecute which will validate the behavior attempted </remarks>
    protected abstract void Execute();
}