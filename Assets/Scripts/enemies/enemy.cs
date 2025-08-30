using UnityEditor.Rendering;
using UnityEngine;

[RequireComponent(typeof(SpriteRenderer),typeof(Animator))]

public abstract class enemy : MonoBehaviour
{

    protected SpriteRenderer sr;
    protected Animator anim;
    protected int HP;
   

    [SerializeField] private int maxHP = 100;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    protected virtual void Start()
    {
        sr = GetComponent<SpriteRenderer>();
        anim = GetComponent<Animator>();
        
        if (maxHP <=0)
        {
            Debug.LogError("MaxHP set to 100");
            maxHP = 100;
        }
        HP = maxHP;
    }

    public virtual void TakeDmg(int Dmg)
    {
        HP -= Dmg;
        if (HP <= 0)
        {
            anim.SetTrigger("Death");
            return;
        }
    }

}

