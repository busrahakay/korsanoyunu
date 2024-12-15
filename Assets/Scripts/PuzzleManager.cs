using DialogueEditor;
using UnityEngine;

public class PuzzleManager : MonoBehaviour
{
    public byte ObjectsToFind;
    public byte FoundObjects = 0;
    public GameObject son_image, ok;
    public GameObject Kafa;
    public GameObject Bot;
    public GameObject Sise;
    public GameObject Cup;
    public NPCConversation npc;
    public GameObject ParticleEffect;
    public AudioClip foundSound; // Ses dosyasýný referans almak için deðiþken ekleyin
    private AudioSource audioSource; // AudioSource bileþeni için deðiþken ekleyin

    void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

    public void CupFound() => ObjectFound(Cup);
    public void BotFound() => ObjectFound(Bot);
    public void KafaFound() => ObjectFound(Kafa);
    public void SiseFound() => ObjectFound(Sise);

    public void CheckMissionComplete()
    {
        if (ObjectsToFind == FoundObjects)
        {
            // Next Level
        }
    }

    private void ObjectFound(GameObject foundObject)
    {
        foundObject.SetActive(false);
        Instantiate(ParticleEffect, foundObject.transform.position, foundObject.transform.rotation);
        audioSource.Play(); // Ses dosyasýný çal
        FoundObjects++;
        CheckMissionComplete();
    }

    private void Update()
    {
        if (FoundObjects == 4 && son_image.activeSelf == false) ShowPuzzleDialogue();
    }
    private void ShowPuzzleDialogue()
    {
        son_image.SetActive(true);
        ok.SetActive(true);
        ConversationManager.Instance.StartConversation(npc);
    }

    /* Coroutine örneði:
    private IEnumerator ScaleUp(float maxScale, GameObject obj)
    {
        Vector3 initialScale = obj.transform.localScale;
        Vector3 targetScale = new Vector3(maxScale, maxScale, maxScale);

        while (obj.transform.localScale.x < maxScale)
        {
            obj.transform.localScale = Vector3.Lerp(obj.transform.localScale, targetScale, Time.deltaTime * 0.1f);
            yield return null;
        }

        // Particle Effect SetActive True
    }
    */
}
