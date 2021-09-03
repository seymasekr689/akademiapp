using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(Text))]
public class dort : MonoBehaviour
{
    public Text tebrik2;
    // Start is called before the first frame update
    void Start()
    {
        // tebrik = GetComponent<Text>();
        tebrik2.text = PlayerPrefs.GetString("D");
    }

    // Update is called once per frame
    void Update()
    {

    }
}

