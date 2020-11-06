using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class BackTitle : MonoBehaviour
{

  // Use this for initialization
  void Start () {     
  }
     
  // Update is called once per frame
  void Update () {
  }

  public void toBackIndex()
  {
	SceneManager.LoadScene("Index");  
	Debug.Log("pushed");
  }
}
