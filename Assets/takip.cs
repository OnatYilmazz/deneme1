using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class takip : MonoBehaviour
{
    //Hedef olarak ana karakterimi unity �zerinden ba�lad�m
    public GameObject hedef;
    public Vector3 cameraOffset;
    public Vector3 pozisyon;
    public float smoothTime = 0.5F;
    private Vector3 velocity = Vector3.zero;

    // Update is called once per frame
    void LateUpdate()
    {
        //Karakter hareket etti�inde kameran�n da hareket etmesi.
        pozisyon = hedef.transform.position + cameraOffset;
        //Kamera hareketi i�in gerekli de�erleri ve gecikme de�erini ekledim.
        transform.position = Vector3.SmoothDamp(transform.position , pozisyon, ref velocity , smoothTime);
        //B�ylece karakterin hareket etmesiyle kamera ayn� anda hareket etmeyecek. Biraz daha geriden gelecek.
    }
}
