using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LevelManager : MonoBehaviour
{

    [HideInInspector] public float health;
    [HideInInspector] public int ammo;
    public float damageMultiplyer = 1.0f;
    public Text HealthText;
    public Text AmmoText;


    // Start is called before the first frame update
    void Start()
    {

        Debug.Log("Level Manager Class Start Method Logging");

    }

    // Update is called once per frame
    void Update()
    {

    }

}
