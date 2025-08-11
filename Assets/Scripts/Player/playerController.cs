using UnityEngine;

[RequireComponent(typeof(Rigidbody2D), typeof(SpriteRenderer), typeof(Collider2D))]
[RequireComponent(typeof(Animator))]
public class playerController : MonoBehaviour
{
    [SerializeField]private float groundCheckRadius = 0.02f;
    private Animator anim;
    private Rigidbody2D rb;
    private SpriteRenderer sr;
    private Collider2D col;
    private groundCheck groundcheck;
    private float initialGroundCheckRadius;
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

        rb = GetComponent<Rigidbody2D>();
        sr = GetComponent<SpriteRenderer>();
        col = GetComponent<Collider2D>();
        anim = GetComponent<Animator>();
        groundcheck = new groundCheck(col, LayerMask.GetMask("ground"), groundCheckRadius);
        initialGroundCheckRadius = groundCheckRadius;
    }

    // Update is called once per frame
    void Update()
    {
        //left-right movement
        float hValue = Input.GetAxisRaw("Horizontal");
        spriteFlip(hValue);
        rb.linearVelocityX = hValue * 5f;
        groundcheck.CheckIsGrounded();
        AnimatorStateInfo currentState = anim.GetCurrentAnimatorStateInfo(0);

        if (!currentState.IsName("basic") && Input.GetButtonDown("Fire1"))
        {
            anim.SetTrigger("basic");
        }
        if (currentState.IsName("basic"))
        {
            rb.linearVelocity = Vector2.zero;
        }
        //jump
        if (Input.GetButtonDown("Jump") && groundcheck.grounded)
        {
            rb.AddForce(Vector2.up * 8f, ForceMode2D.Impulse);
        }

        anim.SetFloat("hValue", Mathf.Abs(hValue));
        anim.SetBool("grounded", groundcheck.grounded);
        if (initialGroundCheckRadius != groundCheckRadius)
            groundcheck.UpdateGroundCheckRadius(initialGroundCheckRadius);
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


