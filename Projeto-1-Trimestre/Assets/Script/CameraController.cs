using UnityEngine;
using UnityEngine.InputSystem;

public class CameraController : MonoBehaviour
{
    public float sensitivity = 0.1f;
    public Transform playerBody;

    private Vector2 lookInput;
    private float xRotation = 0f;

    void Start()
    {
        // Lock the cursor to the center of the screen
        //Cursor.lockState = CursorLockMode.Locked;
    }

    // This method is called by the Player Input component (Unity Events)
    public void OnLook(InputValue value)
    {
        lookInput = value.Get<Vector2>();
    }

    void LateUpdate()
    {
        // Calculate rotations
        float mouseX = lookInput.x * sensitivity;
        float mouseY = lookInput.y * sensitivity;

        xRotation -= mouseY;
        xRotation = Mathf.Clamp(xRotation, -90f, 90f); // Prevents flipping over

        // Apply rotations
        transform.localRotation = Quaternion.Euler(xRotation, 0f, 0f);
        playerBody.Rotate(Vector3.up * mouseX);
    }
}