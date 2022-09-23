using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementActivator8 : MonoBehaviour
{
    [SerializeField] GameObject objectToActivate;
    [SerializeField] GameObject otherObjectToActivate;

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
        objectToActivate.GetComponent<MoveObject8>().enabled = true;
        otherObjectToActivate.GetComponent<MoveObject8>().enabled = true;
    }
    private void OnTriggerExit(Collider other)  //changed from pnTriggerExit to onTriggerExit so that the trigger can trigger this method
    {
        objectToActivate.GetComponent<MoveObject8>().enabled = true;
        otherObjectToActivate.GetComponent<MoveObject8>().enabled = true;
    }
}
