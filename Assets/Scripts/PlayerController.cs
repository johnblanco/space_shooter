using UnityEngine;
using System.Collections;

[System.Serializable]
public class Boundary
{
  public float xMin, xMax, zMin, zMax;
}

public class PlayerController : MonoBehaviour
{
  public float speed;
  public float tilt;
  public Boundary boundary;
  
  public GameObject shotSpawn;
  public Weapon currentWeapon;
  public int health;
  public EnergyBar energyBar;
  public bool isPlayer2;

  public void Start()
  {
    Debug.Log("no esta andando el player 2 porque nunca se llega a hacer setActive, el start salta solo una vez");
    Weapon weapon = new GuidedMissile(shotSpawn);
    weapon.fireRate = 0.20f;
    
    this.currentWeapon = weapon;

    if(GameObject.Find("2PlayerFlag") != null && isPlayer2){
      TwoPlayerFlag twoPlayerFlag = GameObject.Find("2PlayerFlag").GetComponent <TwoPlayerFlag>();
      if(twoPlayerFlag.twoPlayerGame){
        gameObject.SetActive(true);
        health = 100;
      }
    }

  }
    
  void Update()
  {
    if (Input.GetButton("Fire1") && !isPlayer2){        
      this.currentWeapon.Fire();
    }

    if (Input.GetButton("Fire2") && isPlayer2){
      this.currentWeapon.Fire();
    }

    energyBar.health = health;
  }

  void FixedUpdate()
  {
    float moveHorizontal;
    float moveVertical;

    if(!isPlayer2){
      moveHorizontal = Input.GetAxis("Horizontal");
      moveVertical = Input.GetAxis("Vertical");
    }else{
      moveHorizontal = Input.GetAxis("Player2Horizontal");
      moveVertical = Input.GetAxis("Player2Vertical");
    }

    Vector3 movement = new Vector3(moveHorizontal, 0.0f, moveVertical);
    rigidbody.velocity = movement * speed;
      
    rigidbody.position = new Vector3
      (
        Mathf.Clamp(rigidbody.position.x, boundary.xMin, boundary.xMax), 
        0.0f, 
        Mathf.Clamp(rigidbody.position.z, boundary.zMin, boundary.zMax)
    );
      
    rigidbody.rotation = Quaternion.Euler(0.0f, 0.0f, rigidbody.velocity.x * -tilt);
  }
}
