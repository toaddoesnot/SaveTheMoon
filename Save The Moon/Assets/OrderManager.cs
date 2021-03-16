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

    // Update is called once per frame
    void Update()
    {
        if (Bongo.transform.position == new Vector3(-48.08444f, 0.4400001f, 22.54957f))
        {
            Debug.Log("Bongo is Ok");
        }
        else
        {
            Debug.Log("Bongo is not Ok");
        }

        if (Kalimba.transform.position == new Vector3(-49.88444f, 0.4400001f, 22.04957f))
        {
            Debug.Log("Kalimba is Ok");
        }
        else
        {
            Debug.Log("Kalimba is not Ok");
        }

        if (Guitar.transform.position == new Vector3(-7.949234f, -9.444143f, 146.56f))
        {
            Debug.Log("Guitar is Ok");
        }
        else
        {
            Debug.Log("Guitar is not Ok");
        }

        if (Doo.transform.position == new Vector3(-46.48444f, 0.4400001f, 23.74957f))
        {
            Debug.Log("Doo is Ok");
        }
        else
        {
            Debug.Log("Doo is not Ok");
        }

    }
}
