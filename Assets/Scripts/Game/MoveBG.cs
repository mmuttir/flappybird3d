using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveBG : MonoBehaviour
{
    void FixedUpdate()
    {
        if(!SpawnHurdles.gameOver)
        {
            transform.position += Vector3.left * 0.05f;
        }
        if(transform.position.x <=-40)
        {
            transform.position += Vector3.right * 79;
        }
    }
}
