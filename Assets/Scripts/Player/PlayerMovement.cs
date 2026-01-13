using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float speed;
    Rigidbody2D rb;
    [HideInInspector]
    public Vector2 movDirection;
    [HideInInspector]
    public float lastHorizontal;
    [HideInInspector]
    public float lastVertical;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
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
        }
        
        if (movDirection.y != 0)
        {
            lastVertical = movDirection.y;
        }
    }
    
    void Movement()
    {
        rb.linearVelocity = new  Vector2(movDirection.x * speed, movDirection.y * speed);
    }
}
