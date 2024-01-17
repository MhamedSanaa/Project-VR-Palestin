using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FinishScript : MonoBehaviour
{
    public SceneTransitionManager sceneTransitionManager;
    private void Start()
    {
        sceneTransitionManager = GameObject.Find("TransitionManager").GetComponent<SceneTransitionManager>();
    }
    // Start is called before the first frame update
    private void OnTriggerEnter(Collider other)
    {
        sceneTransitionManager.GoToSceneAsync(0);
    }
}
