using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fade_Once : MonoBehaviour
{
    public float fadeInSpeed;
    public float fadeOutSpeed;
    public int startDelay;
    public int pauseDelay;

    bool fadingIn = true;

    float startTime = 0;
    float pauseTime = 0;
    // Start is called before the first frame update
    void Start()
    {
        Color objectColor = GetComponent<Renderer>().material.color;
        objectColor = new Color(objectColor.r, objectColor.g, objectColor.b, 0);
        GetComponent<Renderer>().material.color = objectColor;
    }

    // Update is called once per frame
    void Update()
    {
        if (startTime > startDelay) {
            if (fadingIn) {
                StartCoroutine(FadeInObject());
            }
            if (GetComponent<Renderer>().material.color.a > .95) {

                if(pauseTime > pauseDelay) {
                    StartCoroutine(FadeOutObject());
                    fadingIn = false;
                }
                pauseTime += Time.deltaTime;
            }
        }
        startTime += Time.deltaTime;
    }

    public IEnumerator FadeInObject() {
        while (GetComponent<Renderer>().material.color.a < 1) {
            Color objectColor = GetComponent<Renderer>().material.color;
            float fadeAmount = objectColor.a + (fadeInSpeed * Time.deltaTime);

            objectColor = new Color(objectColor.r, objectColor.g, objectColor.b, fadeAmount);
            GetComponent<Renderer>().material.color = objectColor;
            yield return null;
        }
    }

    public IEnumerator FadeOutObject() {
        while (GetComponent<Renderer>().material.color.a > 0) {
            Color objectColor = GetComponent<Renderer>().material.color;
            float fadeAmount = objectColor.a - (fadeOutSpeed * Time.deltaTime);

            objectColor = new Color(objectColor.r, objectColor.g, objectColor.b, fadeAmount);
            GetComponent<Renderer>().material.color = objectColor;
            yield return null;
        }
    }


}
