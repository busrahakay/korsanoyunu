using UnityEngine;
using DialogueEditor;
public class NewMonoBehaviourScript : MonoBehaviour
{
    public NPCConversation conversation;
    public void Start()
    {
        ConversationManager.Instance.StartConversation(conversation);
    }
}
