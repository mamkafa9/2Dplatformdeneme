using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public GameObject platforms;
    public int howMuchPlatformSpaw;
    public Vector2 lastEndPoint;
    public Transform firstPlatform;

    public void SpawPlatforms()
    {
        for (int i = 0; i < howMuchPlatformSpaw; i++)
        {
            PlatformSize platformScript = platforms.GetComponent<PlatformSize>();
            GameObject.Instantiate(platforms,firstPlatform);
            platforms.transform.position = lastEndPoint;
            lastEndPoint = platformScript.EndPoint();
        }  
    }
    void Start()
    {
        SpawPlatforms();
    }

    // Update is called once per frame
    void Update()
    {
       
    }
}
