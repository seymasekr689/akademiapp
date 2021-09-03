using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using System.Data;
using System.Data.SqlClient;
using UnityEngine.SceneManagement;
public class Sql : MonoBehaviour
{
	private string cs;
	public GameObject isim, soyisim, telefon, email, tc, sifre;
	void Start()
	{



	}

	void Update()
	{

	}
	public void ToSql()
	{
		SqlConnectionStringBuilder builder = new SqlConnectionStringBuilder();
		builder.DataSource = "DESKTOP-TQ6AHHK\\SQLEXPRESS";
		builder.UserID = "Bilsoft";
		builder.Password = "1234";
		builder.InitialCatalog = "quizoyunu";
		try
		{
			using (SqlConnection connection = new SqlConnection(builder.ConnectionString))
			{
				connection.Open();
				UnityEngine.Debug.Log("Veritabanına bağlandı.");
				string insert_sql = "INSERT INTO tablo1(isim,soyisim,telefon,email,tc,sifre) VALUES('" + isim.GetComponent<Text>().text + "','"
					+ soyisim.GetComponent<Text>().text + "','" + telefon.GetComponent<Text>().text + "','" + email.GetComponent<Text>().text +
					"','" + tc.GetComponent<Text>().text + "','" + sifre.GetComponent<Text>().text + "')";
				SceneManager.LoadScene("BaslamaOnEkran");
				using (SqlCommand cmd2 = new SqlCommand(insert_sql, connection))
				{
					cmd2.ExecuteNonQuery();
				}
			}
		}
		catch (SqlException e)
		{
			UnityEngine.Debug.Log(e.ToString());
		}
	}
	public void FromSql()
	{
		SqlConnection SqlConn = new SqlConnection(cs);
		SqlConn.Open();
		SqlCommand cmd = new SqlCommand("SELECT * FROM tablo1", SqlConn);
		Debug.Log(cmd);
		SqlConn.Close();
	}
}