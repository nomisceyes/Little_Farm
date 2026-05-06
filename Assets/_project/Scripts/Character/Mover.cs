using UnityEngine;

public class Mover : MonoBehaviour
{
    public Rigidbody2D RigidBody;
    public Vector2 MoveDirection;
    public float Speed;

    private InputSystem _inputSystem;

    private void Awake()
    {
        _inputSystem = new InputSystem();

        _inputSystem.Enable();
    }

    private void Update()
    {
        MoveDirection = _inputSystem.Player.Move.ReadValue<Vector2>();
    }

    private void FixedUpdate()
    {
        Move();
    }

    private void Move()
    {
        Vector2 targetPosition = RigidBody.position + MoveDirection * (Speed * Time.fixedDeltaTime);
        
        RigidBody.MovePosition(targetPosition);
    }
}