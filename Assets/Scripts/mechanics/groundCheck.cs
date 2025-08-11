using UnityEngine;

public class groundCheck
{
    public bool grounded;
    public bool Grounded => grounded;
    private LayerMask gl;
    private Collider2D col;
    private Rigidbody2D rb;
    private float groundCheckRadius;
 private Vector2 groundCheckPos => new Vector2(col.bounds.min.x + col.bounds.extents.x, col.bounds.min.y);

    public groundCheck(Collider2D collider, LayerMask layerMask,float checkRadius)
    {
        col = collider;
        gl = layerMask;
        groundCheckRadius = checkRadius;
        rb = col.GetComponent<Rigidbody2D>();


    }

    public void CheckIsGrounded()
    {
        if (!grounded && rb.linearVelocityY < 0)
        {
            grounded = Physics2D.OverlapCircle(groundCheckPos, groundCheckRadius, gl);
        }
        else if (grounded) grounded = Physics2D.OverlapCircle(groundCheckPos, groundCheckRadius, gl);
    }

    public void UpdateGroundCheckRadius(float newRadius)
    {
        groundCheckRadius = newRadius;
        Debug.Log($"Updated Ground Check Radius: {groundCheckRadius}");
    }
}
