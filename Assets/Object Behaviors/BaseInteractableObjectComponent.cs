using Assets;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// Enables a game object to contain and execute behaviors 
/// </summary>
public abstract class BaseInteractableObjectComponent : MonoBehaviour
{
    /// <summary>
    /// Default Constructor 
    /// </summary>
    protected BaseInteractableObjectComponent()
    {
        Behaviors = new List<BaseBehavior>();
    }

    public List<BaseBehavior> Behaviors { get; set; }

    /// <summary>
    /// Tries to executes the behavior. Breaks after the first successful execution 
    /// </summary>
    /// <param name="behaviorCommand"> The Beaver Behavior to try to execute </param>
    /// <returns>Whether a behavior was executed successfully</returns>
    public bool ExecuteBehaviors(BeaverBehaviors behaviorCommand)
    {
        foreach (var behavior in Behaviors)
        {
            if (behavior.TryExecute(behaviorCommand))
            {
                return true;
            }
        }

        return false;
    }
}