using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnHurdles : MonoBehaviour
{
    private GameObject[] createdInstances = new GameObject[10];
    private bool[] hasIncreasedScore = new bool[10];
    private float speed = 0.5f;
    public GameObject prefabObject;
    public static bool gameOver = false;
    // Start is called before the first frame update
    void Start()
    {
        System.Random random = new System.Random();
        for(int i = 0; i<10; i++)
        {
            createdInstances[i] = Instantiate(prefabObject);
            createdInstances[i].transform.position = new Vector3(i*7f + 20, random.Next(-820,-445) * 0.01f, 0);
        }
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        System.Random random = new System.Random();
        for (int i=0; i<10; i++)
        {
            if(createdInstances[i].transform.position.x <=-3.5 && !hasIncreasedScore[i])
            {
                ScoreManager.gameScore++;
                hasIncreasedScore[i] = true;
            }
            if(!gameOver)
                createdInstances[i].transform.position += Vector3.left * speed * 0.1f;
            if(createdInstances[i].transform.position.x <= -20)
            {
                createdInstances[i].transform.position = new Vector3(56, random.Next(-820, -445) * 0.01f, 0);
                hasIncreasedScore[i] = false;
            }
        }

    }
}
