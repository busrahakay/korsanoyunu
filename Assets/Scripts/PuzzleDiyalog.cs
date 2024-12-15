using UnityEngine;
using DialogueEditor;

public class PuzzleDiyalog : MonoBehaviour
{

    public GameObject image;
    public NPCConversation npc;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
            image.SetActive(true);
            ConversationManager.Instance.StartConversation(npc);
            //playerInput.enabled = false;
    }
}
