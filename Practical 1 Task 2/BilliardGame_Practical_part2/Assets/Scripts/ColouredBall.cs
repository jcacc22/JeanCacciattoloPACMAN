using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColouredBall : MonoBehaviour
{


    void DestroyBallWhenItHitsHole(Collision collision)
    {
        Destroy(collision.collider.gameObject);
        Destroy(gameObject);
    }
    
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }


    
    
}


