using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RobotScript : MonoBehaviour
{
    public Rigidbody2D myRigidBody;
    public int robotSpeed = 3;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.RightArrow)){
        myRigidBody.velocity = Vector2.right * robotSpeed;
      }

        if (Input.GetKeyDown(KeyCode.UpArrow)){
        myRigidBody.velocity = Vector2.up * robotSpeed;
      }

        if (Input.GetKeyDown(KeyCode.LeftArrow)){
            myRigidBody.velocity = Vector2.left * robotSpeed;
        }

        if (Input.GetKeyDown(KeyCode.DownArrow)){
            myRigidBody.velocity = Vector2.down * robotSpeed;
        }
    }
}
