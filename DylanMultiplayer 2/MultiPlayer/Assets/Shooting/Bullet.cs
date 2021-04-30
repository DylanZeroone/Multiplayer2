using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Bullet : MonoBehaviour
{
  public float bulletSpeed = 100.0f;
  GameObject LevelManager;



  void Start()
  {
      LevelManager = GameObject.FindGameObjectWithTag("LevelManager");

      gameObject.GetComponent<Rigidbody>().velocity = transform.forward * bulletSpeed;
  }
  private void OnCollisionEnter(Collision collision)
  {
    if(collision.gameObject.tag == "Enemy")
    {
        Destroy(collision.gameObject);
        Destroy(gameObject);
    }
    if(collision.gameObject)
    {
      Destroy(gameObject);
    }

  }
}
