using UnityEngine;

public class Collectible : MonoBehaviour
{
    public float rotationSpeed ;
    public GameObject onCollectEffect ;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(0, rotationSpeed, 0);

    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            //Destroy the collectible
            Destroy(gameObject); //gameObject bu kod tozun i�indeyse tozu kastediyor.
            //Instantiate the particle effect
            Instantiate(onCollectEffect, transform.position, transform.rotation);
        }


        
    }
}
