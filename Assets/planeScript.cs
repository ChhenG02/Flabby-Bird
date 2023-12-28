using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class planeScript : MonoBehaviour
{
    public Rigidbody2D myRigidBody; // create line communication with the compoent
    public float flapStrength;
    public LogicScript logic;
    public bool planeAlive = true;

    // Start is called before the first frame update
    void Start()
    {
        logic = GameObject.FindGameObjectWithTag("Logic").GetComponent<LogicScript>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0) == true && planeAlive == true)
        {
            myRigidBody.velocity = Vector2.up * flapStrength;

        }

        // out of screen
        if (transform.position.y > 13.4f || transform.position.y < -14.4f)
        {
            // Call a function to handle game over
            logic.gameOver();
            planeAlive = false;
        }
    }
    // plane crush pipe
    private void OnCollisionEnter2D(Collision2D collision)
    {
        logic.gameOver();
        planeAlive = false;
    }
}
