using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class hareket : MonoBehaviour
{
    public float hýz = 3f;

    public Rigidbody2D rb;
    public Animator animator;
    Vector2 ileri;

    // Update is called once per frame
    void Update()
    {
        //yukarý aþaðý, Sað sol girdiler.
        ileri.x = Input.GetAxisRaw("Horizontal");
        ileri.y = Input.GetAxisRaw("Vertical");

        //Yaptýðým animasyonlarý koda baðladým. Hareket edildiðinde animasyonlar devreye girecek.
        animator.SetFloat("Horizontal", ileri.x);
        animator.SetFloat("Vertical", ileri.y);
        animator.SetFloat("Hýz", ileri.sqrMagnitude);
    }

    void FixedUpdate()
    {
        //Hareket edildiðinde pozisyon deðiþimi ve deðiþim hýzý.
        rb.MovePosition(rb.position + ileri * hýz * Time.fixedDeltaTime);
    }

}
