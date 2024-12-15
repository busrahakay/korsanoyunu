using UnityEngine;
using UnityEngine.SceneManagement;

public class BoneGame : MonoBehaviour
{
    int yerlestirilen_parca = 0;
    int toplam_puzzle = 14;
    public string scene;
    void Start()
    {

    }
    public void sayi_arttir()
    {
        yerlestirilen_parca++;
        if (yerlestirilen_parca == toplam_puzzle)
        {
            SceneManager.LoadScene(scene);
        }
    }
}
