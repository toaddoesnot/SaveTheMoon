using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InstrumentPickUp : MonoBehaviour
{
    public Transform teleportTarget;
    public GameObject theInstrument;

    void OnTriggerEnter(Collider collider)
    {
        if (collider.gameObject.tag == "Player")
        {
            theInstrument.transform.position = teleportTarget.transform.position;
        }
    }
}
