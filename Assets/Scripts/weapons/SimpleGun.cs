// ------------------------------------------------------------------------------
//  <autogenerated>
//      This code was generated by a tool.
//      Mono Runtime Version: 4.0.30319.1
// 
//      Changes to this file may cause incorrect behavior and will be lost if 
//      the code is regenerated.
//  </autogenerated>
// ------------------------------------------------------------------------------
using System;
using UnityEngine;
using _r = ResourceLoader;

public class SimpleGun : Weapon
{
  public GameObject shot;
  
  private float nextFire;
  
  public SimpleGun(GameObject spawnObject) : base(spawnObject)
  {

    
    this.shot = _r.Load<GameObject>("Prefabs/Bolt");
    this.spawnObject.AddComponent<AudioSource>();
    this.spawnObject.audio.clip = _r.Load<AudioClip>("Audio/weapon_player");
    
  }
  
  public override void Fire()
  {
    if (Time.time > nextFire)
      {
        nextFire = Time.time + fireRate;
        
        GameObject.Instantiate(this.shot, spawnObject.transform.position, Quaternion.Euler(0.0f, 0.0f, 0.0f));
        
        this.spawnObject.audio.Play();
      }
  }
}


