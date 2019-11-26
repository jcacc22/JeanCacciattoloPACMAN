using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movePac : MonoBehaviour
{
    public float speed = 0.4f;
    Vector2 dnate = Vector2.zero;


    void Start()
    {
        dnate = transform.position;
    }


    void FixedUpdate()
    {
        Vector2 b = Vector2.MoveTowards(transform.position, dnate, speed);
        GetComponent<Rigidbody2D>().MovePosition(b);
    }


    bool valid(Vector2 dir)
    {
        Vector2 pos = transform.position;
        RaycastHit2D hit = Physics2D.Linecast(pos + dir, pos);
        return (hit.collider == GetComponent<Collider2D>());
    }
}
