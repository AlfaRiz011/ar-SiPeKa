using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class backButton : MonoBehaviour
{
    
    public Button yourButton;

    public GameObject ArObject;
    public GameObject Check;
    public GameObject UiObject;
 


    public void TaskOnClick()
    {
        ArObject.gameObject.SetActive(true);
        Check.gameObject.SetActive(true);
        UiObject.gameObject.SetActive(false);
        Debug.Log("OK");
    }

}
