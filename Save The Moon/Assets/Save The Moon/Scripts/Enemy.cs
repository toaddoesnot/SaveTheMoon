using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public float distance;
    public static bool queriesHitBackfaces;


    // public float rotationSpeed;


    // Start is called before the first frame update
    void Start()
    {
        queriesHitBackfaces = false;

        
    }

    // Update is called once per frame
    void Update()
    {
       
        transform.Rotate(new Vector3(0f, 25f, 0f) * Time.deltaTime);
       

        RaycastHit hitInfo;
        if(Physics.Raycast(transform.position, transform.right, out hitInfo, distance))
        {
            Debug.DrawLine(transform.position, hitInfo.point, Color.red);
           
            
        }
        else
        {
            Debug.DrawLine(transform.position, transform.position + transform.right * distance, Color.green);
           
            
        }

        


    }
}
