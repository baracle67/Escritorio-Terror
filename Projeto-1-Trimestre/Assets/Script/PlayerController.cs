using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerController : MonoBehaviour
{
    public InputActionAsset playerInput;
    InputAction moveAction;
    InputAction rotateAction;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Move();
    }

    void Move()
    {
        Vector2 direction = moveAction.ReadValue<Vector2>();
        transform.position += new Vector3(direction.x, 0, direction.y) * Time.deltaTime;
    }

    private void Awake()
    {
        moveAction = InputSystem.actions.FindAction("Move");
        rotateAction = InputSystem.actions.FindAction("Rotation");
    }

}
