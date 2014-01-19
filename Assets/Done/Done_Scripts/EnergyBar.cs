using UnityEngine;
using System.Collections;

public class EnergyBar : MonoBehaviour {
  public GUITexture healthBar;
  public int health;

  private int previousHealth;

  void Start () {
    previousHealth = -1;
	}

  void Update(){
    //100 de vida -> 25 barritas
    //4 -> 1
    //8 -> 2
    if(health != previousHealth){
      GameObject[] healthBars = GameObject.FindGameObjectsWithTag("HealthBar"); //obtengo barritas que habia
      foreach (GameObject hb in healthBars) {
        Destroy(hb);
      }

      int barAmount = health/4;
      Rect pixelInset = healthBar.pixelInset;

      for(int i=0; i < barAmount; i++){
        GUITexture texture = Instantiate(healthBar, transform.position + Vector3.forward, Quaternion.identity) as GUITexture; 
        texture.pixelInset = pixelInset;
        pixelInset.x += 5;

      }
      previousHealth = health;
    }
    
  }
}
