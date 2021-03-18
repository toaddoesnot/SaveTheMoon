using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Teleporter : MonoBehaviour
{
    public Transform teleportTarget;
    public GameObject thePlayer;
    public Inventory Inventory;


    private void OnTriggerEnter(Collider other)
    {
        if (Inventory.IHaveInstrument == false)
        {
            thePlayer.transform.position = teleportTarget.transform.position;
        }
        else
        {
            StartCoroutine(Inventory.GetComponent<Inventory>().Alarm());
        }
        
    }
}
