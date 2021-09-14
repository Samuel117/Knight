using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Barril : MonoBehaviour
{

    public bool destruir = false;

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
        if (collision.gameObject.GetComponent<Espada>() != null)
        {
            this.GetComponent<Animator>().SetBool("destruir", true);
            //this.GetComponent<Collider2D>().enabled = false;
            this.GetComponent<AudioSource>().Play();
            destruir = true;
        }
    }

    public void Destruir()
    {
        Destroy(this.gameObject);
    }

    private void Desactivar()
    {
        this.gameObject.GetComponent<Rigidbody2D>().isKinematic = true;
    }
}
