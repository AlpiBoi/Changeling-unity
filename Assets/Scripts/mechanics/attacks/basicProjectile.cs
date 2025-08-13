using UnityEngine;


[RequireComponent(typeof(Rigidbody2D))]
public class basicProjectile : MonoBehaviour
{
    [SerializeField, Range(1, 20)] private float lifetime = 1.0f;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
