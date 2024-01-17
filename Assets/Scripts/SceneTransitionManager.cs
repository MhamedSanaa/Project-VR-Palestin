using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneTransitionManager : MonoBehaviour
{
    public FadeScreen fadeScreen;

    private void Start()
    {
        fadeScreen = GameObject.Find("FadeScreen").GetComponent<FadeScreen>();
    }

    public void GoToScene(int sceneId)
    {
        StartCoroutine(GoToSceneRoutine(sceneId));
    }

    IEnumerator GoToSceneRoutine(int sceneId)
    {
        fadeScreen.FadeOut();
        yield return new WaitForSeconds(fadeScreen.fadeDuration);

        SceneManager.LoadScene(sceneId);
    }

    public void GoToSceneAsync(int sceneId)
    {
        StartCoroutine(GoToSceneAsyncRoutine(sceneId));
    }

    IEnumerator GoToSceneAsyncRoutine(int sceneId)
    {
        fadeScreen.FadeOut();
        yield return new WaitForSeconds(fadeScreen.fadeDuration);

        AsyncOperation operation = SceneManager.LoadSceneAsync(sceneId);
        operation.allowSceneActivation = false;

        float timer = 0;
        while(timer <= fadeScreen.fadeDuration && !operation.isDone)
        {
            timer += Time.deltaTime;
            yield return null;
        }
        operation.allowSceneActivation = true;
    }
}
