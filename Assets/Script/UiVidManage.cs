using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;

public class UiVidManage : MonoBehaviour
{
    public VideoPlayer aS;
    public GameObject pB, sB, paB;

    private void Update()
    {

        if (!aS.isPlaying)
        {
            pB.SetActive(true);
            paB.SetActive(false);
        }
    }

    public void PlayVid()
    {

        if (!aS.isPlaying)
        {
            paB.SetActive(true);
            pB.SetActive(false);
            aS.Play();

        }
    }

    public void PauseVid()
    {

        if (aS.isPlaying)
        {
            paB.SetActive(false);
            pB.SetActive(true);
            aS.Pause();
        }
    }

    public void StopVid()
    {

        if (aS.isPlaying)
        {
            aS.Stop();
        }
    }

}

