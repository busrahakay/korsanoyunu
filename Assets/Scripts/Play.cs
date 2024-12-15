using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;

public class Play : MonoBehaviour
{
    public GameObject loadingScene;
    public void LoadSampleTerrainScene()
    {
        // SampleTerrain sahnesine geçiþ yap
        loadingScene.SetActive(true);
        StartCoroutine(LoadSceneAsync());

    }
    IEnumerator LoadSceneAsync()
    {
        yield return new WaitForSeconds(1);
        AsyncOperation asyncOperation = SceneManager.LoadSceneAsync("SampleTerrain");
        while (!asyncOperation.isDone)
        {
            float progress = Mathf.Clamp01(asyncOperation.progress / 0.9f);
            yield return null;
        }
    }
}