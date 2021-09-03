using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System;

public class Buttons : MonoBehaviour {
  public GameObject s1, s2, s3, s4, s5, arka1, arka2, arka3, arka4, arka5, d1, y1, d2, y2, d3, y3, d4, y4, d5, y5, aciklama, rakam, TextSkor;
  public Text i, x;
  public float targetTime = 60.0f;
  public int count = 0, count1 = 0;
  public void LoadScene(string sceneName) 
    {
    SceneManager.LoadScene(sceneName);

   }
    public void CloseApplication()
    {
        Application.Quit();

    }
    public void arkayidonme() {
    s1.SetActive(false);
    arka1.SetActive(true);
  }
  public void onedonme() {
    s1.SetActive(true);
    arka1.SetActive(false);
  }
  public void arkayidonme2() {
    s2.SetActive(false);
    arka2.SetActive(true);
  }
  public void onedonme2() {
    s2.SetActive(true);
    arka2.SetActive(false);
  }
  public void arkayidonme3() {
    s3.SetActive(false);
    arka3.SetActive(true);
  }
  public void onedonme3() {
    s3.SetActive(true);
    arka3.SetActive(false);
  }
  public void arkayidonme4() {
    s4.SetActive(false);
    arka4.SetActive(true);
  }
  public void onedonme4() {
    s4.SetActive(true);
    arka4.SetActive(false);
  }


  public void kontrol1() {

    count1 = Convert.ToInt32(count);

    if (count1 >= 3) {

      i = TextSkor.GetComponent<Text>();
      Bir.instance.PuanStrSet(i.text);
      SceneManager.LoadScene("Tebrik1");
      /*if (Bir.instance) {
        x.text = Bir.instance.PuanGet().ToString();
      }*/



    } else {
            i = TextSkor.GetComponent<Text>();
            Bir.instance.PuanStrSet(i.text);
            SceneManager.LoadScene("Hata");

    }
  }
  public void kontrol2() {

        count1 = Convert.ToInt32(count);

        if (count1 >= 3)
        {

            i = TextSkor.GetComponent<Text>();
            Bir.instance.PuanStrSet(i.text);
            SceneManager.LoadScene("Tebrik2");
            /*if (Bir.instance) {
              x.text = Bir.instance.PuanGet().ToString();
            }*/



        }
        else
        {
            i = TextSkor.GetComponent<Text>();
            Bir.instance.PuanStrSet(i.text);
            SceneManager.LoadScene("Hata");

        }
    }
  public void kontrol3() {

        count1 = Convert.ToInt32(count);

        if (count1 >= 3)
        {

            i = TextSkor.GetComponent<Text>();
            Bir.instance.PuanStrSet(i.text);
            SceneManager.LoadScene("Tebrik3");
            /*if (Bir.instance) {
              x.text = Bir.instance.PuanGet().ToString();
            }*/



        }
        else
        {
            i = TextSkor.GetComponent<Text>();
            Bir.instance.PuanStrSet(i.text);
            SceneManager.LoadScene("Hata");

        }
    }
  public void kontrol4() {

        count1 = Convert.ToInt32(count);

        if (count1 >= 3)
        {

            i = TextSkor.GetComponent<Text>();
            Bir.instance.PuanStrSet(i.text);
            SceneManager.LoadScene("Tebrik4");
            /*if (Bir.instance) {
              x.text = Bir.instance.PuanGet().ToString();
            }*/



        }
        else
        {
            i = TextSkor.GetComponent<Text>();
            Bir.instance.PuanStrSet(i.text);
            SceneManager.LoadScene("Hata");

        }
    }
  public void kontrol5() {

        count1 = Convert.ToInt32(count);

        if (count1 >= 3)
        {

            i = TextSkor.GetComponent<Text>();
            Bir.instance.PuanStrSet(i.text);
            SceneManager.LoadScene("Tebrik5");
            /*if (Bir.instance) {
              x.text = Bir.instance.PuanGet().ToString();
            }*/



        }
        else
        {
            i = TextSkor.GetComponent<Text>();
            Bir.instance.PuanStrSet(i.text);
            SceneManager.LoadScene("Hata");

        }
    }
  public void kontrol6() {

        count1 = Convert.ToInt32(count);

        if (count1 >= 3)
        {

            i = TextSkor.GetComponent<Text>();
            Bir.instance.PuanStrSet(i.text);
            SceneManager.LoadScene("Tebrik6");
            /*if (Bir.instance) {
              x.text = Bir.instance.PuanGet().ToString();
            }*/



        }
        else
        {
            i = TextSkor.GetComponent<Text>();
            Bir.instance.PuanStrSet(i.text);
            SceneManager.LoadScene("Hata");

        }
    }
  public void kontrol7() {

        count1 = Convert.ToInt32(count);

        if (count1 >= 3)
        {

            i = TextSkor.GetComponent<Text>();
            Bir.instance.PuanStrSet(i.text);
            SceneManager.LoadScene("Tebrik7");
            /*if (Bir.instance) {
              x.text = Bir.instance.PuanGet().ToString();
            }*/



        }
        else
        {
            i = TextSkor.GetComponent<Text>();
            Bir.instance.PuanStrSet(i.text);
            SceneManager.LoadScene("Hata");

        }
    }
  public void kontrol8() {

        count1 = Convert.ToInt32(count);

        if (count1 >= 3)
        {

            i = TextSkor.GetComponent<Text>();
            Bir.instance.PuanStrSet(i.text);
            SceneManager.LoadScene("Tebrik8");
            /*if (Bir.instance) {
              x.text = Bir.instance.PuanGet().ToString();
            }*/



        }
        else
        {
            i = TextSkor.GetComponent<Text>();
            Bir.instance.PuanStrSet(i.text);
            SceneManager.LoadScene("Hata");

        }
    }
  public void kontrol9() {

        count1 = Convert.ToInt32(count);

        if (count1 >= 3)
        {

            i = TextSkor.GetComponent<Text>();
            Bir.instance.PuanStrSet(i.text);
            SceneManager.LoadScene("Tebrik9");
            /*if (Bir.instance) {
              x.text = Bir.instance.PuanGet().ToString();
            }*/



        }
        else
        {
            i = TextSkor.GetComponent<Text>();
            Bir.instance.PuanStrSet(i.text);
            SceneManager.LoadScene("Hata");

        }
    }
  public void kontrol10() {

        count1 = Convert.ToInt32(count);

        if (count1 >= 3)
        {

            i = TextSkor.GetComponent<Text>();
            Bir.instance.PuanStrSet(i.text);
            SceneManager.LoadScene("Tebrik10");
            /*if (Bir.instance) {
              x.text = Bir.instance.PuanGet().ToString();
            }*/



        }
        else
        {
            i = TextSkor.GetComponent<Text>();
            Bir.instance.PuanStrSet(i.text);
            SceneManager.LoadScene("Hata");

        }
    }
  public void kontrol11() {

        count1 = Convert.ToInt32(count);

        if (count1 >= 3)
        {

            i = TextSkor.GetComponent<Text>();
            Bir.instance.PuanStrSet(i.text);
            SceneManager.LoadScene("Tebrik11");
            /*if (Bir.instance) {
              x.text = Bir.instance.PuanGet().ToString();
            }*/



        }
        else
        {
            i = TextSkor.GetComponent<Text>();
            Bir.instance.PuanStrSet(i.text);
            SceneManager.LoadScene("Hata");

        }
    }
  public void kontrol12() {

        count1 = Convert.ToInt32(count);

        if (count1 >= 3)
        {

            i = TextSkor.GetComponent<Text>();
            Bir.instance.PuanStrSet(i.text);
            SceneManager.LoadScene("Tebrik12");
            /*if (Bir.instance) {
              x.text = Bir.instance.PuanGet().ToString();
            }*/



        }
        else
        {
            i = TextSkor.GetComponent<Text>();
            Bir.instance.PuanStrSet(i.text);
            SceneManager.LoadScene("Hata");

        }
    }
  public void kontrol13() {

        count1 = Convert.ToInt32(count);

        if (count1 >= 3)
        {

            i = TextSkor.GetComponent<Text>();
            Bir.instance.PuanStrSet(i.text);
            SceneManager.LoadScene("Tebrik13");
            /*if (Bir.instance) {
              x.text = Bir.instance.PuanGet().ToString();
            }*/



        }
        else
        {
            i = TextSkor.GetComponent<Text>();
            Bir.instance.PuanStrSet(i.text);
            SceneManager.LoadScene("Hata");

        }
    }
  public void kontrol14() {

        count1 = Convert.ToInt32(count);

        if (count1 >= 3)
        {

            i = TextSkor.GetComponent<Text>();
            Bir.instance.PuanStrSet(i.text);
            SceneManager.LoadScene("Tebrik14");
            /*if (Bir.instance) {
              x.text = Bir.instance.PuanGet().ToString();
            }*/



        }
        else
        {
            i = TextSkor.GetComponent<Text>();
            Bir.instance.PuanStrSet(i.text);
            SceneManager.LoadScene("Hata");

        }
    }
  public void kontrol15() {

        count1 = Convert.ToInt32(count);

        if (count1 >= 3)
        {

            i = TextSkor.GetComponent<Text>();
            Bir.instance.PuanStrSet(i.text);
            SceneManager.LoadScene("Tebrik15");
            /*if (Bir.instance) {
              x.text = Bir.instance.PuanGet().ToString();
            }*/



        }
        else
        {
            i = TextSkor.GetComponent<Text>();
            Bir.instance.PuanStrSet(i.text);
            SceneManager.LoadScene("Hata");

        }
    }
  public void kontrol16() {

        count1 = Convert.ToInt32(count);

        if (count1 >= 3)
        {

            i = TextSkor.GetComponent<Text>();
            Bir.instance.PuanStrSet(i.text);
            SceneManager.LoadScene("Tebrik16");
            /*if (Bir.instance) {
              x.text = Bir.instance.PuanGet().ToString();
            }*/



        }
        else
        {
            i = TextSkor.GetComponent<Text>();
            Bir.instance.PuanStrSet(i.text);
            SceneManager.LoadScene("Hata");

        }
    }
  public void kontrol17() {

        count1 = Convert.ToInt32(count);

        if (count1 >= 3)
        {

            i = TextSkor.GetComponent<Text>();
            Bir.instance.PuanStrSet(i.text);
            SceneManager.LoadScene("Tebrik17");
            /*if (Bir.instance) {
              x.text = Bir.instance.PuanGet().ToString();
            }*/



        }
        else
        {
            i = TextSkor.GetComponent<Text>();
            Bir.instance.PuanStrSet(i.text);
            SceneManager.LoadScene("Hata");

        }
    }
  public void kontrol18() {

        count1 = Convert.ToInt32(count);

        if (count1 >= 3)
        {

            i = TextSkor.GetComponent<Text>();
            Bir.instance.PuanStrSet(i.text);
            SceneManager.LoadScene("Tebrik18");
            /*if (Bir.instance) {
              x.text = Bir.instance.PuanGet().ToString();
            }*/



        }
        else
        {
            i = TextSkor.GetComponent<Text>();
            Bir.instance.PuanStrSet(i.text);
            SceneManager.LoadScene("Hata");

        }
    }
  public void gorunmez() {
    aciklama.SetActive(false);
  }

  public void arkayidonme5() {
    s5.SetActive(false);
    arka5.SetActive(true);
  }
  public void onedonme5() {
    s5.SetActive(true);
    arka5.SetActive(false);
  }
  public void skorartir1() {
    count = count + 1;
    i = TextSkor.GetComponent<Text>();

    i.text = count.ToString();
    /*if (Bir.instance) {
      Bir.instance.PuanSet(count);
    }*/

    d1.SetActive(false);
    y1.SetActive(false);
  }

  public void skorartir2() {
    count = count + 1;
    i = TextSkor.GetComponent<Text>();
    i.text = count.ToString();
    d2.SetActive(false);
    y2.SetActive(false);
  }
  public void skorartir3() {
    count = count + 1;
    i = TextSkor.GetComponent<Text>();
    i.text = count.ToString();
    d3.SetActive(false);
    y3.SetActive(false);
  }
  public void skorartir4() {
    count = count + 1;
    i = TextSkor.GetComponent<Text>();
    i.text = count.ToString();
    d4.SetActive(false);
    y4.SetActive(false);
  }
  public void skorartir5() {
    count = count + 1;
    i = TextSkor.GetComponent<Text>();
    i.text = count.ToString();
    d5.SetActive(false);
    y5.SetActive(false);
  }
  public void skorazalt1() {

    d1.SetActive(false);
    y1.SetActive(false);

  }
  public void skorazalt2() {

    d2.SetActive(false);
    y2.SetActive(false);

  }
  public void skorazalt3() {

    d3.SetActive(false);
    y3.SetActive(false);

  }
  public void skorazalt4() {

    d4.SetActive(false);
    y4.SetActive(false);

  }
  public void skorazalt5() {

    d5.SetActive(false);
    y5.SetActive(false);

  }


}
