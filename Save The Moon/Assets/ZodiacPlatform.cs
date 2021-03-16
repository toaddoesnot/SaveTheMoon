using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZodiacPlatform : MonoBehaviour
{
    // this is the script just for placing things
    
    public GameObject Bongo;
    public GameObject Kalimba;
    public GameObject Doo;
    public GameObject Guitar;

    public GameObject Col1;
    public GameObject Col2;
    public GameObject Col3;



    public Transform Center;
    public Inventory Inventory;

    public bool IPlacedInst;

    private void Start()
    {
        IPlacedInst = false;
        Col1.GetComponent<CapsuleCollider>().enabled = true;
        Col2.GetComponent<CapsuleCollider>().enabled = true;
        Col3.GetComponent<CapsuleCollider>().enabled = true;

    }

    private void Update()
    {
       

    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            if (IPlacedInst == false)
            {
                if (Inventory.IHaveInstrument == true)
                {
                    Col1.GetComponent<CapsuleCollider>().enabled = false;
                    Col2.GetComponent<CapsuleCollider>().enabled = false;
                    Col3.GetComponent<CapsuleCollider>().enabled = false;

                    IPlacedInst = true;
                    
                    
                        if (Inventory.IHaveBunny)
                        {
                            Kalimba.transform.position = Center.transform.position;

                        }
                        if (Inventory.IHaveTig)
                        {
                            Bongo.transform.position = Center.transform.position;
                        }
                        if (Inventory.IHaveDragon)
                        {
                            Guitar.transform.position = Center.transform.position;
                        }
                        if (Inventory.IHaveOx)
                        {
                            Doo.transform.position = Center.transform.position;
                        }
                    
                    
                    else
                    {
                        Debug.Log("The seat is taken");
                    }
                    //StartCoroutine(WaitForPick());

                }

                else
                {
                   
                }
            }
               
            else
            {
                
                
            }
        }

    }


    private void OnTriggerExit(Collider other)
    {
        if (IPlacedInst == true)
        {
            StartCoroutine(EnableColliders());
            Inventory.IHaveInstrument = false;
            IPlacedInst = false;


        }
        
    }

    IEnumerator EnableColliders()
    {
        yield return new WaitForSeconds(3);
        Col1.GetComponent<CapsuleCollider>().enabled = true;
        Col2.GetComponent<CapsuleCollider>().enabled = true;
        Col3.GetComponent<CapsuleCollider>().enabled = true;


        
    }

    //IEnumerator WaitForPick()
    // {
    //    yield return new WaitForSeconds(3);
    //    Inventory.IHaveInstrument = false;
    //  }

}
