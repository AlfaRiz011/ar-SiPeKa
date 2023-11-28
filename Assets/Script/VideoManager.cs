using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;

public class VideoManager : MonoBehaviour
{
    public VideoPlayer vP;
    public GameObject vF;

    // Update is called once per frame
    void Update()
    {
        // Periksa apakah objek vF aktif
        if (vF.activeSelf)
        {
            // Jika aktif, putar VideoPlayer
            if (!vP.isPlaying)
            {
                vP.Play();
            }
        }
        else
        {
            // Jika tidak aktif, hentikan VideoPlayer (opsional)
            if (vP.isPlaying)
            {
                vP.Pause();
            }
        }
    }
}
