using DialogueEditor;
using UnityEngine;

public class ok_button : MonoBehaviour
{
    public GameObject image;
    public GameObject button;
    public void Start()
    {
        image.SetActive(false);
        button.SetActive(false);
    }
}
