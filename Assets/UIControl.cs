using UnityEngine;

/// <summary>
/// UI Control. Takes in input and manipulates UI elements
/// </summary>
public class UiControl : MonoBehaviour
{
    public GameObject GridOverlayGameObject { get; set; }

    private bool gridOverlayVisible { get; set; }

    private void Start()
    {
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Q))
        {
            GridOverlayGameObject.SetActive(gridOverlayVisible);
            gridOverlayVisible = !gridOverlayVisible;
        }
    }
}