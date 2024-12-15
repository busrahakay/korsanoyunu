using UnityEngine;
using UnityEngine.InputSystem;
using DialogueEditor;
using Newtonsoft.Json.Bson;

public class Puzzle1son : MonoBehaviour
{
    public int FoundObjects;
    public GameObject image;
    public NPCConversation npc;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    private void Start()
    { 
        if ( FoundObjects == 4 ) {
            image.SetActive(true);
            ConversationManager.Instance.StartConversation(npc); }
        //FoundObjects.SetActive(true);
        //ConversationManager.Instance.StartConversation(npc);
    }
}
