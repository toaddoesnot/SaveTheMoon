using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inventory : MonoBehaviour
{
    public bool IHaveInstrument;

    public bool IHaveTig;
    public bool IHaveBunny;
    public bool IHaveDragon;
    public bool IHaveOx;


    // Start is called before the first frame update
    void Start()
    {
        IHaveInstrument = false;
        
    }

    // Update is called once per frame
    void Update()
    {
        if (IHaveInstrument == false)
        {
            IHaveTig = false;
            IHaveBunny = false;
            IHaveDragon = false;
            IHaveOx = false;
        }
    }
}
