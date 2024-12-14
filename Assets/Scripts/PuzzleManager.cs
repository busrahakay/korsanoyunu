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
    public void CupFound()
        => ObjectFound(Cup);
    public void BotFound()
        => ObjectFound(Bot);
    public void KafaFound()
        => ObjectFound(Kafa);
    public void SiseFound()
        => ObjectFound(Sise);
    public void CheckMissionComplete()
    {
        if(ObjectsToFind == FoundObjects)
        {
            //Next Level
        }
    }
    private void ObjectFound(GameObject Object)
    {
        Object.SetActive(false);
        Instantiate(ParticleEffect, Object.transform.position, Object.transform.rotation);
        FoundObjects++;
        CheckMissionComplete();
    }
    /* Coroutine diye ararsin
    private IEnumerator ScaleUp(float MaxScale, GameObject Object)
    {
        while (Object.transform.scale.X < MaxScale)
        {
            yield return new WaitForSeconds(.1f);
            Object.transform.scale = Object.transform.scale * .1f;
        }
        //Particle SetActive True
    }*/
}
