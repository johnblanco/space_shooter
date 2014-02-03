using UnityEngine;
using System.Collections;

public class KeyboardController : MonoBehaviour {
  public GUIText[] buttons;

  int selectedOptionIndex;
  
  void Start(){
    selectedOptionIndex=0;
  }

  void Update() {
    if (Input.GetKeyDown(KeyCode.DownArrow) && selectedOptionIndex < buttons.Length-1){
      selectedOptionIndex++;
    }
    if (Input.GetKeyDown(KeyCode.UpArrow) && selectedOptionIndex > 0 ){
      selectedOptionIndex--;
    }
    for(int i=0;i<buttons.Length;i++){
      buttons[i].color = Color.white;
    }
    buttons[selectedOptionIndex].color = Color.magenta;

    if (Input.GetKeyDown(KeyCode.Return)){
      if(selectedOptionIndex==0)
        Application.LoadLevel("Main");
    }
  }

}
