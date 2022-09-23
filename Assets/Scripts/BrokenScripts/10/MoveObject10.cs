using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveObject10 : MonoBehaviour
{
    [SerializeField] float moveSpeed; //need to serialize in order to move the doors at a certain speed
    [SerializeField] Vector3 moveDirection;

    float totalMoveDistance; //need to declare types when declaring variables, else it will throw an error
    Vector3 startingLocation;

    //// Start is called before the first frame update
    void Start()
    {
        totalMoveDistance = 10f;
        startingLocation = gameObject.transform.position;
    }

    //// Update is called once per frame
    void Update()
    {
        float distanceTraveled = GetDistanceTraveled();

       if (distanceTraveled > totalMoveDistance)
        {
            FlipMoveDirection();
            this.enabled = false;  //need to add this in order to flip the move direction of the doors when they reach the maximum horizontal distance, else they will keep moving outwards. 
        }

        gameObject.transform.Translate(moveDirection * moveSpeed);
    }

    void FlipMoveDirection()
    {
        moveDirection = -moveDirection;
        startingLocation = gameObject.transform.position; //Need this in order for the doors to converge back upon the starting location when closing 

    }

    float GetDistanceTraveled()
    {
        return Vector3.Distance(gameObject.transform.position, startingLocation);
    }
}
