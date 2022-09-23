using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveObject9 : MonoBehaviour
{
    [SerializeField] float moveSpeed; //have to serialize this field to have a moveSpeed for the doors or they will remain stationary
    [SerializeField] Vector3 moveDirection;

    float totalMoveDistance; //need to type declare this, cannot just have a variable name without a type association. 
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
           this.enabled = false;
        }

        gameObject.transform.Translate(moveDirection * moveSpeed);
    }

    void FlipMoveDirection()
    {
        moveDirection = -moveDirection;
        startingLocation = gameObject.transform.position; //needed to add this so that when the doors close, they converge upon original position. 
    }

    float GetDistanceTraveled()
    {
        return Vector3.Distance(gameObject.transform.position, startingLocation);
    }
}
