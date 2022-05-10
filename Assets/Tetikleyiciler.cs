using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Tetikleyiciler : MonoBehaviour
{
    public int health;
    public int initHealth;
    public Image healthBar;
    public int Flagf;
    //Yazi deðiþkenine unity üzerinden diyaloðu baðladým.
    public Text Yazi;
    //Gorev adýnda bir sayaç ekledim ve oyuncu ilerlemesini buradan kontrol ettim.
    public int Gorev;

    // Start is called before the first frame update
    void Start()
    {
        //Altyazýda Unity üzerinde diyalog yazýyor çünkü hizalamak için kullandým ve ekran üzerinde görebiliyorum.
        //Baþlangýçta diyalog yazýsý yerine hiçbirþey yazmayacak.
        Yazi.text = "";
        initHealth = health;
    }
    // Update is called once per frame
    void Update()
    {
        healthBar.fillAmount = (float)health / initHealth;
    }
    // Update is called once per frame
    void OnTriggerEnter2D(Collider2D c)
    {
        //Alanlara girildiðinde bu fonksiyon çalýþýyor.
        //Aþaðýdaki if elseler o alanlarýn tag isimlerini kontrol ediyor bunlar doðru tetikleyiciler ise konuþma tuþunu yazýyor.
        if(c.gameObject.tag == "KaptanTetikleyici")
        {
            Yazi.text = "Konuþmak için Boþluk tuþuna basýn.";
        }
        else if (c.gameObject.tag == "SaticiTetikleyici")
        {
            Yazi.text = "Konuþmak için Boþluk tuþuna basýn.";
        }
        else if (c.gameObject.tag == "TavernaTetikleyici")
        {
            Yazi.text = "Konuþmak için Boþluk tuþuna basýn.";
        }
        else if (c.gameObject.tag == "BelediyeTetikleyici")
        {
            Yazi.text = "Konuþmak için Boþluk tuþuna basýn.";
        }
        else if (c.gameObject.tag == "KacakTetikleyici" && Flagf == 0)
        {
            Yazi.text = "Konuþmak için Boþluk tuþuna basýn.";
        }
        else if (c.gameObject.tag == "UstaTetikleyici")
        {
            Yazi.text = "Konuþmak için Boþluk tuþuna basýn.";
        }
        else if (c.gameObject.tag == "KacakTetikleyici" && Flagf == 1)
        {
            Yazi.text = "Dövüþmek için E tuþuna basýn.";
        }
        else if (c.gameObject.tag == "KacakTetikleyici" && Flagf == 2)
        {
            Yazi.text = "Konuþmak için Boþluk tuþuna basýn.";
        }
    }
    void OnTriggerExit2D(Collider2D c)
    {
        //Herhangi bir alandan çýkýldýðýnda diyalok yazýsý yerinde tekrar hiçbirþey yazmýyor.
        Yazi.text = "";
    }
    void OnTriggerStay2D(Collider2D c)
    {
        //Tetikleyici alanlara girildiðinde ve konuþma baþlatma tuþuna basýldýðýnda aþaðýdaki diyaloglar yazýyor.
        //Her karakterin tetikleyici alanlarý farklý olduðu için konuþma farklarýný bu alan farklýlýklarýndan ayarladým.
        if (c.gameObject.tag == "KaptanTetikleyici" && Input.GetKeyDown(KeyCode.Space))
        {
            //Gorev sayacýna göre ilerlediði için karakterler ona göre konuþuyor.
            //Oyuncu diðer iþleri yapmadan son diyaloðu göremiyor. Sýrayla ilerleme kaydediyor.
            if(Gorev==8)
            {
                Yazi.text = "Sen : Kaçak gelecekmiþ. Elimde bir define haritasý var. peþine düþelim mi?\n" +
                "Kaptan : Bir bakayým. Yarýn denize açýlalým. Burayý biliyorum. Defineyi bulabilirim.";
            }
            else
            {
                Yazi.text = "Sen : Merhaba. Denize açýlmak istiyorum Kaptan. Tayfaya katýlabilir miyim?\n" +
                "Kaptan : Gemiden bir tayfa kaçtý. Eðer onu da bulursan seni tayfaya alýrým.";
                Gorev = 1;
            }
        }
        if (c.gameObject.tag == "SaticiTetikleyici" && Input.GetKeyDown(KeyCode.Space))
        {
            if (Gorev == 1)
            {
                Yazi.text = "Sen : Merhaba. Birini arýyorum. Burdan Birisi geçti mi?\n" +
                    "Satýcý : Ýskeleden Batýya doðru biri kaçtý ama kuzeyde belediye binasý var. Bir de oraya sor istersen.";
                Gorev = 2;
            }
            else
            {
                Yazi.text = "Satýcý : Merhaba yeni stoklarýmýz geldi bakmak ister misiniz ?";
            }
        }
        if (c.gameObject.tag == "BelediyeTetikleyici" && Input.GetKeyDown(KeyCode.Space))
        {
            if (Gorev == 2)
            {
                Yazi.text = "Sen : Belediyede mi çalýþýyorsunuz. Bu adaya bir kaçak sýðýnmýþ. Bir haber aldýnýz mý?\n" +
                    "Çalýþan : Þehrin batýsýnda bi nehir var. Kaçaklar genelde ordan kaçýyor. Güneyde iki köprüyle karþýya geç ordaki maðaraya bi bak.";
                Gorev = 3;
            }
            else
            {
                Yazi.text = "Çalýþan : Buyur biþey mi soracaktýn ?";
            }
        }
        if (c.gameObject.tag == "TavernaTetikleyici" && Input.GetKeyDown(KeyCode.Space))
        {
            if (Gorev == 5)
            {
                Yazi.text = "Sen : Hancý siz misiniz? Usta sizden içecek biþeyler istedi. Her zamankinden dedi. Onu alabilir miyim?\n" +
                    "Hancý : Tabii. Buyrun.";
                Gorev = 6;
            }
            else
            {
                Yazi.text = "Hancý : Merhaba. Ýçecek ister misiniz?";
            }
        }
        if (c.gameObject.tag == "UstaTetikleyici" && Input.GetKeyDown(KeyCode.Space))
        { 
            if(Gorev==6)
            {
                Yazi.text = "Sen : Ýstediðin içeceði getirdim. Hancý her zamankinden verdi.\n" +
                "Usta : Teþekkürler. Aradýðýn kiþi yukardaki uzun köprüden kaçýp yukarý koþtu. Orada sadece bir hayvan çiftliði var. Oradadýr.";
                Gorev = 7;
            }
            else if(Gorev==4)
            {
                Yazi.text = "Sen : Merhaba Usta. Buradan bi kaçak geçti mi. Belediye çalýþaný burda olabileceðini söyledi.\n" +
                "Usta : Burdan geçmedi ama ben gördüm. Eðer tavernadaki hancýya gidip içecek biþeyler alýrsan söylerim. Her zamankinden olsun.";
                Gorev = 5;
            }
            else
            {
                Yazi.text = "Usta : Hava çok sýcak deðil mi ? Sanýrým ben kýlýç dövdüðüm için terledim.";
            }
        }
        if (c.gameObject.tag == "KacakTetikleyici" && Input.GetKeyDown(KeyCode.Space))
        {
            if(Gorev == 7 && Flagf == 0)
            {
                Yazi.text = "Sen : Gemiden kaçan sen misin? Kaptan geri dönmeni söyledi. Bana zorluk çýkarma.\n" +
                    "Kaçak : O gemiye asla dönmem. Bunu kaptana söyle. Söylemezsen ben seninle bir mesaj gönderirim.";
                Flagf = 1;
                
            }
            else if(Gorev == 7 && Flagf == 2)
            {
                Yazi.text = "Kaçak : Tamam tamam. Daha da uzatmanýn anlamý yok. geleceðim merak etme.\n" +
                    "Sen : Güzel. Kaptan seni iskelede, geminin önünde bekliyor.";
                Gorev = 8;
            }
            else if(Gorev!=0)
            {
                Yazi.text = "Sen : Bir kaçak arýyorum. Buralardan birisi geçti mi ?\n" +
                    "Kaçak : Iýýý þeyy. Ben kimseyi görmedim. Kaçak falan yok zaten.";
            }
            
        }
        if (c.gameObject.tag == "MagaraTetikleyici" && Input.GetKeyDown(KeyCode.Space))
        {
            if (Gorev == 3)
            {
                Yazi.text = "Sen : Hey maðarada kimse var mý ?\n" +
                    "Sen : Sanýrým Kimse yok. Þu yandaki ustaya sorsam iyi olacak.";
                Gorev = 4;
            }
            else
            {
                Yazi.text = "";
            }
        }
        if (c.gameObject.tag == "KacakTetikleyici" && Input.GetKeyDown(KeyCode.E) && Flagf==1)
        {
            //her e tuþuna basýldýðýnda hedefin caný 1 azalýr.
            health -= 1;
            //eðer hedefin caný 0 veya altýna düþerse Flagf 2 olur ve hikaye olmasý gerektiði gibi devam eder.
            if (health <= 0)
            {
                Flagf = 2;
            }
        }
    }
}
