using UnityEngine;
using System.Collections;

public class DotSpawner1 : MonoBehaviour
{

    void OnTriggerEnter2D(Collider2D co)
    {
        if (co.name == "pacMan")
            Destroy(gameObject);
    }
}