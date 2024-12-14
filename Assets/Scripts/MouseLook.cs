using UnityEngine;

public class MouseLook : MonoBehaviour
{
    public float mouseSensitivity = 100f; // Fare hassasiyeti
    private float rotationY = 0f; // Yatay rotasyonu saklama

    void Update()
    {
        if (Input.GetMouseButton(0)) // Sol fare tuþu basýlýysa
        {
            // Fare hareketini oku
            float mouseX = Input.GetAxis("Mouse X") * mouseSensitivity * Time.deltaTime;

            // Oyuncunun yatay dönüþünü güncelle
            rotationY += mouseX;

            // Oyuncunun rotasyonunu uygula
            transform.rotation = Quaternion.Euler(0, rotationY, 0);
        }
    }
}
