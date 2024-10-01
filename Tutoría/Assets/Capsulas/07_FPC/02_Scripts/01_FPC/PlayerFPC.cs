using UnityEngine;

public class PlayerFPC : MonoBehaviour
{
    [SerializeField] private float normalSpeed = 5;
    [SerializeField] private float runSpeed = 10;
    [SerializeField] private float jumpForce = 5;
    [SerializeField] private float gravityModifier = 2;

    [SerializeField] private float groundRayLength = 0.5f;
    [SerializeField] private LayerMask groundMask;

    [SerializeField] private bool debugMode;

    private Rigidbody rb;
    private float speed, horizontal, vertical;

    private void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    private void Update()
    {
        DirectionInput();
        RunInput();
        JumpInput();

        MovePlayer();

        DebugMode();
    }

    private void DirectionInput()
    {
        horizontal = Input.GetAxisRaw("Horizontal");
        vertical = Input.GetAxisRaw("Vertical");
    }

    private void RunInput()
    {
        if (Input.GetKey(KeyCode.LeftShift))
        {
            speed = runSpeed;
        }
        else
        {
            speed = normalSpeed;
        }

        //speed = Input.GetKey(KeyCode.LeftShift) ? runSpeed : normalSpeed;
        //variable = condition ? valueIfTrue : valueIfFalse;
    }

    private void MovePlayer()
    {
        Vector3 moveDirection = new Vector3(horizontal, 0, vertical).normalized;
        moveDirection = transform.TransformDirection(moveDirection);
        moveDirection *= speed;

        Vector3 currentVelocity = rb.velocity;

        Vector3 newVelocity = new Vector3(moveDirection.x, currentVelocity.y, moveDirection.z);

        rb.velocity = newVelocity;
    }

    private void JumpInput()
    {
        if (Input.GetKeyDown(KeyCode.Space) && IsGrounded())
        {
            rb.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
        }

        if (!IsGrounded() && rb.velocity.y < 0)
        {
            rb.velocity += Vector3.up * Physics.gravity.y * (gravityModifier - 1) * Time.deltaTime;
        }
    }

    private bool IsGrounded()
    {
        return Physics.Raycast(transform.position, Vector3.down, groundRayLength, groundMask);
    }

    private void DebugMode()
    {
        if (debugMode)
        {
            Debug.DrawRay(transform.position, Vector3.down * groundRayLength, Color.red);
        }
    }
}
