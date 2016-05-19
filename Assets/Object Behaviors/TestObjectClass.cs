/// <summary>
/// Test Object
/// </summary>
public class TestObjectClass : BaseInteractableObjectComponent
{
    private void Start()
    {
        Behaviors.Add(new CompressableBehavior(gameObject));
        Behaviors.Add(new PickupableBehavior(gameObject));
    }
}