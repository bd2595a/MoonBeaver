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
        Behaviors = new Dictionary<BeaverBehaviorType, BaseBehavior>();
    }

    private Dictionary<BeaverBehaviorType, BaseBehavior> Behaviors { get; set; }

    public void AddBehavior<T>(GameObject attachedGameObject) where T : BaseBehavior, new()
    {
        var behavior = new T();
        behavior.SetGameObject(attachedGameObject);
        Behaviors[behavior.Type] = behavior;
    }

    /// <summary>
    /// Tries to executes the behavior
    /// </summary>
    /// <param name="behaviorCommand"> The Beaver Type to try to execute </param>
    /// <returns>Whether a behavior was executed successfully</returns>
    public void ExecuteBehavior(BeaverBehaviorType behaviorCommand)
    {
        if (Behaviors.ContainsKey(behaviorCommand))
        {
            Behaviors[behaviorCommand].Execute();
        }
    }
}