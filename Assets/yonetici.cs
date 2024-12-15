using UnityEngine;

public class yonetici : MonoBehaviour
{
    int yerlestirilen_parca = 0;
    int toplam_puzzle = 12;
    void Start()
    {
        
    }
    public void sayi_arttir()
    {
        yerlestirilen_parca++;
        if (yerlestirilen_parca == toplam_puzzle)
        {
            Debug.Log("sonraki bölüme geç");
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
