using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayMyMusic : MonoBehaviour
{

    private void OnTriggerEnter(Collider other)
    {
        if (!GetComponent<AudioSource>().isPlaying)
        {
            GetComponent<AudioSource>().Play();
        }
    }
}
