using DialogueEditor;
using UnityEngine;
using UnityEngine.SceneManagement;

public class nesne_bul : MonoBehaviour
{
    public byte ObjectsToFind;
    public byte FoundObjects = 7;
    public GameObject son_image, ok;
    public GameObject fare;
    public GameObject yesil;
    public GameObject aski;
    public GameObject muz;
    public GameObject bardak;
    public GameObject elma;
    public GameObject fare2;
    public NPCConversation npc;
    public GameObject ParticleEffect;
    public AudioClip foundSound; // Ses dosyasýný referans almak için deðiþken ekleyin
    private AudioSource audioSource; // AudioSource bileþeni için deðiþken ekleyin

    void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

    public void FareFound() => ObjectFound(fare);
    public void YesilFound() => ObjectFound(yesil);
    public void AskiFound() => ObjectFound(aski);
    public void MuzFound() => ObjectFound(muz);
    public void BardakFound() => ObjectFound(bardak);
    public void ElmaFound() => ObjectFound(elma);
    public void Fare2Found() => ObjectFound(fare2);

    public void CheckMissionComplete()
    {
        if (ObjectsToFind == FoundObjects)
        {
            SceneManager.LoadScene("Final");
        }
    }

    private void ObjectFound(GameObject foundObject)
    {
        foundObject.SetActive(false);
        Instantiate(ParticleEffect, foundObject.transform.position, foundObject.transform.rotation);
        audioSource.Play(); // Ses dosyasýný çal
        ObjectsToFind++;
        CheckMissionComplete();
    }
    /*
    private void Update()
    {
        if (FoundObjects == 7 && son_image.activeSelf == false) ShowPuzzleDialogue();
    }
    /*
    private void ShowPuzzleDialogue()
    {
        son_image.SetActive(true);
        ok.SetActive(true);
        ConversationManager.Instance.StartConversation(npc);
    }*/
}
