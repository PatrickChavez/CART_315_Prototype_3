using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GoalStart : MonoBehaviour
{
    public string goaltag;

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.gameObject.CompareTag(goaltag))
        {
            Debug.Log("Nice!");
            //Destroy(collision.collider.gameObject);
            SceneManager.LoadScene("Ending");
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
