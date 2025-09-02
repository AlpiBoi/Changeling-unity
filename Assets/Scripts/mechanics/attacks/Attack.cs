using UnityEngine;

public class Attack : MonoBehaviour
{
    private SpriteRenderer sr;
    [SerializeField] private Vector2 initShotVelocity = Vector2.zero;
    [SerializeField] private Transform leftSpawn;
    [SerializeField] private Transform rightSpawn;
    [SerializeField] private GameObject projectilePrefab = null;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        sr = GetComponent<SpriteRenderer>();

        if (initShotVelocity == Vector2.zero)
        {
            initShotVelocity = new Vector2(10f, 0f);
            Debug.LogWarning("init shot velocity not set");
        }

        if(leftSpawn == null || rightSpawn == null || projectilePrefab == null)
        {
            Debug.LogError("Spawn point or projectile prefab not set");
        }
    }
    public void BasAttack()
    {
        basicProjectile curProject;
        if (!sr.flipX)
        {
            curProject = Instantiate(projectilePrefab, rightSpawn.position, Quaternion.identity).GetComponent<basicProjectile>();
            curProject.SetVelocity(initShotVelocity);
        }
        else
        {
            curProject = Instantiate(projectilePrefab, leftSpawn.position, Quaternion.Euler(0, 180, 0)).GetComponent<basicProjectile>();
            curProject.SetVelocity(-initShotVelocity);
        }
    }
     public void GreAttack()
    {
        greenProjectile curProject;
        if (!sr.flipX)
        {
            curProject = Instantiate(projectilePrefab, rightSpawn.position, Quaternion.identity ).GetComponent<greenProjectile>();
            curProject.SetVelocity(initShotVelocity);
        }
        else
        {
            curProject = Instantiate(projectilePrefab, leftSpawn.position, Quaternion.Euler(0, 180, 0)).GetComponent<greenProjectile>();
            curProject.SetVelocity(-initShotVelocity);
        }
    }
    public void RedAttack()
    {
        redProjectile curProject;
        if (!sr.flipX)
        {
            curProject = Instantiate(projectilePrefab, rightSpawn.position, Quaternion.identity).GetComponent<redProjectile>();
            curProject.SetVelocity(initShotVelocity);
        }
        else
        {
            curProject = Instantiate(projectilePrefab, leftSpawn.position, Quaternion.Euler(0, 180, 0)).GetComponent<redProjectile>();
            curProject.SetVelocity(-initShotVelocity);
        }
    }

    public void WhiAttack()
    {
        whiteProjectile curProject;
        if (!sr.flipX)
        {
            curProject = Instantiate(projectilePrefab, rightSpawn.position, Quaternion.identity).GetComponent<whiteProjectile>();
            curProject.SetVelocity(initShotVelocity);
        }
        else
        {
            curProject = Instantiate(projectilePrefab, leftSpawn.position, Quaternion.Euler(0, 180, 0)).GetComponent<whiteProjectile>();
            curProject.SetVelocity(-initShotVelocity);
        }
    }

    public void BluAttack()
    {
        blueProjectile curProjectile;
        if (!sr.flipX)
        {
            curProjectile = Instantiate(projectilePrefab, rightSpawn.position, Quaternion.identity).GetComponent<blueProjectile>();
            curProjectile.SetVelocity(initShotVelocity);
        
        }
        else
        {
            curProjectile = Instantiate(projectilePrefab, leftSpawn.position, Quaternion.Euler(0,180,0)).GetComponent<blueProjectile>();
            curProjectile.SetVelocity(-initShotVelocity);
          
        }
    }
    public void YelAttack()
    {
        yellowProjectile curProjectile;
        if (!sr.flipX)
        {
            curProjectile = Instantiate(projectilePrefab, rightSpawn.position, Quaternion.identity).GetComponent<yellowProjectile>();
            curProjectile.SetVelocity(initShotVelocity);
        }
        else
        {
            curProjectile = Instantiate(projectilePrefab, leftSpawn.position, Quaternion.Euler(0,180,0)).GetComponent<yellowProjectile>();
            curProjectile.SetVelocity(-initShotVelocity);
        }
    }

    public void PinAttack()
    {
        pinkProjectile curProject;
        if (!sr.flipX)
        {
            curProject = Instantiate(projectilePrefab, rightSpawn.position, Quaternion.identity).GetComponent<pinkProjectile>();
            curProject.SetVelocity(initShotVelocity);
        }
        else
        {
            curProject = Instantiate(projectilePrefab, leftSpawn.position, Quaternion.Euler(0, 180, 0)).GetComponent<pinkProjectile>();
            curProject.SetVelocity(-initShotVelocity);
        }
    }

   
    
}
