using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private float speed = 5.0f; //declare and set speed variable. Set speed immediately because, for now, speed won't change
    private float forwardInput;//decalre front back variable(?)
    private float horizontalInput;//declate side to side input variable(?)

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        forwardInput = Input.GetAxis("Vertical");
        horizontalInput = Input.GetAxis("Horizontal");

        //move player forwar and back
        transform.Translate(Vector3.forward * Time.deltaTime * speed * forwardInput);
        //move player side to side
        transform.Translate(Vector3.right * Time.deltaTime * speed * horizontalInput);
    }
}
