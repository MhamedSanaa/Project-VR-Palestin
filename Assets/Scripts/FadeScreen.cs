using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FadeScreen : MonoBehaviour
{
    public bool fadeOnstart = true;
    public float fadeDuration = 2f;
    public Color fadeColor = Color.black;
    private Renderer renderer;
    // Start is called before the first frame update
    void Start()
    {
        renderer = GetComponent<Renderer>();
        if(fadeOnstart)
        {
            Debug.Log("test");
            FadeIn();
        }
    }
    public void FadeIn()
    {
        fade(1, 0);
    }
    public void FadeOut()
    {
        fade(0, 1);
    }


    public void fade(float alphaIn,float alphaOut)
    {
        Debug.Log("test1");
        StartCoroutine(FadeRoutine(alphaIn,alphaOut));
    }

    public IEnumerator FadeRoutine(float alphaIn, float alphaOut)
    {
        Debug.Log("test2");
        float timer = 0;
        while (timer<= fadeDuration)
        {
            Debug.Log("test3");
            Color newColor = fadeColor;
            newColor.a = Mathf.Lerp(alphaIn,alphaOut,timer/fadeDuration);
            renderer.material.SetColor("_Color", newColor);
            timer += Time.deltaTime;
            yield return null;
        }
        Debug.Log("test3");
        Color newColor2 = fadeColor;
        newColor2.a = alphaOut;
        renderer.material.SetColor("_Color", newColor2);
    }
}
