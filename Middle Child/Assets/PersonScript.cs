using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PersonScript : MonoBehaviour
{
    public int personSpeed = 3;
    public Rigidbody2D myRigidBody;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {


        if (Input.GetKeyDown(KeyCode.Space)){
        myRigidBody.velocity = Vector2.up * personSpeed;
      }

    }


}
