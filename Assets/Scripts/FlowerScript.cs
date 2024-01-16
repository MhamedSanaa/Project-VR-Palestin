using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlowerScript : MonoBehaviour
{
    public Vector3 firstPosition;
    // Start is called before the first frame update
    private void Start()
    {
        firstPosition = this.transform.localPosition;
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "table")
        {
            collision.gameObject.tag = "Untagged";
            SceneScript.numberOfFlowers -= 1;
            GameObject newF = Instantiate(this.gameObject);
            newF.transform.position= firstPosition;

            
        }
    }
}
