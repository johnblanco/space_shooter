using UnityEngine;
using System.Collections;

public class MenuButton : MonoBehaviour {
  void OnMouseEnter(){
    toggleButtonSelection(guiText);
  }

  void OnMouseExit(){
    toggleButtonSelection(guiText);
  }

  void OnMouseDown(){
    if(tag == "1PButton"){
      Application.LoadLevel("Main");  
    }

    if(tag == "2PButton"){
      TwoPlayerFlag twoPlayerFlag = GameObject.Find("2PlayerFlag").GetComponent <TwoPlayerFlag>();
      twoPlayerFlag.twoPlayerGame = true;
      Application.LoadLevel("Main");
    }      


    if(tag == "QuitButton"){
      Application.Quit();
    }
  }

  void toggleButtonSelection(GUIText button){
    if(button.color == Color.white){
      button.color = Color.magenta;
    }else{
      button.color = Color.white;
    }
  }

}
