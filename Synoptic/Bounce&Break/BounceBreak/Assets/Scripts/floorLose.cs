using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class floorLose : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D myCollider)
    {


        SceneManager.LoadScene("done");

    }
}
