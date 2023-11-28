using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeStateVid : MonoBehaviour
{
    public GameObject vid, vid2, Ar;

    public void ArMode()
    {
        vid.SetActive(false);
        Ar.SetActive(true);
        vid2.SetActive(true);
    }

}
