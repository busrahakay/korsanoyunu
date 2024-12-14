using UnityEngine;
using UnityEngine.SceneManagement;

public class Next : MonoBehaviour
{
    public void LoadPuzzleScene()
    {
        // Puzzle sahnesine geçiþ yap
        SceneManager.LoadScene("Puzzle");
    }
}