using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckScanned : MonoBehaviour
{
    public GameObject red, green;
    
    
    void Start()
    {
        red.SetActive(true);
    }

    public void redLight()
    {
        green.SetActive(false);
        red.SetActive(true);
    }

    public void greenLight()
    {
        red.SetActive(false);
        green.SetActive(true);
    }
}



