using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using System.Data;
using System.Data.SqlClient;
using UnityEngine.SceneManagement;
public class sql2 : MonoBehaviour
{
    private string cs;
    public GameObject isim, sifre,uyari;

    public void Kontrol()
    {
        SqlConnection con;
        SqlDataReader dr;
        SqlCommand cs;
        SqlConnectionStringBuilder builder = new SqlConnectionStringBuilder();
       

        builder = new SqlConnectionStringBuilder();
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
                string sql = "Select email,sifre FROM tablo1 where email='" + isim.GetComponent<Text>().text + "' and sifre='" + sifre.GetComponent<Text>().text + "'";
                
                using (SqlCommand command = new SqlCommand(sql, connection))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            if (!reader.IsDBNull(0))
                            {
                                string email = reader.GetString(0);
                                string sifre = reader.GetString(1);
                                
                                SceneManager.LoadScene("BaslamaOnEkran");
                            }
                            else
                            {
                                uyari.SetActive(false);
                            }

                        }
                    }
                }
            }

        }
        catch (SqlException e)
        {
            UnityEngine.Debug.Log(e.ToString());
        }
    }
    }
