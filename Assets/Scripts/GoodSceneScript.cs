using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GoodSceneScript : MonoBehaviour
{
    GameObject fadeIn;
    // Start is called before the first frame update
    void Start()
    {
        fadeIn = GameObject.Find("FadeScreen");
        fadeIn.GetComponent<FadeScreen>().FadeIn();
    }
    void Awake()
    {
        fadeIn = GameObject.Find("FadeScreen");
        fadeIn.GetComponent<FadeScreen>().FadeIn();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
