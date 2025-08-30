using UnityEngine;

public class yellowFairy : enemy
{
    [SerializeField] private float fireRate = 2.0f;
    private float timeSinceLastShot = 0.0f;
    private playerController pC;
    protected override void Start()
    {
        pC = GetComponent<playerController>();
        base.Start();

        if (fireRate <= 0)
        {
            Debug.LogError("Fire rate must be higher then 0. Setting to 2");
            fireRate = 2.0f;
        }
    }

    private void Update()
    {
        AnimatorStateInfo stateInfo = anim.GetCurrentAnimatorStateInfo(0);

        if (stateInfo.IsName("yellowFairyWalk")){
            if (Time.time - timeSinceLastShot >= fireRate)
            {
                anim.SetTrigger("fire");
                timeSinceLastShot = Time.time;
            }
        }

        if (pC.playerPosX < gameObject.transform.position.x)
        {
            sr.flipX = true;
        }
        else if (pC.playerPosX > gameObject.transform.position.x)
        {
            sr.flipX = false;
        }
    }

    public void Dies()
    {
        Destroy(transform.parent.gameObject);
    }
}
