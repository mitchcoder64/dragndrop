using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class next : MonoBehaviour
{
    public int m;
    void OnCollisionEnter2D(Collision2D coll)
    { 
        
       SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + m);
    }
}
 