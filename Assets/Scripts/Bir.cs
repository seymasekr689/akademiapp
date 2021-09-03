using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//using UnityEngine.UI;
public class Bir : MonoBehaviour {
  public static Bir instance;
  private int skor;
  private static string skorstr;
  void Awake() {
    if (instance != null) {
      return;
    } else {
      instance = this;
    }
  }
  // Use this for initialization
  void Start() {
    Awake();
  }

  // Update is called once per frame
  void Update() {
    //Awake();
  }
  public void PuanSet(int _puan) {
    Debug.Log("PuanSet: " + skor.ToString());
    skor = _puan;
  }
  public int PuanGet() {
    Debug.Log("PuanGet: " + skor.ToString());
    return skor;
  }
  public void PuanStrSet(string _puan) {
    skorstr = _puan;
    Debug.Log("PuanStrSet: " + skorstr);
  }
  public string PuanStrGet() {
    Debug.Log("PuanStrGet: " + skorstr);
    return skorstr;
  }
}
