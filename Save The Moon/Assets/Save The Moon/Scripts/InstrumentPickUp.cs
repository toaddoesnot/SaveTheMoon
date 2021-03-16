using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InstrumentPickUp : MonoBehaviour
{
    public GameObject theInstrument;
    public GameObject PortalExit;

    public Transform Stack;

    public Inventory Inventory;

    private void Start()
    {
        
    }

    void OnTriggerEnter(Collider collider)
    {
        if (collider.gameObject.tag == "Player")
        {
            if (Inventory.IHaveInstrument == false)
            {
                Debug.Log("I have an instrument");
                theInstrument.transform.position = Stack.transform.position;
                Inventory.IHaveInstrument = true;
                PortalExit.SetActive(true);

                if (theInstrument.tag == "InstTiger")
                {
                    Inventory.IHaveTig = true;
                }

                if (theInstrument.tag == "InstBunny")
                {
                    Inventory.IHaveBunny = true;
                }

                if (theInstrument.tag == "InstDrag")
                {
                    Inventory.IHaveDragon = true;
                }

                if (theInstrument.tag == "InstOx")
                {
                    Inventory.IHaveOx = true;
                }
            }

            else
            {
                Debug.Log("I can carry only one instrument");
            }
        }
    }

    //public Transform teleportTarget;
    //public GameObject theInstrument;

    //void OnTriggerEnter(Collider collider)
    //{
    //  if (collider.gameObject.tag == "Player")
    //  {
    //    theInstrument.transform.position = teleportTarget.transform.position;
    //  }
    //}
}
