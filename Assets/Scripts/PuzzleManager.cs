using UnityEngine;

public class PuzzleManager : MonoBehaviour
{
    public byte ObjectsToFind;
    public byte FoundObjects = 0;
    public GameObject Kafa;
    public GameObject Bot;
    public GameObject Sise;
    public GameObject Cup;

    public GameObject ParticleEffect;
    public AudioClip foundSound; // Ses dosyas�n� referans almak i�in de�i�ken ekleyin
    private AudioSource audioSource; // AudioSource bile�eni i�in de�i�ken ekleyin

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
        audioSource.PlayOneShot(foundSound); // Ses dosyas�n� �al
        FoundObjects++;
        CheckMissionComplete();
    }

    /* Coroutine �rne�i:
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
