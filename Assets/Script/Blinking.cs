using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
 
public class Blinking : MonoBehaviour
{
    
    TextMeshProUGUI text;

    void Start()
    {
        text = GetComponent<TextMeshProUGUI>();
        StartBlink();
    }

    IEnumerator Blink()
    {
        while(true)
        {
            switch (text.color.a.ToString())
            {
                case "0":
                    text.color = new Color(text.color.r,text.color.g, text.color.b, 1);
                    yield return new WaitForSeconds(0.5f);
                        break;
                case "1":
                    text.color = new Color(text.color.r, text.color.g, text.color.b, 0);
                    yield return new WaitForSeconds(0.5f);
                    break;
            }
        }
    }

    public void StartBlink()
    {
        StopCoroutine("Blink");
        StartCoroutine("Blink");
    }
    public void StopBlink()
    {
        StopCoroutine("Blink");
    }
}
