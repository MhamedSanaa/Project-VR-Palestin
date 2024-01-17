using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlowerScript : MonoBehaviour
{
    public SceneTransitionManager sceneTransitionManager;
    public Vector3 firstPosition;

    public GameObject player;
    // Start is called before the first frame update

    public void SavePlayerTransform()
    {
        // Save the player's position and rotation in PlayerPrefs
        PlayerPrefs.SetFloat("PlayerPosX", player.transform.position.x);
        PlayerPrefs.SetFloat("PlayerPosY", player.transform.position.y);
        PlayerPrefs.SetFloat("PlayerPosZ", player.transform.position.z);
                                         
        PlayerPrefs.SetFloat("PlayerRotX", player.transform.rotation.x);
        PlayerPrefs.SetFloat("PlayerRotY", player.transform.rotation.y);
        PlayerPrefs.SetFloat("PlayerRotZ", player.transform.rotation.z);
        PlayerPrefs.SetFloat("PlayerRotW", player.transform.rotation.w);

        PlayerPrefs.Save();
    }
    private void Start()
    {
        player = GameObject.Find("XR Origin (XR Rig)");
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
                SavePlayerTransform();
            }
            else
            {
                newF.transform.position= firstPosition;
            }
            Destroy(this);
            
        }
    }
}
