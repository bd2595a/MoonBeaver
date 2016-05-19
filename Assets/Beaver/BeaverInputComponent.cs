using Assets;
using UnityEngine;

/// <summary>
/// Input component for Beaver GameObject
/// </summary>
public class BeaverInputComponent
{
    /// <summary>
    ///     Calls input to get the x axis of player's input
    /// </summary>
    /// <returns>Raw X axis value from keyboard input</returns>
    public float GetBeaverX()
    {
        return Input.GetAxisRaw("Horizontal");
    }

    /// <summary>
    ///     Calls input to get the Z axis of player's input
    /// </summary>
    /// <returns>Raw Z axis value from keyboard input</returns>
    public float GetBeaverZ()
    {
        return Input.GetAxisRaw("Vertical");
    }

    /// <summary>
    ///     Takes in player input and resolves it to a BeaverActionEnum
    /// </summary>
    /// <returns>Corresponding BeaverBehaviorsEnum</returns>
    public BeaverBehaviorsEnum GetActionInput()
    {
        if (Input.anyKey)
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                return BeaverBehaviorsEnum.TryPickUp;
            }

            if (Input.GetKeyDown(KeyCode.N))
            {
                return BeaverBehaviorsEnum.Compress;
            }
        }

        return BeaverBehaviorsEnum.None;
    }
}