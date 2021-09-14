using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Cabeza : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.tag == "Flecha" || collision.gameObject.tag == "Barril")
        {
            FindObjectOfType<Player>().PlayGrunt();
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }
    }
}
