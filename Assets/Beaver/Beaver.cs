namespace Assets
{
    using UnityEngine;

    /// <summary>
    /// Attach to Beaver Object. Contains all of Beaver's components 
    /// </summary>
    public class Beaver : MonoBehaviour
    {
        /// <summary>
        /// Takes in keyboard input 
        /// </summary>
        public BeaverInputComponent InputComponent { get; private set; }

        /// <summary>
        /// Acts on other objects using InputComponent data 
        /// </summary>
        public BeaverInteractComponent InteractComponent { get; private set; }

        /// <summary>
        /// Moves beaver using InputComponent data 
        /// </summary>
        public BeaverMovementComponent MovementComponent { get; private set; }

        private void Start()
        {
            MovementComponent = new BeaverMovementComponent(gameObject.GetComponent<Rigidbody>(), gameObject.transform);
            InputComponent = new BeaverInputComponent();
            InteractComponent = new BeaverInteractComponent(gameObject.transform);
        }

        private void Update()
        {
            MovementComponent.UpdateMovement(InputComponent.GetBeaverX(), InputComponent.GetBeaverZ());
            InteractComponent.CallBehavior(InputComponent.GetAction());
        }
    }
}