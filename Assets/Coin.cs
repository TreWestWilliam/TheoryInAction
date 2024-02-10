using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : Entity
{
    // Start is called before the first frame update
    new void Start()
    {
        SetMoveSpeed(66.1f);
        
    }

    // Update is called once per frame
    void Update()
    {

        transform.rotation = Quaternion.Euler(transform.rotation.eulerAngles.x, transform.rotation.eulerAngles.y, transform.rotation.eulerAngles.z +  (GetMoveSpeed() *Time.deltaTime )) ;
        
    }

    public void OnTriggerEnter(Collider collision)
    {
        if (collision.transform.tag == "Player") 
        {
            collision.gameObject.GetComponent<PlayerMove>().AddScore();

            Die();
        }
    }

    public override void Die() // we polymophed die by changing :D 
    {
        base.Die(); // we inherited die :D 
        GameObject.Destroy(gameObject);
    }

}
