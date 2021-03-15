using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MazeStart : MonoBehaviour
{
    public string mazestarttag;

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.gameObject.CompareTag(mazestarttag))
        {
            Debug.Log("Collision detected with pickup");
            //Destroy(collision.collider.gameObject);
            SceneManager.LoadScene("MazeCourse");
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
