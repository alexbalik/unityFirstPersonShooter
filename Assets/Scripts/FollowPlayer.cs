using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    public GameObject player;//is this a data member? The purpose of this is to store the player reference object in unity
    //as opposed to storing a variable
    private Vector3 offset = new Vector3(0, 2.5f, 0);
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void LateUpdate()
    {
        transform.position = player.transform.position + offset;  
    }
}
