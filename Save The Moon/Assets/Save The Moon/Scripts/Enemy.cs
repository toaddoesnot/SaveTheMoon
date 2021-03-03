using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public float distance;
    public static bool queriesHitBackfaces;

    public bool IsHit;
    public bool CR_running;

    void Start()
    {
        queriesHitBackfaces = false;
        IsHit = false;
        
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

        Debug.Log("The Moon lost one piece.");
        IsHit = false;

        yield return new WaitForSeconds(3);

        CR_running = false;
    }

}
