using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMover : MonoBehaviour
{
    [SerializeField] List<Waypoint> path = new List<Waypoint>();
    [SerializeField] float waitTime = 1f;

    // Start is called before the first frame update
    void Start()
    {
        
        StartCoroutine(FollowPath());//Makes enemy wait for a certain length of time before each iteration of foreach loop
       
    }

    IEnumerator FollowPath()
    {
        foreach(Waypoint waypoint in path)
        {
            transform.position = waypoint.transform.position;
            yield return new WaitForSeconds(waitTime);
        }
    }
}
