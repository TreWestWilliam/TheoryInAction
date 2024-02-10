using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerMove : Entity
{

    public int score =0;
    public Text textmesh;

    public void AddScore() 
    {
        score++;
        textmesh.text = $"SCORE:{score}";
    }
    

    // Start is called before the first frame update
    new void Start()
    {
        base.Start();
        SetMoveSpeed(1.2f);
    }

    // Update is called once per frame
    void Update()
    {

        rb.AddForce(new Vector3(Input.GetAxis("Horizontal")*GetMoveSpeed(),0,0));

        if (Input.GetKeyDown("space") && IsGrounded()) 
        {
            rb.AddForce(0, 250, 0);
        }
        
    }



}
