using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyPathing : MonoBehaviour
{
    //Reference/Configuration Params for waypoints
    [SerializeField] List<Transform> waypoints;
    [SerializeField] float moveSpeed = 2f;

    //basically denotes which waypoint we're working towards on the path
    int waypointIndex = 0;

    // Start is called before the first frame update
    void Start()
    {
        transform.position = waypoints[waypointIndex].position;
    }

    // Update is called once per frame
    void Update()
    {
        Move();
    }

    private void Move()
    {
        if (waypointIndex <= waypoints.Count - 1)
        {
            var targetPostion = waypoints[waypointIndex].position;
            var movementThisFrame = moveSpeed * Time.deltaTime;
            transform.position = Vector2.MoveTowards(
                transform.position,
                targetPostion,
                movementThisFrame);

            //the check needs to happen every frame, but only increments once it reaches target
            if (transform.position == targetPostion)
            {
                waypointIndex++;
            }
        }
        else
        {
            Destroy(gameObject);
        }
    }
}
