using UnityEngine;
using UnityEngine.InputSystem;

public class CameraController : MonoBehaviour
{
    public float sensitivity = 0.1f;
    private Vector2 lookInput;
    private float xRotation = 0f;

    void Update()
    {
        // 1. Read the mouse delta (movement since last frame)
        lookInput = Mouse.current.delta.ReadValue();

        // 2. Calculate rotation values
        float mouseX = lookInput.x * sensitivity;
        float mouseY = lookInput.y * sensitivity;

        // 3. Handle Vertical Rotation (Pitch) - Clamped to prevent flipping
        xRotation -= mouseY;
        xRotation = Mathf.Clamp(xRotation, -90f, 90f);

        // 4. Apply rotations
        transform.localRotation = Quaternion.Euler(xRotation, transform.localEulerAngles.y + mouseX, 0f);
    }
    
    private void Start()
    {
        // Locks and hides the cursor for a standard FPS/3D feel
        Cursor.lockState = CursorLockMode.Locked;
    }
}