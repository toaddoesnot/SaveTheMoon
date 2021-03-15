using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthController : MonoBehaviour
{
    public int currentHealth;
    private bool isRespawning;
    private Vector3 respawnPoint;

    public Transform thePlayer;

    
    // Start is called before the first frame update
    void Start()
    {
        respawnPoint = thePlayer.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void HurtPlayer(int damage)
    {
        currentHealth -= damage;

        if(currentHealth <= 0)
        {
            Respawn();
        }
    }

    public void Respawn()
    {
        thePlayer.transform.position = respawnPoint;
        currentHealth = 5;
    }

    public void SetSpawnPoint(Vector3 newPosition)
    {
        respawnPoint = newPosition;
    }
}
