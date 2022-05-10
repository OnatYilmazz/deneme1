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
    //Yazi de�i�kenine unity �zerinden diyalo�u ba�lad�m.
    public Text Yazi;
    //Gorev ad�nda bir saya� ekledim ve oyuncu ilerlemesini buradan kontrol ettim.
    public int Gorev;

    // Start is called before the first frame update
    void Start()
    {
        //Altyaz�da Unity �zerinde diyalog yaz�yor ��nk� hizalamak i�in kulland�m ve ekran �zerinde g�rebiliyorum.
        //Ba�lang��ta diyalog yaz�s� yerine hi�bir�ey yazmayacak.
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
        //Alanlara girildi�inde bu fonksiyon �al���yor.
        //A�a��daki if elseler o alanlar�n tag isimlerini kontrol ediyor bunlar do�ru tetikleyiciler ise konu�ma tu�unu yaz�yor.
        if(c.gameObject.tag == "KaptanTetikleyici")
        {
            Yazi.text = "Konu�mak i�in Bo�luk tu�una bas�n.";
        }
        else if (c.gameObject.tag == "SaticiTetikleyici")
        {
            Yazi.text = "Konu�mak i�in Bo�luk tu�una bas�n.";
        }
        else if (c.gameObject.tag == "TavernaTetikleyici")
        {
            Yazi.text = "Konu�mak i�in Bo�luk tu�una bas�n.";
        }
        else if (c.gameObject.tag == "BelediyeTetikleyici")
        {
            Yazi.text = "Konu�mak i�in Bo�luk tu�una bas�n.";
        }
        else if (c.gameObject.tag == "KacakTetikleyici" && Flagf == 0)
        {
            Yazi.text = "Konu�mak i�in Bo�luk tu�una bas�n.";
        }
        else if (c.gameObject.tag == "UstaTetikleyici")
        {
            Yazi.text = "Konu�mak i�in Bo�luk tu�una bas�n.";
        }
        else if (c.gameObject.tag == "KacakTetikleyici" && Flagf == 1)
        {
            Yazi.text = "D�v��mek i�in E tu�una bas�n.";
        }
        else if (c.gameObject.tag == "KacakTetikleyici" && Flagf == 2)
        {
            Yazi.text = "Konu�mak i�in Bo�luk tu�una bas�n.";
        }
    }
    void OnTriggerExit2D(Collider2D c)
    {
        //Herhangi bir alandan ��k�ld���nda diyalok yaz�s� yerinde tekrar hi�bir�ey yazm�yor.
        Yazi.text = "";
    }
    void OnTriggerStay2D(Collider2D c)
    {
        //Tetikleyici alanlara girildi�inde ve konu�ma ba�latma tu�una bas�ld���nda a�a��daki diyaloglar yaz�yor.
        //Her karakterin tetikleyici alanlar� farkl� oldu�u i�in konu�ma farklar�n� bu alan farkl�l�klar�ndan ayarlad�m.
        if (c.gameObject.tag == "KaptanTetikleyici" && Input.GetKeyDown(KeyCode.Space))
        {
            //Gorev sayac�na g�re ilerledi�i i�in karakterler ona g�re konu�uyor.
            //Oyuncu di�er i�leri yapmadan son diyalo�u g�remiyor. S�rayla ilerleme kaydediyor.
            if(Gorev==8)
            {
                Yazi.text = "Sen : Ka�ak gelecekmi�. Elimde bir define haritas� var. pe�ine d��elim mi?\n" +
                "Kaptan : Bir bakay�m. Yar�n denize a��lal�m. Buray� biliyorum. Defineyi bulabilirim.";
            }
            else
            {
                Yazi.text = "Sen : Merhaba. Denize a��lmak istiyorum Kaptan. Tayfaya kat�labilir miyim?\n" +
                "Kaptan : Gemiden bir tayfa ka�t�. E�er onu da bulursan seni tayfaya al�r�m.";
                Gorev = 1;
            }
        }
        if (c.gameObject.tag == "SaticiTetikleyici" && Input.GetKeyDown(KeyCode.Space))
        {
            if (Gorev == 1)
            {
                Yazi.text = "Sen : Merhaba. Birini ar�yorum. Burdan Birisi ge�ti mi?\n" +
                    "Sat�c� : �skeleden Bat�ya do�ru biri ka�t� ama kuzeyde belediye binas� var. Bir de oraya sor istersen.";
                Gorev = 2;
            }
            else
            {
                Yazi.text = "Sat�c� : Merhaba yeni stoklar�m�z geldi bakmak ister misiniz ?";
            }
        }
        if (c.gameObject.tag == "BelediyeTetikleyici" && Input.GetKeyDown(KeyCode.Space))
        {
            if (Gorev == 2)
            {
                Yazi.text = "Sen : Belediyede mi �al���yorsunuz. Bu adaya bir ka�ak s���nm��. Bir haber ald�n�z m�?\n" +
                    "�al��an : �ehrin bat�s�nda bi nehir var. Ka�aklar genelde ordan ka��yor. G�neyde iki k�pr�yle kar��ya ge� ordaki ma�araya bi bak.";
                Gorev = 3;
            }
            else
            {
                Yazi.text = "�al��an : Buyur bi�ey mi soracakt�n ?";
            }
        }
        if (c.gameObject.tag == "TavernaTetikleyici" && Input.GetKeyDown(KeyCode.Space))
        {
            if (Gorev == 5)
            {
                Yazi.text = "Sen : Hanc� siz misiniz? Usta sizden i�ecek bi�eyler istedi. Her zamankinden dedi. Onu alabilir miyim?\n" +
                    "Hanc� : Tabii. Buyrun.";
                Gorev = 6;
            }
            else
            {
                Yazi.text = "Hanc� : Merhaba. ��ecek ister misiniz?";
            }
        }
        if (c.gameObject.tag == "UstaTetikleyici" && Input.GetKeyDown(KeyCode.Space))
        { 
            if(Gorev==6)
            {
                Yazi.text = "Sen : �stedi�in i�ece�i getirdim. Hanc� her zamankinden verdi.\n" +
                "Usta : Te�ekk�rler. Arad���n ki�i yukardaki uzun k�pr�den ka��p yukar� ko�tu. Orada sadece bir hayvan �iftli�i var. Oradad�r.";
                Gorev = 7;
            }
            else if(Gorev==4)
            {
                Yazi.text = "Sen : Merhaba Usta. Buradan bi ka�ak ge�ti mi. Belediye �al��an� burda olabilece�ini s�yledi.\n" +
                "Usta : Burdan ge�medi ama ben g�rd�m. E�er tavernadaki hanc�ya gidip i�ecek bi�eyler al�rsan s�ylerim. Her zamankinden olsun.";
                Gorev = 5;
            }
            else
            {
                Yazi.text = "Usta : Hava �ok s�cak de�il mi ? San�r�m ben k�l�� d�vd���m i�in terledim.";
            }
        }
        if (c.gameObject.tag == "KacakTetikleyici" && Input.GetKeyDown(KeyCode.Space))
        {
            if(Gorev == 7 && Flagf == 0)
            {
                Yazi.text = "Sen : Gemiden ka�an sen misin? Kaptan geri d�nmeni s�yledi. Bana zorluk ��karma.\n" +
                    "Ka�ak : O gemiye asla d�nmem. Bunu kaptana s�yle. S�ylemezsen ben seninle bir mesaj g�nderirim.";
                Flagf = 1;
                
            }
            else if(Gorev == 7 && Flagf == 2)
            {
                Yazi.text = "Ka�ak : Tamam tamam. Daha da uzatman�n anlam� yok. gelece�im merak etme.\n" +
                    "Sen : G�zel. Kaptan seni iskelede, geminin �n�nde bekliyor.";
                Gorev = 8;
            }
            else if(Gorev!=0)
            {
                Yazi.text = "Sen : Bir ka�ak ar�yorum. Buralardan birisi ge�ti mi ?\n" +
                    "Ka�ak : I��� �eyy. Ben kimseyi g�rmedim. Ka�ak falan yok zaten.";
            }
            
        }
        if (c.gameObject.tag == "MagaraTetikleyici" && Input.GetKeyDown(KeyCode.Space))
        {
            if (Gorev == 3)
            {
                Yazi.text = "Sen : Hey ma�arada kimse var m� ?\n" +
                    "Sen : San�r�m Kimse yok. �u yandaki ustaya sorsam iyi olacak.";
                Gorev = 4;
            }
            else
            {
                Yazi.text = "";
            }
        }
        if (c.gameObject.tag == "KacakTetikleyici" && Input.GetKeyDown(KeyCode.E) && Flagf==1)
        {
            //her e tu�una bas�ld���nda hedefin can� 1 azal�r.
            health -= 1;
            //e�er hedefin can� 0 veya alt�na d��erse Flagf 2 olur ve hikaye olmas� gerekti�i gibi devam eder.
            if (health <= 0)
            {
                Flagf = 2;
            }
        }
    }
}
