using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Win : MonoBehaviour
{
    [SerializeField] GameObject Fade;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Fade.SetActive(true);
        Invoke("Cambiar", 2f);
    }

    private void Cambiar()
    {
        Destroy(FindObjectOfType<Player>().gameObject);
        SceneManager.LoadScene(3);
    }
}
