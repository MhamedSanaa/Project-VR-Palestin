using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GoodSceneScript : MonoBehaviour
{
    GameObject fadeIn;
    GameObject player;

    public void LoadPlayerTransform()
    {
        // Check if saved player position exists
        if (PlayerPrefs.HasKey("PlayerPosX"))
        {
            // Load the player's position and rotation from PlayerPrefs
            float posX = PlayerPrefs.GetFloat("PlayerPosX");
            float posY = PlayerPrefs.GetFloat("PlayerPosY");
            float posZ = PlayerPrefs.GetFloat("PlayerPosZ");

            float rotX = PlayerPrefs.GetFloat("PlayerRotX");
            float rotY = PlayerPrefs.GetFloat("PlayerRotY");
            float rotZ = PlayerPrefs.GetFloat("PlayerRotZ");
            float rotW = PlayerPrefs.GetFloat("PlayerRotW");

            // Set the player's position and rotation
            player.transform.position = new Vector3(posX, posY, posZ);
            player.transform.rotation = new Quaternion(rotX, rotY, rotZ, rotW);
        }
    }
    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.Find("XR Origin (XR Rig)");
        LoadPlayerTransform();
        //fadeIn = GameObject.Find("FadeScreen");
        fadeIn.GetComponent<FadeScreen>().FadeIn();
    }
    //void Awake()
    //{
    //    fadeIn = GameObject.Find("FadeScreen");
    //    fadeIn.GetComponent<FadeScreen>().FadeIn();
    //}

    // Update is called once per frame
    void Update()
    {
        
    }
}
