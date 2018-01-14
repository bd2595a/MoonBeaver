using Assets;
using UnityEngine;

/// <summary>
/// Input component for Beaver GameObject 
/// </summary>
public class BeaverInputComponent
{
    /// <summary>
    /// Takes in player input and resolves it to a BeaverAction 
    /// </summary>
    /// <returns> Corresponding BeaverBehaviorType </returns>
    public BeaverBehaviorType GetAction()
    {
        if (Input.anyKey)
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                return BeaverBehaviorType.Carry;
            }

            if (Input.GetKeyDown(KeyCode.N))
            {
                return BeaverBehaviorType.Compress;
            }
        }

        return BeaverBehaviorType.None;
    }

    /// <summary>
    /// Calls input to get the x axis of player's input 
    /// </summary>
    /// <returns> Raw X axis value from keyboard input </returns>
    public float GetBeaverX()
    {
        return Input.GetAxisRaw("Horizontal");
    }

    /// <summary>
    /// Calls input to get the Z axis of player's input 
    /// </summary>
    /// <returns> Raw Z axis value from keyboard input </returns>
    public float GetBeaverZ()
    {
        return Input.GetAxisRaw("Vertical");
    }
}