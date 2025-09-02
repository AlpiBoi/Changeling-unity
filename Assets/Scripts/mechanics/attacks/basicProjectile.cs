using UnityEngine;

public class basicProjectile : MonoBehaviour
{
    [SerializeField] private int dmg;
    [SerializeField, Range(1, 20)] private float lifetime = 2.0f;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Destroy(gameObject, lifetime);

    }

    private void OnCollisionEnter2D(Collision2D col)
    {
        playerController player = col.gameObject.GetComponent<playerController>();
        enemy enemy = col.gameObject.GetComponent<enemy>();
        if (enemy != null)
        {
            enemy.TakeDmg(dmg);
        }
        if (player != null)
        {
            player.TakeDMG(dmg);
        }

        Destroy(gameObject);
    }
    public void SetVelocity(Vector2 velocity) => GetComponent<Rigidbody2D>().linearVelocity = velocity;
}
