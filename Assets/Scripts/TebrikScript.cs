using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(Text))]
public class TebrikScript : MonoBehaviour {
    public Text  tebrik;
  // Start is called before the first frame update
  void Start() {
   // tebrik = GetComponent<Text>();
    tebrik.text = Bir.instance.PuanStrGet();
  }

  // Update is called once per frame
  void Update() {

  }
}
