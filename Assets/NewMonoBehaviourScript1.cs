using UnityEngine;

public class NewMonoBehaviourScript1 : MonoBehaviour
{
    Camera kamera;
    Vector2 baslangýc_pozisyonu;
    GameObject[] game;
    //yonetici yonet;

    private void OnMouseDrag()
    {
        Vector3 pozisyon=kamera.ScreenToWorldPoint(Input.mousePosition);
        pozisyon.z = 0;
        transform.position = pozisyon;
    }
    void Start()
    {kamera=GameObject.Find("Main Camera").GetComponent<Camera>();
        baslangýc_pozisyonu = transform.position;
        game = GameObject.FindGameObjectsWithTag("Player");
        //yonet= GameObject.Find("yonetici").GetComponent<yonetici>();
        
    }

    
    void Update()
    {
        if (Input.GetMouseButtonUp(0))
        {
            foreach(GameObject kutu in game)
            {
                if (kutu.name == gameObject.name)
                {
                    float mesafe=Vector3.Distance(kutu.transform.position,transform.position);
                    if (mesafe <= 1)
                    {
                        transform.position=kutu.transform.position;
                        //yonet.sayi_arttir();
                    }
                    else
                    {
                        transform.position = baslangýc_pozisyonu;
                    }
                }
            }
        }
        
    }
}
