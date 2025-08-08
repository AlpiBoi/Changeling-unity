using UnityEngine;

[RequireComponent(typeof(Rigidbody2D), typeof(SpriteRenderer), typeof(Collider2D))]

public class playerController : MonoBehaviour
{
    private bool grounded = false;
    private float groundCheckRadius = 0.02f;
    private LayerMask gl;
    private Rigidbody2D rb;
    private SpriteRenderer sr;
    private Collider2D col;
    private Vector2 groundCheckPos => new Vector2(col.bounds.min.x + col.bounds.extents.x, col.bounds.min.y);
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

        rb = GetComponent<Rigidbody2D>();
        sr = GetComponent<SpriteRenderer>();
        gl = LayerMask.GetMask("ground");
        col = GetComponent<Collider2D>();

        if(gl == 0)
        {
            Debug.LogWarning("ground layer is not set, set it in LayerMask");
        }
 
    }

    // Update is called once per frame
    void Update()
    {
        //left-right movement
        float hValue = Input.GetAxis("Horizontal");
        spriteFlip(hValue);
        rb.linearVelocityX = hValue * 5f;

        //groundcheck
        grounded = Physics2D.OverlapCircle(groundCheckPos, groundCheckRadius, gl);

        //jump
        if (Input.GetButtonDown("Jump") && grounded)
        {
            rb.AddForce(Vector2.up * 8f, ForceMode2D.Impulse);
        }

        
    }

    void spriteFlip(float hValue)
    {
    if(hValue < 0)
    {
        sr.flipX = true;
    }
    else if(hValue> 0)
    {
        sr.flipX = false;
    }
    }
}


