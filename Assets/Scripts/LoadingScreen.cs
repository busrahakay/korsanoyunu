using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;
using UnityEngine.UI;

public class LoadingScreen : MonoBehaviour
{
    public string sceneToLoad;
    //private Text loadingText;

    void Start()
    {
        //// Canvas altýnda Text nesnesini bul
        //Canvas canvas = FindObjectOfType<Canvas>();
        //loadingText = canvas.GetComponentInChildren<Text>();

        //if (loadingText == null)
        //{
        //    Debug.LogError("Loading Text is not assigned or could not be found!");
        //    return;
        //}

        StartCoroutine(LoadSceneAsync());
    }

    IEnumerator LoadSceneAsync()
    {
        AsyncOperation asyncOperation = SceneManager.LoadSceneAsync(sceneToLoad);
        while (!asyncOperation.isDone)
        {
            float progress = Mathf.Clamp01(asyncOperation.progress / 0.9f);
            //loadingText.text = "Loading... " + (progress * 100) + "%";
            yield return null;
        }
    }
}
