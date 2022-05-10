using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class takip : MonoBehaviour
{
    //Hedef olarak ana karakterimi unity üzerinden baðladým
    public GameObject hedef;
    public Vector3 cameraOffset;
    public Vector3 pozisyon;
    public float smoothTime = 0.5F;
    private Vector3 velocity = Vector3.zero;

    // Update is called once per frame
    void LateUpdate()
    {
        //Karakter hareket ettiðinde kameranýn da hareket etmesi.
        pozisyon = hedef.transform.position + cameraOffset;
        //Kamera hareketi için gerekli deðerleri ve gecikme deðerini ekledim.
        transform.position = Vector3.SmoothDamp(transform.position , pozisyon, ref velocity , smoothTime);
        //Böylece karakterin hareket etmesiyle kamera ayný anda hareket etmeyecek. Biraz daha geriden gelecek.
    }
}
