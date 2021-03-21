using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InstrumentPickUp : MonoBehaviour
{
    public bool MoveMoon;
    public AudioClip clip;
    public Transform Player;


    public GameObject theInstrument;
    public GameObject PortalExit;
    public bool NoCoroutine;
    public ZodiacPlatform TriggerCheck1;
    public ZodiacPlatform TriggerCheck2;
    public ZodiacPlatform TriggerCheck3;
    public ZodiacPlatform TriggerCheck4;

    public Transform Stack;
    public Inventory Inventory;

    private void Start()
    {
        NoCoroutine = false;
        MoveMoon = false;
        PortalExit.SetActive(false);

    }

    private void Update()
    {
       if (TriggerCheck1.IPlacedInst == true)
        {
            NoCoroutine = true;
        }
       else
        {
            if (TriggerCheck2.IPlacedInst == true)
            {
                NoCoroutine = true;
            }
            
            else
            {
                if (TriggerCheck3.IPlacedInst == true)
                {
                    NoCoroutine = true;
                }
                else
                {

                    if (TriggerCheck4.IPlacedInst == true)
                    {
                        NoCoroutine = true;
                    }
                    else
                    {
                        NoCoroutine = false;
                    }
                }                                  
            }
        }


    }

    void OnTriggerEnter(Collider collider)
    {
        MoveMoon = true;
        AudioSource.PlayClipAtPoint(clip, Player.transform.position);

        if (collider.gameObject.tag == "Player")
        {
            if (Inventory.IHaveInstrument == false)
            {
                //Debug.Log("I have an instrument");

                theInstrument.transform.position = Stack.transform.position;
                Inventory.IHaveInstrument = true;
                PortalExit.SetActive(true);

                if (theInstrument.tag == "InstTiger")
                {
                    Inventory.IHaveTig = true;
                }
                else
                {
                    
                }

                if (theInstrument.tag == "InstBunny")
                {
                    Inventory.IHaveBunny = true;
                }
                else
                {
                    
                }

                if (theInstrument.tag == "InstDrag")
                {
                    Inventory.IHaveDragon = true;
                }
                else
                {
                    
                }

                if (theInstrument.tag == "InstOx")
                {
                    Inventory.IHaveOx = true;
                }
                else
                {
                    
                }
            }

            else
            {
                if (NoCoroutine == true)
                {

                }
                else
                {
                    StartCoroutine(Inventory.GetComponent<Inventory>().Alarm());
                }
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
