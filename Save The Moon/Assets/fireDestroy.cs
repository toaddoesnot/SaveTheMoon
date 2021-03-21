using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fireDestroy : MonoBehaviour
{
    
        void OnTriggerEnter(Collider collider)
        {
        GameObject[] enemies = GameObject.FindGameObjectsWithTag("FIRE");
        foreach (GameObject enemy in enemies)
            GameObject.Destroy(enemy);
    }
}
