using UnityEngine;
using UnityEngine.SceneManagement;

public class Play : MonoBehaviour
{
    public void LoadSampleTerrainScene()
    {
        // SampleTerrain sahnesine ge�i� yap
        SceneManager.LoadScene("SampleTerrain");
    }
}