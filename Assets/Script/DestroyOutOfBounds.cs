using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyOutOfBounds : MonoBehaviour
{
    private float boundary = 30f;
    private float lowerBoundary = -10f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //if obeject gets past the top view of player it is destroyed
        if(transform.position.z > boundary)
        {
            Destroy(gameObject);
        }
        //if object (animals) gets past view it is destroyed
        else if(transform.position.z < lowerBoundary)
        {
            //shout "Game Over" if it pasts
            Debug.Log("Game Over!");
            Destroy(gameObject);
        } 
    }
}
