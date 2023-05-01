// using System.Collections;
// using System.Collections.Generic;
using UnityEngine;

public class Player_Movement : MonoBehaviour
{
    public Rigidbody rb;
    public float forwardForce = 8000;
    public float sideForce = 50;

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Game Start..");
        rb.useGravity = true;
        rb.drag = 1;
        // rb.AddForce(0,0,forwardForce*Time.deltaTime);
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        // adding force to the player object and even out the force
        // rb.AddForce(0,0,forwardForce*Time.deltaTime);
        if (Input.GetKey("w"))
        {
            // Debug.Log("Forward");
            rb.AddForce(0, 0, forwardForce * Time.deltaTime);
        }

        if (Input.GetKey("d"))
        {
            // Debug.Log("Right");
            rb.AddForce(sideForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }
        if (Input.GetKey("a"))
        {
            // Debug.Log("Left");
            rb.AddForce(-sideForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }

        if (rb.position.y < -1)
        {
            FindObjectOfType<GameManager>().EndGame();
        }
    }
}
