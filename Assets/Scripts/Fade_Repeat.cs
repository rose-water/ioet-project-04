using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fade_Repeat : MonoBehaviour
{
    public float fadeInSpeed;
    public float fadeOutSpeed;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (GetComponent<Renderer>().material.color.a > .95) {
            StartCoroutine(FadeOutObject());
        } else if (GetComponent<Renderer>().material.color.a < .05){
            StartCoroutine(FadeInObject());
        }


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
