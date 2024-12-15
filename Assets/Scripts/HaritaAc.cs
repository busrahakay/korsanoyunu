using UnityEngine;
using UnityEngine.InputSystem;
using DialogueEditor;

public class HaritaAc : MonoBehaviour
{
    public GameObject map;
    public PlayerInput playerInput;
    public NPCConversation npc;
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            map.SetActive(true);
            ConversationManager.Instance.StartConversation(npc);
            playerInput.enabled = false;
        }
    }
}
