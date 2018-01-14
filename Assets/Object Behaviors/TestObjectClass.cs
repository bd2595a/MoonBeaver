/// <summary>
/// Test Object 
/// </summary>
public class TestObjectClass : BaseInteractableObjectComponent
{
    private void Start()
    {
        AddBehavior<CompressableBehavior>(this.gameObject);
        AddBehavior<CarryBehavior>(this.gameObject);
    }
}