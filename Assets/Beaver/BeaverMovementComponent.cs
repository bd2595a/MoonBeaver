using UnityEngine;

/// <summary>
/// Uses Beaver Input Component and controls turning and moving 
/// </summary>
public class BeaverMovementComponent
{
    private const float movementSpeed = 5f;
    private const float rotateSpeed = 5f;
    private readonly Transform beaverTransform;
    private readonly Quaternion cameraDefaultRotation;
    private readonly Transform cameraTransform;
    private readonly Rigidbody rigidbody;

    /// <summary>
    /// Creates the BeaverMovementComponent 
    /// </summary>
    /// <param name="beaverRigidbody"> Beaver's rigidbody </param>
    /// <param name="beaverTransform"> Beaver's beaverTransform </param>
    public BeaverMovementComponent(Rigidbody beaverRigidbody, Transform beaverTransform)
    {
        rigidbody = beaverRigidbody;
        this.beaverTransform = beaverTransform;
        cameraTransform = this.beaverTransform.GetChild(0).transform;
        cameraDefaultRotation = cameraTransform.localRotation;
    }

    /// <summary>
    /// Moves and Turns the gameObject using Movement 
    /// </summary>
    /// <param name="x"> X destination coordinate </param>
    /// <param name="z"> Z destination coordinate </param>
    public void UpdateMovement(float x, float z)
    {
        if (x != 0 || z != 0)
        {
            var targetDirectionVector = new Vector3(x, 0f, z);
            Move(targetDirectionVector);
            Turn(targetDirectionVector);
        }

        rigidbody.velocity = Vector3.zero;
        rigidbody.angularVelocity = Vector3.zero;
        rigidbody.rotation = new Quaternion(0f, rigidbody.rotation.y, 0f, rigidbody.rotation.w);
        cameraTransform.rotation = cameraDefaultRotation;
    }

    /// <summary>
    /// Moves the player on the x and z axis 
    /// </summary>
    /// <param name="targetDirectionVector"> Target Vector3 to move towards </param>
    private void Move(Vector3 targetDirectionVector)
    {
        var movementVector = targetDirectionVector.normalized * movementSpeed * Time.deltaTime;
        beaverTransform.position += movementVector;
    }

    /// <summary>
    /// Turns the player according to the targetDirectionVector direction 
    /// </summary>
    /// <param name="targetDirectionVector"> Target Vector3 to move towards </param>
    private void Turn(Vector3 targetDirectionVector)
    {
        var targetRotation = Quaternion.LookRotation(targetDirectionVector, Vector3.up);
        var endRotation = Quaternion.Lerp(rigidbody.rotation, targetRotation, rotateSpeed * Time.deltaTime);
        beaverTransform.rotation = endRotation;
    }
}