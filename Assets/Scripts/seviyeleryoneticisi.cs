using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class seviyeleryoneticisi : MonoBehaviour {
    public Button s1_buton,s2_buton, s3_buton, s4_buton, s5_buton,s6_buton, s7_buton, s8_buton, s9_buton, s10_buton, s11_buton, s12_buton,
      s13_buton, s14_buton, s15_buton, s16_buton, s17_buton, s18_buton;


    public static bool Soru1, Soru2, Soru3, Soru4, Soru5, Soru6, Soru7, Soru8, Soru9, Soru10, Soru11, Soru12, Soru13, Soru14, Soru15, Soru16,
        Soru17, Soru18;

    string  birlestirme;
    public void Start()
    { 
        
        Soru1 = true;
    }
    public void Update()
    {
       
        if (Soru2 == true)
        {
           
            s2_buton.interactable = true;
        }
        if (Soru3 == true)
        {
            s3_buton.interactable = true;
        }
        if (Soru4 == true)
        {
            s4_buton.interactable = true;
        }
        if (Soru5 == true)
        {
            s5_buton.interactable = true;
        }
        if (Soru6 == true)
        {
            s6_buton.interactable = true;
        }
        if (Soru7 == true)
        {
            s7_buton.interactable = true;
        }
        if (Soru8 == true)
        {
            s8_buton.interactable = true;
        }
        if (Soru9 == true)
        {
            s9_buton.interactable = true;
        }
        if (Soru10 == true)
        {
            s10_buton.interactable = true;
        }
        if (Soru11 == true)
        {
            s11_buton.interactable = true;
        }
        if (Soru12 == true)
        {
            s12_buton.interactable = true;
        }
        if (Soru13 == true)
        {
            s13_buton.interactable = true;
        }
        if (Soru14== true)
        {
            s14_buton.interactable = true;
        }
        if (Soru15 == true)
        {
            s15_buton.interactable = true;
        }
        if (Soru16 == true)
        {
            s16_buton.interactable = true;
        }
        if (Soru17 == true)
        {
            s17_buton.interactable = true;
        }
        if (Soru18 == true)
        {
            s18_buton.interactable = true;
        }

    }
}
