using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementActivator9 : MonoBehaviour
{
    [SerializeField] GameObject objectToActivate;
    [SerializeField] GameObject otherObjectToActivate; //need to serialize this so that this trigger activates BOTH doors. 

    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        objectToActivate.GetComponent<MoveObject9>().enabled = true;
        otherObjectToActivate.GetComponent<MoveObject9>().enabled = true;
    }
    private void OnTriggerExit(Collider other) //change from pnTriggerExit to OnTriggerExit so trigger knows what function to look at
    {
        objectToActivate.GetComponent<MoveObject9>().enabled = true;
        otherObjectToActivate.GetComponent<MoveObject9>().enabled = true;
    }
}
