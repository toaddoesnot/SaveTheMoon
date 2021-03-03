using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public float distance;
    public static bool queriesHitBackfaces;
    public GameObject cone;


    public bool IsHit;
    public bool CR_running;
    public bool colorChanging;

    void Start()
    {
        queriesHitBackfaces = false;
        IsHit = false;
        cone.GetComponent<Renderer>().material.color = Color.green;
    }

   
    void Update()
    {
       
        transform.Rotate(new Vector3(0f, 25f, 0f) * Time.deltaTime);
       

       RaycastHit hitInfo;
        if(Physics.Raycast(transform.position, transform.right, out hitInfo, distance))
       {
            Debug.DrawLine(transform.position, hitInfo.point, Color.red);
            
            if(hitInfo.collider.CompareTag("Player"))
            {
                Moon();
            }

        }
        else
        {
            Debug.DrawLine(transform.position, transform.position + transform.right * distance, Color.green);
       }




    }

    public void Moon()
    {
        if (IsHit == true)
        {
            if(CR_running == true)
            {
               
            }
            
            else
            {
                
                StartCoroutine(MoonEating());
                
            }
            
        }

        else
        {
            IsHit = true;
            
        }
    }

    IEnumerator MoonEating()
    {
        CR_running = true;
        cone.GetComponent<Renderer>().material.color = Color.red;


        Debug.Log("The Moon lost one piece.");
        IsHit = false;

        yield return new WaitForSeconds(1);

        CR_running = false;
        cone.GetComponent<Renderer>().material.color = Color.green;
    }





}
