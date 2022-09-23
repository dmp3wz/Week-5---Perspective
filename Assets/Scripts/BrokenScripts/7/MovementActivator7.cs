using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementActivator7 : MonoBehaviour
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
        objectToActivate.GetComponent<MoveObject7>().enabled = true;
        otherObjectToActivate.GetComponent<MoveObject7>().enabled = true;
    }
    private void OnTriggerExit(Collider other) //changed from "pnTriggerExit" to "onTriggerExit", won't read this as a trigger function for a gameObject otherwise -dmp3wz
    {
        objectToActivate.GetComponent<MoveObject7>().enabled = true;
        otherObjectToActivate.GetComponent<MoveObject7>().enabled = true;
    }
}
