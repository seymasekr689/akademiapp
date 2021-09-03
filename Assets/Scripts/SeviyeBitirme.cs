using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System.Linq;
public class SeviyeBitirme : MonoBehaviour
{
	public static bool Soru1, Soru2, Soru3, Soru4, Soru5, Soru6, Soru7, Soru8, Soru9, Soru10, Soru11, Soru12, Soru13, Soru14, Soru15, Soru16,
		Soru17, Soru18;
	// Use this for initialization
	public void seviye1()
    {

        //gameObject.GetComponent<seviyeleryoneticisi>().Soru2=true;
        seviyeleryoneticisi.Soru2 = true;
        SceneManager.LoadScene("Videolar");
		//var dizi = SceneManager.GetActiveScene().GetRootGameObjects();
  //      //Debug.Log(dizi.Length);
  //      //dizi[0].GetComponent<seviyeleryoneticisi>().Soru2 = true;
  //      dizi.Where(x => x.name == "SeviyeBitirmeYoneticisi").FirstOrDefault().GetComponent<seviyeleryoneticisi>().Soru2 = true;
        //Debug.Log(string.Join(",", dizi.Select(x => x.name).ToArray()));
	}
	public void seviye2()
	{
		seviyeleryoneticisi.Soru3 = true;
		SceneManager.LoadScene("Videolar");
	}
	public void seviye3()
	{
		seviyeleryoneticisi.Soru4 = true;
		SceneManager.LoadScene("Videolar");
	}
	public void seviye4()
	{
		seviyeleryoneticisi.Soru5= true;
		SceneManager.LoadScene("Videolar");
	}
	public void seviye5()
	{
		seviyeleryoneticisi.Soru6 = true;
		SceneManager.LoadScene("Videolar");
	}
	public void seviye6()
	{

		seviyeleryoneticisi.Soru7 = true;
		SceneManager.LoadScene("Videolar");
	}
	public void seviye7()
	{
		seviyeleryoneticisi.Soru8 = true;
		SceneManager.LoadScene("Videolar");
	}
	public void seviye8()
	{
		seviyeleryoneticisi.Soru9 = true;
		SceneManager.LoadScene("Videolar");
	}
	public void seviye9()
	{
		seviyeleryoneticisi.Soru10 = true;
		SceneManager.LoadScene("Videolar");
	}
	public void seviye10()
	{
		seviyeleryoneticisi.Soru11 = true;
		SceneManager.LoadScene("Videolar");
	}
	public void seviye11()
	{
		seviyeleryoneticisi.Soru12 = true;
		SceneManager.LoadScene("Videolar");
	}
	public void seviye12()
	{
		seviyeleryoneticisi.Soru13 = true;
		SceneManager.LoadScene("Videolar");
	}
	public void seviye13()
	{
		seviyeleryoneticisi.Soru14 = true;
		SceneManager.LoadScene("Videolar");
	}
	public void seviye14()
	{
		seviyeleryoneticisi.Soru15 = true;
		SceneManager.LoadScene("Videolar");
	}
	public void seviye15()
	{
		seviyeleryoneticisi.Soru16 = true;
		SceneManager.LoadScene("Videolar");
	}
	public void seviye16()
	{
		seviyeleryoneticisi.Soru17= true;
		SceneManager.LoadScene("Videolar");
	}
	public void seviye17()
	{
		seviyeleryoneticisi.Soru18 = true;
		SceneManager.LoadScene("Videolar");
	}
	public void seviye18()
    {
		SceneManager.LoadScene("Videolar");
	}
	
}
