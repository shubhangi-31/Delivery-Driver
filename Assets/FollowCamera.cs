using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowCamera : MonoBehaviour
{
    [SerializeField] GameObject thingToFollow;
    //this thing  position (camera) should be the as the car's position
    
    void Update()
    {
        transform.position = thingToFollow.transform.position + new Vector3(0,0,-10);
    }
}
