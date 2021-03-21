using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OrderManager : MonoBehaviour
{
    public GameObject Bongo;
    public GameObject Kalimba;
    public GameObject Doo;
    public GameObject Guitar;

    public GameObject BongoPlat;
    public GameObject KalimbaPlat;
    public GameObject DooPlat;
    public GameObject GuitarPlat;

    public ZodiacPlatform BongoOk;
    public ZodiacPlatform KalimbaOk;
    public ZodiacPlatform DooOk;
    public ZodiacPlatform GuitarOk;

    // Update is called once per frame
    void Update()
    {
        if (Bongo.transform.position == new Vector3(-48.41f, 0.4400001f, 22.57f))
        {
            BongoOk.IsCorrect = true;
            BongoPlat.GetComponent<Renderer>().material.color = new Color32(63, 130, 61, 255);
            Bongo.GetComponent<BoxCollider>().enabled = false;
        }
        else
        {
            BongoPlat.GetComponent<Renderer>().material.color = Color.gray;
        }

        if (Kalimba.transform.position == new Vector3(-50.21f, 0.4400001f, 22.07f))
        {
            KalimbaOk.IsCorrect = true;
            KalimbaPlat.GetComponent<Renderer>().material.color = new Color32(63, 130, 61, 255);
            Kalimba.GetComponent<BoxCollider>().enabled = false;
        }
        else
        {
            KalimbaPlat.GetComponent<Renderer>().material.color = Color.gray;
        }

        if (Guitar.transform.position == new Vector3(-52.21f, 0.4400001f, 22.57f))
        {
            GuitarOk.IsCorrect = true;
            GuitarPlat.GetComponent<Renderer>().material.color = new Color32(63, 130, 61, 255);
            Guitar.GetComponent<BoxCollider>().enabled = false;
        }
        else
        {
            GuitarPlat.GetComponent<Renderer>().material.color = Color.gray;
        }

        if (Doo.transform.position == new Vector3(-46.81f, 0.4400001f, 23.77f))
        {
            DooOk.IsCorrect = true;
            DooPlat.GetComponent<Renderer>().material.color = new Color32(63, 130, 61, 255);
            Doo.GetComponent<BoxCollider>().enabled = false;
        }
        else
        {
            DooPlat.GetComponent<Renderer>().material.color = Color.gray;
        }

        if (Bongo.transform.position == new Vector3(-48.41f, 0.4400001f, 22.57f))
        {
            if (Kalimba.transform.position == new Vector3(-50.21f, 0.4400001f, 22.07f))
            {
                if (Guitar.transform.position == new Vector3(-52.21f, 0.4400001f, 22.57f))
                {
                    if (Doo.transform.position == new Vector3(-46.81f, 0.4400001f, 23.77f))
                    {
                        Debug.Log("You won");
                    }
                }
            }
        }



    }
}
