using UnityEngine;
using UnityEngine.InputSystem;

public class HaritaAc : MonoBehaviour
{
    public GameObject map;
    public GameObject map1;
    public PlayerInput playerInput;
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            map.SetActive(true);
            map1.SetActive(true);
            playerInput.enabled = false;
        }
    }
}
