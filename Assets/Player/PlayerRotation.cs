using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerRotation : TopDownController
{
    //Determine mouse position and look that way
    private void OnLook(InputValue value)
    {
        Vector2 mousePosition = Camera.main.ScreenToWorldPoint (value.Get<Vector2>());
        LookAt(mousePosition);
    }
}
