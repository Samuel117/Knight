using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Flecha : MonoBehaviour
{
    protected float velocidad = 20f;
    private Vector2 direccionDisparo;

    // Start is called before the first frame update
    void Start()
    {
        EncontrarJugador();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void FixedUpdate()
    {
        MoverProyectil();    
    }

    protected void MoverProyectil()
    {
        this.GetComponent<Rigidbody2D>().AddForce(this.direccionDisparo * this.velocidad);
    }

    protected void EncontrarJugador()
    {
        if (FindObjectOfType<Jugador>() != null)
        {
           Vector3 futuro = new Vector2(GameObject.FindObjectOfType<Jugador>().transform.position.x + 2f, GameObject.FindObjectOfType<Jugador>().transform.position.y);
            direccionDisparo = ( futuro - this.transform.position).normalized;
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        Destroy(this.gameObject);
    }
}

