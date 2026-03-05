using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float speed;
    Rigidbody2D rb;
    [HideInInspector]
    public float lastHorizontal;
    [HideInInspector]
    public float lastVertical;
    [HideInInspector]
    public Vector2 movDirection;
    [HideInInspector]
    public Vector2 lastMovedVector;

    PlayerStats player;

    void Start()
    {
        player = GetComponent<PlayerStats>();
        rb = GetComponent<Rigidbody2D>();
        lastMovedVector = new Vector2(1, 0f);
    }

    void Update()
    {
        InputManagement();
    }

    void FixedUpdate()
    {
        Movement();
    }
    
    void InputManagement()
    {
        float moveX = Input.GetAxisRaw("Horizontal");
        float moveY = Input.GetAxisRaw("Vertical");
        
        movDirection = new Vector2(moveX, moveY).normalized;

        if (movDirection.x != 0)
        {
            lastHorizontal = movDirection.x;
            lastMovedVector = new Vector2(lastHorizontal, 0f);
        }
        
        if (movDirection.y != 0)
        {
            lastVertical = movDirection.y;
            lastMovedVector = new Vector2(0f, lastVertical);
        }

        if (movDirection.x != 0 && movDirection.y != 0)
        {
            lastMovedVector = new Vector2(lastHorizontal, lastVertical);
        }
    }
    
    void Movement()
    {
        rb.linearVelocity = new  Vector2(movDirection.x * player.CurrentMoveSpeed, movDirection.y * player.CurrentMoveSpeed);
    }
}
