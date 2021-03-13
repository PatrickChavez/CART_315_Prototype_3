using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthPickup : MonoBehaviour
{
    // Tutorials from WallaceT_MFM and antiquote 
    public string healthpickuptag;
    public GameObject player;
    public Text textComponent;
    //public float playerHealth;
    public float healthGain = 1f;
    // Referencing the PlayerHealth script
    //public GameObject playerHealthScript;
    PlayerHealth playerHealthScript;

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.gameObject.CompareTag(healthpickuptag))
        {
            //playerHealth = playerHealth + healthGain;
            GetComponent<PlayerHealth>().currentHealth = GetComponent<PlayerHealth>().currentHealth + healthGain;

            Debug.Log("Life gain!");
            Destroy(collision.collider.gameObject);
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {

    }
}
