using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformSize : MonoBehaviour
{
    public SpriteRenderer platform;

    public void FixedUpdate()
    {
        
    }
    public Vector2 EndPoint()
    {
        float sizeX = platform.bounds.size.x + this.transform.position.x;
        float sizeY = this.transform.position.y;
        Vector2 size= new Vector2(sizeX, sizeY);
        return size;
    }
}
