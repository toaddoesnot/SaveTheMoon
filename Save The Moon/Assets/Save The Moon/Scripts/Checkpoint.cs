using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Checkpoint : MonoBehaviour
{

    public HealthController theHealthMan;


    // Start is called before the first frame update
    void Start()
    {
        theHealthMan = FindObjectOfType<HealthController>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Player")
        {
            theHealthMan.SetSpawnPoint(transform.position);
        }
    }

}
