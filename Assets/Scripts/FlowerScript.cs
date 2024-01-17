using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlowerScript : MonoBehaviour
{
    public SceneTransitionManager sceneTransitionManager;
    public Vector3 firstPosition;
    // Start is called before the first frame update
    private void Start()
    {
        firstPosition = new Vector3(2.45499992f, 3.80299997f, -8.55000019f);
        sceneTransitionManager = GameObject.Find("TransitionManager").GetComponent<SceneTransitionManager>();
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "table")
        {
            
            collision.gameObject.tag = "Untagged";
            SceneScript.numberOfFlowers -= 1;
            GameObject newF = Instantiate(this.gameObject);
            if (SceneScript.numberOfFlowers == 0)
            {
                sceneTransitionManager.GoToSceneAsync(2);
            }
            else
            {
                newF.transform.position= firstPosition;
            }
            Destroy(this);
            
        }
    }
}
