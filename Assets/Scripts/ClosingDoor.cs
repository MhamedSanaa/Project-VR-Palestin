using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClosingDoor : MonoBehaviour
{
    public GameObject Door,Sound;
    // Start is called before the first frame update
    private void OnTriggerEnter(Collider other)
    {
        Door.gameObject.transform.localPosition =new Vector3(11.89f, 3, -4.6f);
        Sound.GetComponent<AudioSource>().Play();
        Destroy(this.gameObject);
    }
}
