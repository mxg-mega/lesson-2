using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectCollision : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    //On collision this method destroyes both objects
    private void OnTriggerEnter(Collider other)
    {
        //the object
        Destroy(gameObject);
        //The Other Object Collided with
        Destroy(other.gameObject);
    }
}
