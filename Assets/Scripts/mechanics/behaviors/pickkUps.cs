using UnityEngine;

public class pickUps : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        Debug.Log("collision found");
        if (other.gameObject.CompareTag("Player"))
        {
            other.GetComponent<playerController>().inv1 = gameObject.tag;
            Destroy(gameObject);
            Debug.Log("it collided, inv1 set to" + other.GetComponent<playerController>().inv1);;
        }

    }
}
