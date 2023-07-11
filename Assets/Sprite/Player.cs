using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public Rigidbody2D player;
    public CapsuleCollider2D capsule;
    public Transform transformPlayer;
    public float maxAcceleration;
    public float jump;
    public float distance;
    public LayerMask layerMask;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 jumpForce = new Vector2(0, Input.GetAxis("Vertical") * jump);
        Vector2 force = new Vector2(maxAcceleration * Input.GetAxis("Horizontal"), 0);
        player.AddForce(force);
        if (Physics2D.CapsuleCast(transformPlayer.position, capsule.bounds.size, 0, 0, Vector2.down, distance, layerMask))
        {
            player.AddForce(jumpForce);
        }
        
    }
}
