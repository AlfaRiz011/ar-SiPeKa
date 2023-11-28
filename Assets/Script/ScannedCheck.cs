using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScannedCheck : MonoBehaviour
{

    public Animator anim;
    public AudioSource audi;

    // Start is called before the first frame update
    void Start()
    {
       
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ScannedTarget()
    {
        anim.SetTrigger("Scale");
        audi.Play();
    }

    public void NotScannedTarget()
    {
        anim.SetTrigger("NotScale");
        audi.Stop();
    }


}
