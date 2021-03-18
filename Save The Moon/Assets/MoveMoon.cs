using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveMoon : MonoBehaviour
{
    [SerializeField] float lerpTime;

    public Transform imposter;

    void Start()
    {
     
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = Vector3.Lerp (transform.position, imposter.transform.position, lerpTime * Time.deltaTime);

    }
}
