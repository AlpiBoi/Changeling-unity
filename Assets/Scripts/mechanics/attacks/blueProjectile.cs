using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]

public class blueProjectile : MonoBehaviour
{
    [SerializeField] private ProjectileType projectileType = ProjectileType.playerBlue;
    [SerializeField, Range(1, 20)] private float lifetime = 2.0f;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Destroy(gameObject, lifetime);

    }

    private void OnCollisionEnter2D(Collision2D col)
    {
        if (projectileType == ProjectileType.playerBlue && col.gameObject.CompareTag("enemy"))
        {
            enemy enemy = col.gameObject.GetComponent<enemy>();
            if (enemy != null)
            {
                enemy.TakeDmg(100);
            }
        }
        Destroy(gameObject);
    }
    public void SetVelocity(Vector2 velocity) => GetComponent<Rigidbody2D>().linearVelocity = velocity;


}

public enum ProjectileType
{
    playerBasic,
    playerGreen,
    playerRed,
    playerWite,
    playerBlue,
    playerYellow,
    playerPink,
    enemyGreen,
    enemeyRed,
    enemyWite,
    enemyBlue,
    enemyYellow,
    enemyPink
}