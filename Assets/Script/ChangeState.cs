using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeState : MonoBehaviour
{
    public GameObject vid, aud;

    public void ArMode()
    {
        aud.SetActive(false);
        vid.SetActive(true);

    }
     
}
