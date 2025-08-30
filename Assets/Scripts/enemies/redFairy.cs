using UnityEngine;

[RequireComponent (typeof(Rigidbody2D))]


public class redFairy : enemy
{
    private Rigidbody2D rb;
    [SerializeField, Range(1f, 10f)] private float xVelocity = 2f;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    protected override void Start()
    {
        base.Start();
        rb = GetComponent<Rigidbody2D>();
        rb.collisionDetectionMode = CollisionDetectionMode2D.Continuous;
        rb.sleepMode = RigidbodySleepMode2D.NeverSleep;
    }

    public override void TakeDmg(int Dmg)
    {
        base.TakeDmg(Dmg);
        rb.linearVelocityX = 0;

    }
    // Update is called once per frame
    void Update()
    {
        AnimatorStateInfo stateInfo = anim.GetCurrentAnimatorStateInfo(0);

        if (stateInfo.IsName("redFairyWalk"))
        {
            rb.linearVelocityX = (sr.flipX) ? -xVelocity : xVelocity;
        }
    }

    private void OnTriggerEnter2D(Collider2D col)
    {
        if (col.CompareTag("barrier"))
        {
            sr.flipX = !sr.flipX;
        }
    }

    public void Dies()
    {
        Destroy(transform.parent.gameObject);
    }
}
