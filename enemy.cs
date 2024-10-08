using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;

public class enemy : MonoBehaviour
{
    DateTime startTime;
    public float speed = 3;
    public float len = 10;
    public GameObject player;
    // Start is called before the first frame update
    void Start()
    {
        startTime = DateTime.Now.AddMilliseconds(Random.Range(1000, 3000));
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 delta = transform.position - player.transform.position;
        if (delta.magnitude < len)
        {
            transform.position = Vector3.MoveTowards(transform.position, player.transform.position, speed * Time.deltaTime);
        }
        else
        {
            transform.Translate(Vector3.forward * speed * Time.deltaTime);
            if (startTime.CompareTo(DateTime.Now) < 0)
            {
                transform.Rotate(Vector3.up, Random.Range(1000, 3000) * Time.deltaTime);
                startTime = DateTime.Now.AddMilliseconds(Random.Range(1000, 3000));
            }
            Vector3 v = transform.position;
            v.y = 0.5f;
            transform.position = v;
        }

    }
}
