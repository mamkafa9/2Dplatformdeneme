using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera : MonoBehaviour
{
    public Transform camTransform;
    public Transform playerTransform;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    { 
        camTransform.position = new Vector3(playerTransform.position.x, playerTransform.position.y, -10);
    }
}
