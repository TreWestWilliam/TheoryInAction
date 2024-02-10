using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : Entity
{
    //public float m_movespeed =2f;
      
    
    protected float m_height = 1.1f;

    private bool IsGoingLeft = true;

    public bool GetGoingLeft() { return IsGoingLeft; }

    public void OnCollisionEnter(Collision collision)
    {
        // CHECK IF WE COLLIDED WITH PLAYER
        if (collision.gameObject.tag == "Player")
        {
            if (collision.transform.position.y > transform.position.y + m_height)
            {
                Die();
            }
            else
            {
                collision.gameObject.GetComponent<PlayerMove>().Die();
            }
        }
        else 
        {
            IsGoingLeft = !IsGoingLeft;
        }
    }

    public virtual void MovementLogic() 
    {
        if (IsGoingLeft) 
        {
            rb.AddForce(-GetMoveSpeed(),0,0);
        }
        else
        {
            rb.AddForce(GetMoveSpeed(), 0, 0);
        }
    }

    public override void Die()
    {
        base.Die();
        GameObject.Destroy(gameObject);
    }

    // Start is called before the first frame update
    new void Start()
    {
        base.Start();
        SetMoveSpeed(.8f);
    }

    // Update is called once per frame
    void Update()
    {
        MovementLogic();
    }
}
