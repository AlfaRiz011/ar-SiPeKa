using System.Collections;
using System.Collections.Generic;
using UnityEngine;
 
public class AudioManager : MonoBehaviour
{
    public AudioSource aS;
    public GameObject pB, sB, lO;
     
    private void Update()
    {
        if (!lO.activeSelf)
        {
            aS.Stop();
        }

        if (!aS.isPlaying)
        {
            sB.SetActive(false);
            pB.SetActive(true);
        }


        
    }

    public void PlayAudio()
    {
         
        if (!aS.isPlaying)
        {
            pB.SetActive(false);
            sB.SetActive(true);
            aS.Play();

        }
    }

    public void StopAudio()
    {
         
        if (aS.isPlaying)
        {
            sB.SetActive(false);
            pB.SetActive(true);
            aS.Stop();
        }
    }

}

