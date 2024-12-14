using UnityEngine;
using UnityEngine.SceneManagement;

public class Play : MonoBehaviour
{
    public void LoadSampleTerrainScene()
    {
        // SampleTerrain sahnesine geçiþ yap
        SceneManager.LoadScene("SampleTerrain");
    }
}