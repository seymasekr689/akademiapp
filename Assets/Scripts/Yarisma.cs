using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class Yarisma : MonoBehaviour {
	public Text soruismi, cevapa, cevapb, cevapc, cevapd, skoryazi;
	Sorular sr;
	public List<bool> sorulanlar;
	public static string dcevap1, ycevap1;
	public static int cevap,skor,ycevap=0,dcevap=0;


	void Start () {
		sr = GetComponent<Sorular>();
		for (int i = 0; i < sr.sorular.Count; i++)
        {
			sorulanlar.Add(false);
        }
		SoruEkle();
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	public void SoruEkle()
    {
        for (int i = 0; i < sorulanlar.Count; i++)
        {
            if (sorulanlar[i] == false)
            {
				int sorusayi = Random.Range(0, sorulanlar.Count);
				if (sorulanlar[sorusayi] == false)
				{
					sorulanlar[sorusayi] = true;
					skor++;
					skoryazi.text = skor.ToString();
					soruismi.text = sr.sorular[sorusayi].soruismi;
					cevapa.text = sr.sorular[sorusayi].cevapa;
					cevapb.text = sr.sorular[sorusayi].cevapb;
					cevapc.text = sr.sorular[sorusayi].cevapc;
					cevapd.text = sr.sorular[sorusayi].cevapd;
					cevap = sr.sorular[sorusayi].cevap;
					
				}
				else
				{
					SoruEkle();
				}
				break;
			}
			if(i == sorulanlar.Count - 1)
				{

                if (dcevap >= 2)
                {
					dcevap1 = (dcevap * 5).ToString();
					PlayerPrefs.SetString("D", dcevap1);
					
					SceneManager.LoadScene("BITIS");
				}
				else
                {
					dcevap1 = (dcevap * 5).ToString();
					PlayerPrefs.SetString("D", dcevap1);
					SceneManager.LoadScene("FinalHata");
				}
			}
		}		
		
        


    }
	public void cevapver(int deger)
    {
        if (deger == cevap)
        {
			dcevap++;
			SoruEkle();
			
        }
        else
        {
			ycevap++;
			SoruEkle();
			
        }
    }
}
