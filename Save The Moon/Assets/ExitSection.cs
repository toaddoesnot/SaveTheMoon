using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExitSection : MonoBehaviour
{
    public Transform teleportTarget;
    public Inventory Inventory;


    public GameObject thePlayer;
    public GameObject Entrance;
    public GameObject Save;
    


    private void OnTriggerEnter(Collider other)
    {
        if (Inventory.IHaveInstrument == true)
        {
            thePlayer.transform.position = teleportTarget.transform.position;
            Destroy(Entrance);
            Save.SetActive(true);
        }
        else
        {
            Debug.Log("I can not teleport without the instrument");
        }

    }
}
