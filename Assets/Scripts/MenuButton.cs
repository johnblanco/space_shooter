using UnityEngine;
using System.Collections;

public class MenuButton : MonoBehaviour {
  void OnMouseDown(){
    if(tag == "1PButton"){
      Application.LoadLevel("Main");  
    }

    if(tag == "QuitButton"){
      Application.Quit();
    }
  }

  void OnMouseOver(){
    guiText.color = Color.magenta;
  }

  void OnMouseExit(){
    guiText.color = Color.white;
  }
}
