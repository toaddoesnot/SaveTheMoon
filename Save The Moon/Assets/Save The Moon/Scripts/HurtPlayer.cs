using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HurtPlayer : MonoBehaviour
{
    public int damageToGive = 6;
    public AudioSource death;

    //delete after test
    public Transform teleportTarget;
    public GameObject thePlayer;
    public bool teleport;


    // Start is called before the first frame update
    void Start()
    {
        teleport = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("r"))
        {
            //Debug.Log("You r killed");
                FindObjectOfType<HealthController>().HurtPlayer(damageToGive);
        }

        //delete after test
       
        
            if (Input.GetKeyDown("t"))
            {
            
            if (teleport == false)
                {
                StartCoroutine(Teleport());
                }

                else
            {

            }
                   
            }
       
       
    }

    IEnumerator Teleport()
    {
        yield return new WaitForSeconds(3);
        teleport = true;
        thePlayer.transform.position = teleportTarget.transform.position;
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Player")
        {
            FindObjectOfType<HealthController>().HurtPlayer(damageToGive);
            GetComponent<AudioSource>().Play();
        }
    }
}
