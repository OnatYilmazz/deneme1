using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class hareket : MonoBehaviour
{
    public float h�z = 3f;

    public Rigidbody2D rb;
    public Animator animator;
    Vector2 ileri;

    // Update is called once per frame
    void Update()
    {
        //yukar� a�a��, Sa� sol girdiler.
        ileri.x = Input.GetAxisRaw("Horizontal");
        ileri.y = Input.GetAxisRaw("Vertical");

        //Yapt���m animasyonlar� koda ba�lad�m. Hareket edildi�inde animasyonlar devreye girecek.
        animator.SetFloat("Horizontal", ileri.x);
        animator.SetFloat("Vertical", ileri.y);
        animator.SetFloat("H�z", ileri.sqrMagnitude);
    }

    void FixedUpdate()
    {
        //Hareket edildi�inde pozisyon de�i�imi ve de�i�im h�z�.
        rb.MovePosition(rb.position + ileri * h�z * Time.fixedDeltaTime);
    }

}
