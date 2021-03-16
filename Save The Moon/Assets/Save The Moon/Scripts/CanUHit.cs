using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CanUHit : MonoBehaviour
{
    public bool AmISafe;
    public GameObject thePlayer;

    public void OnTriggerEnter(Collider other)
    {
        AmISafe = false;
    }

    public void OnTriggerExit(Collider other)
    {
        AmISafe = true;
    }

}
