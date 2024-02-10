using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Entity : MonoBehaviour
{
    public Rigidbody rb;

    private float moveSpeed = 2;

    protected float GetMoveSpeed()
    {
        return moveSpeed;
    }

    protected void SetMoveSpeed(float value)
    {
        moveSpeed = value;
    }

    protected bool IsGrounded()
    {
        return Physics.Raycast(transform.position, -Vector3.up, 1.1f);
    }

    public virtual void Die() 
    {
        Debug.Log($"{gameObject.name} has died!");
    }

    // Start is called before the first frame update
    public void Start()
    {
        if (rb == null) { rb = gameObject.GetComponent<Rigidbody>(); }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
