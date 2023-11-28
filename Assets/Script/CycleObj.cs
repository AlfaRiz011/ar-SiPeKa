using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CycleObject : MonoBehaviour
{
    public List<GameObject> obj;
    private int currentIndex = 0;
    void Start()
    {
        SetActiveObject(currentIndex);
    }

    public void nextObj()
    {
        obj[currentIndex].SetActive(false);

        currentIndex = (currentIndex + 1) % obj.Count;

        SetActiveObject(currentIndex);
    }

    public void prevObj()
    {
        obj[currentIndex].SetActive(false);

        currentIndex = (currentIndex - 1 + obj.Count) % obj.Count;

        SetActiveObject(currentIndex);
    }

    private void SetActiveObject(int index)
    {
        obj[index].SetActive(true);
    }
}