using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Gun : MonoBehaviour
{
    public GameObject bulletPrefab;
    public GameObject bulletSpawnPoint;
    public int ammo;
    public int shots;
    public Text ammoDisplay;

    public void TakeDamage(int shots)
    {
      ammo -= shots;
      Debug.Log("Ammo = " + ammo.ToString());
    }
    // Start is called before the first frame update
    void Start()
    {

        // This should reference Shotgun_default
        //transform.GetChild(0).GetChild(0).localPosition = new Vector3(742,4,403);
        bulletSpawnPoint = transform.GetChild(0).GetChild(0).gameObject;
        Debug.Log("Gun Class Start Method Logging");
        Debug.Log(bulletSpawnPoint.GetInstanceID());
        Debug.Log(transform.childCount);
        Debug.Log(bulletSpawnPoint.transform.position.ToString());
        Debug.Log(bulletSpawnPoint.transform.localPosition.ToString());
        Debug.Log(bulletPrefab.transform.position.ToString());
    }

    // Update is called once per frame
    void Update()
    {

      ammoDisplay.text = ammo.ToString();

      if (Input.GetMouseButtonDown(0)){

        Debug.Log("Gun Class Fire Method Logging");

        if (ammo == 0)
          {
            Debug.Log("out of Ammo");
          }
        else
          {
            GameObject bullet = Instantiate(bulletPrefab, bulletSpawnPoint.transform.position, bulletSpawnPoint.transform.rotation);
            Debug.Log("bullet spawn point = " + bulletSpawnPoint.transform.position.ToString());
            Debug.Log("bullet spawn point rotation = " + bulletSpawnPoint.transform.rotation.ToString());
            shots = ammo -= 1;
            //bulletPrefab.AddForce(spawnPoint.forward * 1000f);
          }
    }
    if(Input.GetMouseButtonDown(1))
    {
      if(ammo == 0)
      {
        ammo = 10;
      }
    }
  }

}
