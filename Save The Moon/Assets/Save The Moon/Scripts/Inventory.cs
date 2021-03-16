using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Inventory : MonoBehaviour
{
    [SerializeField] private Image tigW;
    [SerializeField] private Image bunW;
    [SerializeField] private Image dragW;
    [SerializeField] private Image oxW;


    [SerializeField] private Image alarm;

    public bool IHaveInstrument;

    public bool IHaveTig;
    public bool IHaveBunny;
    public bool IHaveDragon;
    public bool IHaveOx;


    // Start is called before the first frame update
    void Start()
    {
        IHaveInstrument = false;
        alarm.enabled = false;
        //StartCoroutine(TigFlash());
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

        if (IHaveTig == true)
        {
            tigW.enabled = true;
        }
        else
        {
            tigW.enabled = false;
        }

        if (IHaveBunny == true)
        {
            bunW.enabled = true;
        }
        else
        {
            bunW.enabled = false;
        }

        if (IHaveDragon == true)
        {
            dragW.enabled = true;
        }
        else
        {
            dragW.enabled = false;
        }

        if (IHaveOx == true)
        {
            oxW.enabled = true;
        }
        else
        {
            oxW.enabled = false;
        }
    }

    public IEnumerator Alarm()
    {
        yield return new WaitForSeconds(0.2f);
        alarm.enabled = true;
        yield return new WaitForSeconds(0.2f);
        alarm.enabled = false;
        yield return new WaitForSeconds(0.2f);
        alarm.enabled = true;
        yield return new WaitForSeconds(0.2f);
        alarm.enabled = false;
    }

}
