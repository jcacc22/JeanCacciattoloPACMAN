using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cyl : MonoBehaviour
{
    public int hit = 0;

    private void OnCollisionEnter2D(Collision2D coll)
    {
        hit += 1;
        checkhit();
    }

    void checkhit()
    {
        if (hit == 3)
        {
            Destroy(gameObject);
        }
    }
}