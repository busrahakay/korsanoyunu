using UnityEngine;
using UnityEngine.InputSystem;
using DialogueEditor;
using Newtonsoft.Json.Bson;

public class Puzzle2diyalog : MonoBehaviour
{
    public GameObject image;
    public NPCConversation npc;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    private void Start()
    {
        image.SetActive(true);
        ConversationManager.Instance.StartConversation(npc);
    }

}
