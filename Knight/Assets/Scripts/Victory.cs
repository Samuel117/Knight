using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Victory : MonoBehaviour
{

    [SerializeField] GameObject fade;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Return))
        {
            fade.SetActive(true);
            Invoke("Cambio", 2f);
        }
    }

    private void Cambio()
    {
        SceneManager.LoadScene(0);
    }
}
