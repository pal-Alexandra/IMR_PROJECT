using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovePath : MonoBehaviour
{
    public List<GameObject> points;
    public float speed = 2;
    private float rotationSpeed = 5;
    int index = 0;
    public bool isLoop = true;
    public bool isReverted = false;

    private void Start()
    {
        if (isReverted)
        {
            points.Reverse();
        }
    }

    private void Update()
    {
        MoveObject();
        RotateObject();
    }

    void MoveObject()
    {
        Vector3 destination = points[index].transform.position;
        Vector3 newPos = Vector3.MoveTowards(transform.position, points[index].transform.position, speed * Time.deltaTime);
        transform.position = newPos;

        float distance = Vector3.Distance(transform.position, destination);
        if (distance <= 0.05)
        {
            if (index < points.Count - 1)
            {
                index++;
            }
            else
            {
                if (isLoop)
                {
                    index = 0;
                    transform.position = points[index].transform.position;
                }
            }
        }
    }

    void RotateObject()
    {
        if (index < points.Count - 1)
        {
            Vector3 direction = points[index].transform.position - transform.position;
            direction.y = 0;
            Quaternion rotation = Quaternion.LookRotation(direction);
            transform.rotation = Quaternion.Slerp(transform.rotation, rotation, rotationSpeed * Time.deltaTime);
        }
    }
}

