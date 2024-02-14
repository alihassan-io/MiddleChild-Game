using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpikeMoveScript : MonoBehaviour
{
    public float moveSpeed = 5;
    public float deadZone = -45;
    public LogicScript logic;

    public GameObject person;
    // Start is called before the first frame update
    void Start()
    {
        logic = GameObject.FindGameObjectWithTag("Logic").GetComponent<LogicScript>();
        person = GameObject.FindGameObjectWithTag("Person");

    }

    // Update is called once per frame
    void Update()
    {
        transform.position = transform.position + (Vector3.left * moveSpeed) * Time.deltaTime;

        if (transform.position.x < deadZone){
            Destroy(gameObject);
        }
    }

    private void OnTriggerEnter2D(Collider2D collision){
        if (collision.gameObject.layer == 3){
            Destroy(person);
            logic.gameOver();
        }
    }
}
