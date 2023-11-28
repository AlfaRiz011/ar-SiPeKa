using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwapManager : MonoBehaviour
{
    public List<GameObject> UISwap;

    private int _Currentindex;

    private void Start()
    {

        if (UISwap.Count > 0)
        {
            UISwap[0].SetActive(true);

            foreach (GameObject item in UISwap)
            {
                if (item != UISwap[0])
                {
                    item.SetActive(false);
                }
            }

        }
    }

    public void Next()
    {

        UISwap[_Currentindex].SetActive(false);

        if (UISwap[_Currentindex] == UISwap[1])
        {
            _Currentindex = 0;
        }
        else
        {
            _Currentindex += 1;
        }

        UISwap[_Currentindex].SetActive(true);
    }

    public void Previous()
    {
        UISwap[_Currentindex].SetActive(false);

        if (UISwap[_Currentindex] == UISwap[0])
        {
            _Currentindex = 1;
        }
        else
        {
            _Currentindex -= 1;
        }


        UISwap[_Currentindex].SetActive(true);

    }

}
