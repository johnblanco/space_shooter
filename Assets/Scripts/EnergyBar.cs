using UnityEngine;
using System.Collections;

public class EnergyBar : MonoBehaviour {
  public GUITexture healthBar;
  public GUITexture healthBar2;
  public int health;

  private int previousHealth;
  public bool isPlayer2;

  void Start () {
    previousHealth = -1;

    if(GameObject.Find("2PlayerFlag") != null && isPlayer2){
      TwoPlayerFlag twoPlayerFlag = GameObject.Find("2PlayerFlag").GetComponent <TwoPlayerFlag>();
      if(twoPlayerFlag.twoPlayerGame){
        health = 100;
      }else{
        gameObject.SetActive(false);
      }
    }

    if(GameObject.Find("2PlayerFlag") == null && isPlayer2){
      gameObject.SetActive(false);
    }


	}

  void Update(){
    if(health != previousHealth){
      GameObject[] healthBars;
      Rect pixelInset;
      GUITexture newBar;

      if(isPlayer2){
        //Debug.Break();
        healthBars = GameObject.FindGameObjectsWithTag("HealthBar2"); //obtengo barritas que habia
        pixelInset = healthBar2.pixelInset;
        newBar = healthBar2;
      }else{
        healthBars = GameObject.FindGameObjectsWithTag("HealthBar"); //obtengo barritas que habia
        pixelInset = healthBar.pixelInset;
        newBar = healthBar;
      }
       
      foreach (GameObject hb in healthBars) {
        Destroy(hb);
      }

      int barAmount = health/4;

      for(int i=0; i < barAmount; i++){
        GUITexture texture = Instantiate(newBar, transform.position + Vector3.forward, Quaternion.identity) as GUITexture; 
        texture.pixelInset = pixelInset;
        pixelInset.x += 5;

      }
      previousHealth = health;
    }
    
  }
}