using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Patrol : MonoBehaviour
{
    public Transform[] points;
    int current;
    public float speed;

    public GameObject Guard;

    private void Start()
    {
        current = 0;
    }

    private void Update()
    {
        if (transform.position != points[current].position)
        {
            transform.position = Vector3.MoveTowards(transform.position, points[current].position, speed * Time.deltaTime);
        }
        else
        {
            current = (current + 1) % points.Length;
            Guard.transform.Rotate(0.0f, 180.0f, 0.0f);
        }

    }
}
