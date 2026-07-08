using UnityEngine;
using UnityEngine.InputSystem;

public class CarController : MonoBehaviour
{
    InputAction moveAction;

    [SerializeField]
    float speed = 5f;
    float turnSpeed = 45f;


    // Start is called once befor
    // e the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        moveAction = InputSystem.actions.FindAction("Player/Move");

    }

    // Update is called once per frame
    void Update()
    {
        Vector2 moveInput = moveAction.ReadValue<Vector2>();
        Vector3 moveDirection = new Vector3(moveInput.x, 0, moveInput.y);
        Vector3 horDirection = new Vector3(0, moveInput.x, 0);
        transform.Translate(moveDirection * speed * Time.deltaTime);
        transform.Rotate(horDirection * turnSpeed * Time.deltaTime);


    }
}
