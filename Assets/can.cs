using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class can : MonoBehaviour
{
    public int health;
    public int initHealth;
    public Image healthBar;
    public int Flagf;

    // Start is called before the first frame update
    void Start()
    {
        initHealth = health;
    }

    // Update is called once per frame
    void Update()
    {
        healthBar.fillAmount = (float)health / initHealth;
    }
    private void OnCollisionEnter2D(Collision2D c)
    {
        if(c.gameObject.tag == "KacakTetikleyici" && Input.GetKeyDown(KeyCode.E))
        {
            health -= 1;
            if(health <= 0)
            {
                Flagf = 2;
            }
        }
    }
}
