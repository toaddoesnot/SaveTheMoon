using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Checkpoint : MonoBehaviour
{

    public HealthController theHealthMan;
    public AudioSource save;


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
       

        if (other.tag == "Player")
        {
            GetComponent<AudioSource>().Play();
            theHealthMan.SetSpawnPoint(transform.position);
            Debug.Log("Saved");
            StartCoroutine(Save());
            // 
        }
    }

    IEnumerator Save()
    {
        yield return new WaitForSeconds(0.7f);
        Destroy(gameObject);
    }

}
