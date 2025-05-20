using System.Collections;
using System.Collections.Generic;
using UnityEditor.Tilemaps;
using UnityEngine;
using UnityEngine.Animations;
using UnityEngine.UIElements;

public class Path : MonoBehaviour
{

    [SerializeField] Transform[] wayPoints;

    [SerializeField] private float truckSpeed;

    private int wayPointsIndex;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        transform.position = wayPoints[wayPointsIndex].transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        if(wayPointsIndex <= wayPoints.Length -1)
        {
            transform.position = Vector2.MoveTowards(transform.position, wayPoints[wayPointsIndex].transform.position, truckSpeed * Time.deltaTime);

            if(transform.position == wayPoints[wayPointsIndex].transform.position )
            {
                wayPointsIndex += 1;
            }
        }
    }
}
