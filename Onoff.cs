using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Onoff : MonoBehaviour
{
    public static bool onoff = false;

    // Update is called once per frame
    void Update()
    {
        if (onoff == true)
        {
            gameObject.SetActive(true);
        }
        else
        {
            gameObject.SetActive(false);
            onoff = false;
        }
            
        
    }

   
}
