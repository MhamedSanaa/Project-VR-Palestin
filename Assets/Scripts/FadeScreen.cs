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
        
        StartCoroutine(FadeRoutine(alphaIn,alphaOut));
    }

    public IEnumerator FadeRoutine(float alphaIn, float alphaOut)
    {
        
        float timer = 0;
        while (timer<= fadeDuration)
        {
            Color newColor = fadeColor;
            newColor.a = Mathf.Lerp(alphaIn,alphaOut,timer/fadeDuration);
            renderer.material.SetColor("_Color", newColor);
            timer += Time.deltaTime;
            yield return null;
        }
      
        Color newColor2 = fadeColor;
        newColor2.a = alphaOut;
        renderer.material.SetColor("_Color", newColor2);
    }
}
