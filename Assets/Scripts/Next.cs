using UnityEngine;
using UnityEngine.SceneManagement;

public class Next : MonoBehaviour
{
    public void LoadPuzzleScene()
    {
        // Puzzle sahnesine ge�i� yap
        SceneManager.LoadScene("Puzzle");
    }
}