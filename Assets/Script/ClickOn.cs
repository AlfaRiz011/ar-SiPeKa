using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClickOn : MonoBehaviour
{
    public GameObject Check;
    public GameObject ArObject;
    public GameObject UiObject;
    public GameObject vid, vid2;



    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Vector3 mousePosFar = new Vector3(Input.mousePosition.x, Input.mousePosition.y, Camera.main.farClipPlane);
            Vector3 mousePosNear = new Vector3(Input.mousePosition.x, Input.mousePosition.y, Camera.main.nearClipPlane);
            Vector3 mousePosF = Camera.main.ScreenToWorldPoint(mousePosFar);
            Vector3 mousePosN = Camera.main.ScreenToWorldPoint(mousePosNear);
            RaycastHit hit;

            if (Physics.Raycast(mousePosN, mousePosF - mousePosN, out hit))
            {

                if (hit.transform == transform)
                {
                    ArObject.gameObject.SetActive(false);
                    Check.gameObject.SetActive(false);
                    vid.SetActive(true);
                    vid2.SetActive(false);
             
                    UiObject.gameObject.SetActive(true);
                    Debug.Log("OK");
                }


            }
        }

    }
}

