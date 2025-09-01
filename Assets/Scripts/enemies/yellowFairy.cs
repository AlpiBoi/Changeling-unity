using UnityEngine;

public class yellowFairy : enemy
{
    [SerializeField] private float fireRate = 2.0f;
    private float timeSinceLastShot = 0.0f;
    private float playerXPos;
    protected override void Start()
    {
        base.Start();
        playerXPos = GameObject.Find("PLAYER").GetComponent<playerController>().PlayerTrans.position.x;
        

        if (fireRate <= 0)
        {
            Debug.LogError("Fire rate must be higher then 0. Setting to 2");
            fireRate = 2.0f;
        }
    }

    private void Update()
    {
        AnimatorStateInfo stateInfo = anim.GetCurrentAnimatorStateInfo(0);
        playerXPos = GameObject.Find("PLAYER").GetComponent<playerController>().PlayerTrans.position.x;

        if (stateInfo.IsName("yellowFairyWalk")){
            if (Time.time - timeSinceLastShot >= fireRate)
            {
                anim.SetTrigger("fire");
                timeSinceLastShot = Time.time;
            }
        }

        if (playerXPos < gameObject.transform.position.x)
        {
            sr.flipX = true;
        }
        else if (playerXPos > gameObject.transform.position.x)
        {
            sr.flipX = false;
        }
    }

    public void Dies()
    {
        Destroy(transform.parent.gameObject);
    }
}
