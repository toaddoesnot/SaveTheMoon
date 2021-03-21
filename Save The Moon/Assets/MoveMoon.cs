using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveMoon : MonoBehaviour
{
    [SerializeField] float lerpTime;
    public InstrumentPickUp instrument;
    public Transform imposter;

    void Start()
    {
     
    }

    // Update is called once per frame
    void Update()
    {
        if (instrument.MoveMoon == true)
        {

            transform.position = Vector3.Lerp(transform.position, imposter.transform.position, lerpTime * Time.deltaTime);
        }
    }
    //if (instrument.MoveMoon == true)
       // {
         //   StartCoroutine(LerpPosition(imposter, 5));
       // }

    }

   // IEnumerator LerpPosition(Vector3 targetPosition, float duration)
    //{
     //   float time = 0;
     //   Vector3 startPosition = transform.position;

      //  while (time < duration)
      //  {
      //      transform.position = Vector3.Lerp(startPosition, targetPosition, time / duration);
      //      time += Time.deltaTime;
      //      yield return null;
      //  }
        
    //    transform.position = targetPosition;
//    }
   

        
