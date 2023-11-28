using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CycleUI : MonoBehaviour
{

    public List<GameObject> uiobj;
    private int currentIndex = 0;

    void Start()
    {
        SetActiveObject(currentIndex);
    }

    public void nextObj()
    {
        uiobj[currentIndex].SetActive(false);

        currentIndex = (currentIndex + 1) % uiobj.Count;

        SetActiveObject(currentIndex);
    }

    public void prevObj()
    {
        uiobj[currentIndex].SetActive(false);

        currentIndex = (currentIndex - 1 + uiobj.Count) % uiobj.Count;

        SetActiveObject(currentIndex);
    }

    private void SetActiveObject(int index)
    {
        uiobj[index].SetActive(true);
    }
}