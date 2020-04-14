using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Paddle : MonoBehaviour
{

    [SerializeField] float screenWidthInUnits = 16f;

    Vector2 paddlePosition;

    void Start()
    {
        paddlePosition = new Vector2(transform.position.x, transform.position.y);
    }

    void Update()
    {
        float mousePos = Input.mousePosition.x / Screen.width * screenWidthInUnits;

        paddlePosition.x = Mathf.Clamp(mousePos, 1f, 15f);

        this.transform.position = paddlePosition;

    }
}
