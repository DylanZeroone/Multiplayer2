using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHealth : MonoBehaviour
{
  public int health;
  public int damage;

  public void TakeDamage(int damage)
  {
    Debug.Log("Health Works");
  }
  private void OnCollisionEnter(Collision collision)
    {
    if(collision.gameObject.tag == "Bullet")
      {
        health -= damage;
      }
    }
}
