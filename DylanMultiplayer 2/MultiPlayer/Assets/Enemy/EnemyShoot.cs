using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyShoot : MonoBehaviour
{
    public GameObject bulletPrefab;
    public GameObject bulletPrefab2;
    public GameObject bulletSpawnPoint1;
    public GameObject bulletSpawnPoint2;

    public void Shooting()
    {
      bulletSpawnPoint1 = transform.GetChild(2).GetChild(0).gameObject;
      Debug.Log(transform.childCount);
      bulletSpawnPoint2 = transform.GetChild(3).GetChild(0).gameObject;
      GameObject bullet = Instantiate(bulletPrefab, bulletSpawnPoint1.transform.position, bulletSpawnPoint1.transform.rotation);
      GameObject bullet2 = Instantiate(bulletPrefab2, bulletSpawnPoint2.transform.position, bulletSpawnPoint2.transform.rotation);

    }

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("EnemyShoot Class Start Method Logging");

    }

    // Update is called once per frame
    void Update()
    {
      int DieRoll = Random.Range(1,201);
      //Debug.Log("DieRoll: " + DieRoll.ToString());
      if (DieRoll == 200)
      {
        Shooting();
      }
//    Random int 1d100
//    if 100 then shoot
    }
}
