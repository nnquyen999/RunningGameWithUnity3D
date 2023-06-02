using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class waytpointerFollowers : MonoBehaviour
{
    [SerializeField] GameObject[] wayPoints;
    int currenWaypointIndex = 0;
    [SerializeField] float speed = 1f;


    // Update is called once per frame
    void Update()
    {
        if (Vector3.Distance(transform.position, wayPoints[currenWaypointIndex].transform.position) < .1f)
        {
            currenWaypointIndex++;
            if(currenWaypointIndex >= wayPoints.Length)
            {
                currenWaypointIndex = 0;
            }
        }
        transform.position = Vector3.MoveTowards(transform.position, wayPoints[currenWaypointIndex].transform.position, speed * Time.deltaTime);
    }
}
